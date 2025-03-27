using Helpers.Interface;
using Helpers.Security;
using Helpers.Update;
using Helpers.Utility;
using PGISLauncher.ToolForms;
using System;
using System.IO;
using System.Windows.Forms;

namespace PGISLauncher
{
    internal static class Program
    {
        private static ISingleInstance _instanceGuard;
        private static IStartup _startup;
        private static FrmMain _frmMain;
        [STAThread]
        static void Main()
        {
            _instanceGuard = new SingleInstance("PGIS", ShowExistingForm);
            _startup = new Startup();

            _startup.CheckAndSetStartup();
            if (!_instanceGuard.IsSingleInstance())
            {
                _instanceGuard.ShowExistingInstance();
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ForceUserUpdate();
            _frmMain = new FrmMain();

            Application.Run(_frmMain);
        }

        public static void ShowExistingForm()
        {
            _frmMain.Invoke(new Action(() => {
                _frmMain.ShowForm();    
            }));
        }

        private static void ForceUserUpdate()
        {
            if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
            {
                System.Deployment.Application.ApplicationDeployment cd = System.Deployment.Application.ApplicationDeployment.CurrentDeployment;
                string version = cd.CurrentVersion.ToString();
                if (UpdateHelpers.InstallUpdateSyncWithInfo())
                {
                    MessageBox.Show($@"This Version of NVPGIS Launcher is Outdated, the Application will now Automatically Update", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Properties.Settings.Default.Save();

                    var frm = new FrmUpdater() { NewVersion = version };
                    frm.ShowDialog();
                }
            }
        }
    }
}
