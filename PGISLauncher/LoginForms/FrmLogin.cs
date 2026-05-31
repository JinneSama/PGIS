using DevExpress.ClipboardSource.SpreadsheetML;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using PGISLauncher.API.Common;
using PGISLauncher.API.Service;
using PGISLauncher.Base;
using PGISLauncher.Core.Enums;
using PGISLauncher.DataModels.DTO;
using PGISLauncher.Interfaces;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGISLauncher.LoginForms
{
    public partial class FrmLogin : BaseForm
    {
        private readonly ISerializeData _serializeDataHandler;
        private readonly ICryptography _cryptography;
        private readonly IServiceProvider _serviceProvider;
        private readonly IAccesService _accesService;

        private readonly OFMISService _ofmisService;
        private readonly UserStore _userStore;
        private readonly FrmMain _frmMain;
        private bool _isLogged = false;
        public bool FromMain { get; set; } = false;
        public FrmLogin(ICryptography cryptography, ISerializeData serializeData, 
            IServiceProvider serviceProvider, OFMISService ofmisService, IAccesService accesService,
            UserStore userStore)
        {
            _serviceProvider = serviceProvider; 
            _ofmisService = ofmisService;
            _cryptography = cryptography;
            _serializeDataHandler = serializeData;
            _accesService = accesService;
            _userStore = userStore;
            InitializeComponent();
            LoadCredentials();
            if(FromMain) _frmMain = _serviceProvider.GetRequiredService<FrmMain>();
        }
        public async Task<bool> AttemptAuthWithJSONLogger()
        {
            string filePath = Path.Combine(Path.GetTempPath(), "credentials.json");
            if (!File.Exists(filePath)) return false;

            string json = File.ReadAllText(filePath);
            var credentials = JsonConvert.DeserializeObject<ArgumentCredentialsDto>(json);

            var ofmisUser = await _ofmisService.GetUser(credentials.Username);
            var user = await _accesService.UserAccessService.GetByFilterAsync(x => x.OFMISId == ofmisUser.OFMISId);

            if (user == null) return false;
            UserStore userStore = new UserStore(credentials.Username, credentials.Password, ofmisUser, user.UserRole);
            return true;
        }
        private async Task<OFMISUsersDto> AuthenticateUser(string username, string password)
        {
            var ofmisUser = await _ofmisService.GetUser(username);
            if (ofmisUser == null) return null;

            var decryptPass = _cryptography.Decrypt(ofmisUser.PasswordHash, ofmisUser.SecurityStamp);
            if (Equals(decryptPass, password)) return ofmisUser;
            else return null;
        }

        private async void btnLogin_Click(object sender, System.EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            var authUser = await AuthenticateUser(username, password);
            if (authUser == null) AuthFailed();
            else await AuthPassed(authUser, username , password);
        }

        private async Task AuthPassed(OFMISUsersDto authUser, string username, string password)
        {
            var userRole = await PointToSystemAccount(authUser.OFMISId);
            SaveCredentials(username, password, authUser, userRole);
            _isLogged = true;
            if (_frmMain != null) await _frmMain.LoadData();
            this.Close();
        }

        private void GenerateJSONLogger()
        {
            string filePath = Path.Combine(Path.GetTempPath(), "credentials.json");
            string json = _serializeDataHandler.Serialize(_userStore.Credentials);
            File.WriteAllText(filePath, json);
        }

        private async Task<UserRole> PointToSystemAccount(string OFMISId)
        {
            var user = await _accesService.UserAccessService.GetByFilterAsync(x => x.OFMISId == OFMISId);
            if (user == null) return UserRole.user;
            else return user.UserRole;
        }

        private void LoadCredentials()
        {
            txtUsername.Text = Properties.Settings.Default.Username;
            txtPassword.Text = Properties.Settings.Default.Password;
            chkRemember.Checked = Properties.Settings.Default.RememberMe;
        }

        private void SaveCredentials(string username, string password, OFMISUsersDto authUser, UserRole userRole)
        {
            UserStore userStore = new UserStore(username, password, authUser, userRole);
            if (!chkRemember.Checked) return;

            GenerateJSONLogger();
            Properties.Settings.Default.Username = username;
            Properties.Settings.Default.Password = password;
            Properties.Settings.Default.RememberMe = true;
            Properties.Settings.Default.Save();
        }

        private void AuthFailed()
        {
            MessageBox.Show("Username and/or Password is Incorrect!", "Confirmation",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FrmLogin_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (!_isLogged) Application.Exit();
        }
    }
}