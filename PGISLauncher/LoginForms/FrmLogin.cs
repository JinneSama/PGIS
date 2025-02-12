using Helpers.Interface;
using Helpers.Security;
using Model.Enum;
using Model.Interface;
using Model.Repository;
using Model.Service;
using Model.Service.Dto;
using Model.UserManager;
using PGISLauncher.Base;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGISLauncher.LoginForms
{
    public partial class FrmLogin : BaseForm
    {
        private readonly OFMISService _service;
        private readonly ICryptography _cryptography;
        private readonly FrmMain _frmMain;
        private bool _isLogged = false;
        public FrmLogin()
        {
            InitializeComponent();
            _service = new OFMISService();
            _cryptography = new Cryptography();
            LoadCredentials();
        }
        public FrmLogin(FrmMain frmMain)
        {
            InitializeComponent();
            _frmMain = frmMain;
            _service = new OFMISService();
            _cryptography = new Cryptography();
            LoadCredentials();
        }

        private async Task<OFMISUsersDto> AuthenticateUser(string username, string password)
        {
            var ofmisUser = await _service.GetUser(username);
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

        private async Task<UserRole> PointToSystemAccount(string OFMISId)
        {
            IUnitOfWork unitOfWork = new UnitOfWork();
            var user = await unitOfWork.UserAccessRepo.FindAsync(x => x.OFMISId == OFMISId);
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