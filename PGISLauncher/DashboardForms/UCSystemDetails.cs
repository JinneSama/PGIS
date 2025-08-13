using Helpers.Interface;
using Helpers.Utility;
using Helpers.Utility.Model;
using System.Net;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using Model.ViewModel;
using System;
using System.Diagnostics;
using Model.Entities;
using Helpers.Service;
using System.Drawing;
using Helpers.Enum;
using Model.Enum;
using Model.Interface;
using Model.Repository;
using Model.UserManager;
using System.Windows.Forms;

namespace PGISLauncher.DashboardForms
{
    public partial class UCSystemDetails : XtraUserControl, ILauncher
    {
        private readonly IInstaller _installerHandler;
        private readonly ILauncher _launcherHandler;
        private readonly SystemInfoViewModel _systemInformation;
        private FileService _fileService;
        private DirectoryData _directoryData;
        private readonly Control _frmMain;

        public UCSystemDetails(SystemInfoViewModel systemInformation, Control frmMain)
        {
            InitializeComponent();
            _installerHandler = new Installer(DownloadFileCompleted, DownloadProgressChanged);
            _launcherHandler = new Launcher(UpdateStatus, UpdateUninstallStatus);
            _systemInformation = systemInformation;
            _fileService = new FileService(); 
            _frmMain = frmMain;
        }

        private async Task LoadData()
        {
            _directoryData = IsShortcutPresentAsync(_systemInformation.SystemInformation.PublisherName, _systemInformation.SystemInformation.ProductName);
            if (_directoryData != null) SetDownLoadInstall(false);
            else SetDownLoadInstall(true);

            IControlMapper<InformationSystem> mapper = new ControlMapper<InformationSystem>();
            mapper.MapToControls(_systemInformation.SystemInformation, this, panelTitle);
            //picImage.Image = await _fileService.DownloadFile(_systemInformation.SystemInformation.IconPath);
            await TrackStatus(_systemInformation.SystemInformation.SolutionName);
        }

        private void SetDownLoadInstall(bool condition)
        {
            btnInstall.Visible = condition;
            btnOpen.Visible = !condition;

            if (condition)
            {
                lblAppStatus.Text = "NOT INSTALLED";
                lblAppStatus.BackColor = Color.Red;
                lblAppStatus.ForeColor = Color.White;
                btnUninstall.Enabled = !condition;
            }
            else
            {
                lblAppStatus.BackColor = Color.Transparent;
                lblAppStatus.ForeColor = Color.Black;
                lblAppStatus.Text = "Installed";
                btnUninstall.Enabled = !condition;
            }
        }
        public async Task Install(string AppURL)
        {
            await _installerHandler.Install(AppURL);
            progressPanel.Visible = true;
        }

        public void DownloadFileCompleted()
        {
            progressPanel.BeginInvoke(new Action(() =>
            {
                progressPanel.Visible = false;
            }));
        }

        public void DownloadProgressChanged(object s, DownloadProgressChangedEventArgs e)
        {
            progressBarControl.BeginInvoke(new Action(() =>
            {
                progressBarControl.Position = e.ProgressPercentage;
            }));
        }

        public DirectoryData IsShortcutPresentAsync(string publisherName, string productName)
        {
            return _launcherHandler.IsShortcutPresentAsync(publisherName, productName);
        }

        private async void btnInstall_Click(object sender, EventArgs e)
        {
            await Install(_systemInformation.SystemInformation.DownloadURL);
            await WaitForInstallAsync(_systemInformation.SystemInformation.PublisherName, _systemInformation.SystemInformation.ProductName);
            RefreshMainFormData();
        }

        private async void btnOpen_Click(object sender, EventArgs e)
        {
            await RecordAppUsage(AppAccessType.Opened);
            Process.Start(_directoryData.AppPath);
            await TrackStatus(_systemInformation.SystemInformation.SolutionName);
        }

        public async Task WaitForInstallAsync(string publisherName, string productName)
        {
            await _launcherHandler.WaitForInstallAsync(publisherName, productName);
            await LoadData();
        }

        private async void UCSystemDetails_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        public void UpdateStatus(ProcessStatus status)
        {
            if (btnOpen.InvokeRequired)
                btnOpen.BeginInvoke(new Action(() =>
                {
                    btnOpen.Text = EnumHelper.GetEnumDescription(status);
                    btnOpen.Appearance.BackColor = Color.Gray;
                    if (status == ProcessStatus.Open || status == ProcessStatus.Closed)
                        btnOpen.Appearance.BackColor = Color.Lime;
                }));
        }

        private async Task RecordAppUsage(AppAccessType status)
        {
            IUnitOfWork unitOfWork = new UnitOfWork();
            var user = await unitOfWork.UserAccessRepo.FindAsync(x => x.OFMISId == UserStore.OFMISUserDto.OFMISId);
            var usage = new AppUsage
            {
                AccessedDate = DateTime.Now,
                AccessType = status,
                SecurityStamp = Guid.NewGuid().ToString(),
                InfoSystemId = _systemInformation.SystemInformation.Id,
                OFMISId = UserStore.OFMISUserDto.OFMISId,
                UserAccessId = user?.Id
            };

            unitOfWork.AppUsageRepo.Insert(usage);
            await unitOfWork.SaveAsync();
        }

        public async Task TrackStatus(string processName)
        {
            await _launcherHandler.TrackStatus(processName);
        }

        private async void btnUninstall_Click(object sender, EventArgs e)
        {
            var msgRes = MessageBox.Show("Proceed to Uninstall?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (msgRes == DialogResult.OK)
            {
                _installerHandler.UnInstall(_systemInformation.SystemInformation.AcrName);
                await WaitForUnInstallAsync(_systemInformation.SystemInformation.PublisherName, _systemInformation.SystemInformation.ProductName);
            }
            await LoadData();
        }

        public async Task WaitForUnInstallAsync(string publisherName, string productName)
        {
            await _launcherHandler.WaitForUnInstallAsync(publisherName, productName);
        }

        public void UpdateUninstallStatus(bool status)
        {
            if (this.InvokeRequired)
                this.BeginInvoke(new Action(() =>
                {
                    RefreshMainFormData();
                    SetDownLoadInstall(status);
                }));
        }

        private async void RefreshMainFormData()
        {
            await ((FrmMain)_frmMain).LoadData();
        }

        private void txtWebpage_Click(object sender, EventArgs e)
        {
            Process.Start(txtWebpage.Text);
        }
    }
}
