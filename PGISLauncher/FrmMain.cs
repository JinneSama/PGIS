using DevExpress.XtraEditors;
using Helpers.Interface;
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
using System.IO;
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
        private bool _fullExit = false;
        public FrmMain()
        {
            InitializeComponent();
            _launcher = new Launcher();
            _ucManager = new UCManager<UCSystemDetails>(panelDetails);
        }

        private void SetAdminCreds(bool v)
        {
            foreach(var ctrl in pnlAdminButtons.Controls)
            {
                ((SimpleButton)ctrl).Visible = v;
            }
        }

        public async Task LoadData()
        {
            int rowHandle = tvApps.FocusedRowHandle;
            if (UserStore.UserRole == Model.Enum.UserRole.user) SetAdminCreds(false);
            else SetAdminCreds(true);
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
                item.InstallInfo = _directoryData == null ? "NOT INSTALLED" : "";
            }
            gcApps.DataSource = data.ToList();

            if(rowHandle < 0) return;
            tvApps.FocusedRowHandle = rowHandle;
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
            var frm = new FrmLogin();
            if (await frm.AttemptAuthWithJSONLogger())
            { 
                await LoadData();
                return;
            }

            frm.ShowDialog();
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
            if (!_logout)
            {
                if (_fullExit) return;
                e.Cancel = true;
                this.Hide();
                notifyIcon.ShowBalloonTip(1000, "App Hidden", "Running in the background", ToolTipIcon.Info);
            }
            else
                LogoutAction(sender,e);
        }

        private void LogoutAction(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            _logout = false;
            string filePath = Path.Combine(Path.GetTempPath(), "credentials.json");
            File.Delete(filePath);
            var frm = new FrmLogin(this);
            frm.ShowDialog();
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                notifyMenu.ShowPopup(MousePosition);
            }
            else if (e.Button == MouseButtons.Left)
            {
                ShowForm();
            }
        }
        public void ShowForm()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void btnNotifLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _logout = true;
            this.Close();
        }

        private void btnNotifExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _fullExit = true;
            Application.Exit();
        }
    }
}
