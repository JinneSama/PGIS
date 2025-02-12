using Helpers.Update;
using PGISLauncher.ToolForms;
using System;
using System.IO;
using System.Windows.Forms;

namespace PGISLauncher
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ForceUserUpdate();
            Application.Run(new FrmMain());
        }

        private static void ForceUserUpdate()
        {
            if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
            {
                System.Deployment.Application.ApplicationDeployment cd = System.Deployment.Application.ApplicationDeployment.CurrentDeployment;
                string version = cd.CurrentVersion.ToString();
                if (UpdateHelpers.InstallUpdateSyncWithInfo())
                {
                    MessageBox.Show($@"This Version of PGIS Launcher is Outdated, the Application will now Automatically Update", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Properties.Settings.Default.Save();

                    var frm = new FrmUpdater() { NewVersion = version };
                    frm.ShowDialog();
                }
            }
        }
    }
}
