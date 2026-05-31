using DevExpress.XtraEditors;
using Microsoft.Extensions.DependencyInjection;
using PGISLauncher.API.Common;
using PGISLauncher.API.Manager;
using PGISLauncher.Base;
using PGISLauncher.Core.Enums;
using PGISLauncher.DashboardForms;
using PGISLauncher.DataModels;
using PGISLauncher.Interfaces;
using PGISLauncher.LoginForms;
using PGISLauncher.Properties;
using PGISLauncher.ToolForms;
using PGISLauncher.Utility;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGISLauncher
{
    public partial class FrmMain : BaseForm
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ILauncher _launcher;
        private readonly IUCManager<UCSystemDetails> _ucManager;

        private readonly UserStore _userStore;
        private DirectoryData _directoryData;
        private bool _logout = false;
        private bool _fullExit = false;
        public FrmMain(ILauncher launcher, IServiceProvider serviceProvider, UserStore userStore,
            IUCManager<UCSystemDetails> ucManager)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _launcher = launcher;
            _ucManager = ucManager;
            _ucManager.SetControls(panelDetails);
            _userStore = userStore;
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
            int rowHandle = gridApps.FocusedRowHandle;
            if (_userStore.UserRole == UserRole.user) SetAdminCreds(false);
            else SetAdminCreds(true);

            lblUsername.Text = _userStore.OFMISUserDto?.Username;
            var userAppManager = _serviceProvider.GetRequiredService<UserAppManager>();

            var userApps = await userAppManager.GetUserApps(_userStore.OFMISUserDto);
            var data = userApps.Select(x => new SystemInfoViewModel{ SystemInformation = x }).ToList();
            foreach (var item in data)
            {
                _directoryData = _launcher.IsShortcutPresentAsync(item.SystemInformation.PublisherName, item.SystemInformation.ProductName);
                if (_directoryData == null) item.AppImage = Resources.PGNV;
                else item.AppImage = _serviceProvider.GetRequiredService<ClickOnceIcon>().GetIcon(_directoryData.AppPath);
                item.InstallInfo = _directoryData == null ? "NOT INSTALLED" : "";
            }
            gcApps.DataSource = data.ToList();

            if(rowHandle < 0) return;
            gridApps.FocusedRowHandle = rowHandle;
        }

        private void LoadDetails()
        {
            var row = (SystemInfoViewModel)gridApps.GetFocusedRow();
            _ucManager.ShowUCSystemDetails(row.SystemInformation.Id.ToString(), row);
        }
        private void tvApps_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            LoadDetails();
        }

        private async void btnAppSettings_Click(object sender, System.EventArgs e)
        {
            var row = (SystemInfoViewModel)gridApps.GetFocusedRow();
            var frm = _serviceProvider.GetRequiredService<FrmAppSettings>();
            frm.InitForm(row.SystemInformation);
            frm.ShowDialog();

            await LoadData();
        }

        private async void FrmMain_Load(object sender, System.EventArgs e)
        {
            var frm = _serviceProvider.GetRequiredService<FrmLogin>();
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
            var frm = _serviceProvider.GetRequiredService<FrmAppSettings>();
            frm.ShowDialog();

            await LoadData();
        }

        private async void btnDefaultApps_Click(object sender, System.EventArgs e)
        {
            var frm = _serviceProvider.GetRequiredService<FrmDefaultApps>();
            frm.ShowDialog();

            await LoadData();
        }

        private async void btnUserAccess_Click(object sender, System.EventArgs e)
        {
            var frm = _serviceProvider.GetRequiredService<FrmUserAccess>();
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
            var frm = _serviceProvider.GetRequiredService<FrmLogin>();
            frm.FromMain = true;
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

        private async void btnOfficeAccess_Click(object sender, System.EventArgs e)
        {
            var frm = _serviceProvider.GetRequiredService<FrmOfficeAccess>();
            frm.ShowDialog();

            await LoadData();
        }
    }
}
