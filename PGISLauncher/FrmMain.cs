using DevExpress.XtraEditors;
using Helpers.Interface;
using Helpers.Service;
using Helpers.Utility;
using Helpers.Utility.Model;
using Model.Manager;
using Model.Repository;
using Model.UserManager;
using Model.ViewModel;
using PGISLauncher.Base;
using PGISLauncher.DashboardForms;
using PGISLauncher.LoginForms;
using PGISLauncher.Properties;
using PGISLauncher.ToolForms;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGISLauncher
{
    public partial class FrmMain : BaseForm
    {
        private readonly ILauncher _launcher;
        private DirectoryData _directoryData;
        private readonly IUCManager<UCSystemDetails> _ucManager;
        private bool _logout = false;
        public FrmMain()
        {
            InitializeComponent();
            _launcher = new Launcher();
            _ucManager = new UCManager<UCSystemDetails>(panelDetails);

            var frm = new FrmLogin();
            frm.ShowDialog();
        }

        private void SetAdminCreds()
        {
            foreach(var ctrl in pnlAdminButtons.Controls)
            {
                ((SimpleButton)ctrl).Visible = false;
            }
        }

        public async Task LoadData()
        {
            if (UserStore.UserRole == Model.Enum.UserRole.user) SetAdminCreds();
            lblUsername.Text = UserStore.OFMISUserDto?.Username;
            UserAppManager.InitManager();
            var unitOfWork = new UnitOfWork();

            var userApps = await UserAppManager.GetUserApps(UserStore.OFMISUserDto?.OFMISId);
            var data = userApps.Select(x => new SystemInfoViewModel{ SystemInformation = x }).ToList();
            foreach (var item in data)
            {
                _directoryData = _launcher.IsShortcutPresentAsync(item.SystemInformation.PublisherName, item.SystemInformation.ProductName);
                if (_directoryData == null) item.AppImage = Resources.PGNV;
                else item.AppImage = ClickOnceIcon.GetIcon(_directoryData.AppPath);
            }
            gcApps.DataSource = data.ToList();
        }

        private void LoadDetails()
        {
            var row = (SystemInfoViewModel)tvApps.GetFocusedRow();
            _ucManager.ShowUCSystemDetails(row.SystemInformation.Id.ToString(), row);
        }
        private void tvApps_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            LoadDetails();
        }

        private async void btnAppSettings_Click(object sender, System.EventArgs e)
        {
            var row = (SystemInfoViewModel)tvApps.GetFocusedRow();
            var frm = new FrmAppSettings(row.SystemInformation);
            frm.ShowDialog();

            await LoadData();
        }

        private async void FrmMain_Load(object sender, System.EventArgs e)
        {
            await LoadData();
        }

        private async void btnAddApp_Click(object sender, System.EventArgs e)
        {
            var frm = new FrmAppSettings();
            frm.ShowDialog();

            await LoadData();
        }

        private async void btnDefaultApps_Click(object sender, System.EventArgs e)
        {
            var frm = new FrmDefaultApps();
            frm.ShowDialog();

            await LoadData();
        }

        private async void btnUserAccess_Click(object sender, System.EventArgs e)
        {
            var frm = new FrmUserAccess();
            frm.ShowDialog();

            await LoadData();
        }

        private void btnLogout_Click(object sender, System.EventArgs e)
        {
            _logout = true;
            this.Close();
        }

        private void FrmMain_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if(!_logout) Application.Exit();
            else
            {
                e.Cancel = true;
                _logout = false;
                var frm = new FrmLogin(this);
                frm.ShowDialog();
            }
        }
    }
}
