using Microsoft.Extensions.DependencyInjection;
using PGISLauncher.Interfaces;
using PGISLauncher.ToolForms;
using PGISLauncher.Utility;
using System;
using System.Windows.Forms;
using System.Deployment.Application;
using PGISLauncher.Utility.Update;
using PGISLauncher.API;
using PGISLauncher.Services;

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
            var services = new ServiceCollection();
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                UtilitiesDependencyRegistrar.RegisterServices(services);
                ServicesDependencyRegistrar.RegisterServices(services);
                APIDependencyRegistrar.RegisterServices(services);
                _instanceGuard = serviceProvider.GetRequiredService<ISingleInstance>();
                _instanceGuard.Init("PGIS", ShowExistingForm);

                _startup = serviceProvider.GetRequiredService<IStartup>();
                _startup.CheckAndSetStartup();
                if (!_instanceGuard.IsSingleInstance())
                {
                    _instanceGuard.ShowExistingInstance();
                    return;
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                ForceUserUpdate();
                _frmMain = serviceProvider.GetService<FrmMain>();

                Application.Run(_frmMain);
            }
        }

        public static void ShowExistingForm()
        {
            _frmMain.Invoke(new Action(() => {
                _frmMain.ShowForm();    
            }));
        }

        private static void ForceUserUpdate()
        {
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment cd = ApplicationDeployment.CurrentDeployment;
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
