using Helpers.Update;
using System;
using System.Threading;
using System.Windows.Forms;

namespace PGISLauncher.ToolForms
{
    public partial class FrmUpdater : DevExpress.XtraEditors.XtraForm
    {
        public string NewVersion { get; set; }

        public FrmUpdater()
        {
            InitializeComponent();

            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var updateNow = true;
            while (updateNow)
            {
                Thread.Sleep(1000);
                if (UpdateHelpers.InstallUpdateSyncWithInfo())
                {
                    Invoke(new Action(() =>
                    {
                        updateNow = false;
                        UpdateHelpers.applicationDeployment.UpdateCompleted += (se, ev) =>
                        {
                            MessageBox.Show($@"Application Updated, the Application will now Restart, Press OK", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Application.Restart();
                        };
                        UpdateHelpers.applicationDeployment.UpdateProgressChanged += (se, ev) =>
                        {
                            lblByteSize.Text = $@"{ev.BytesCompleted / 1024}Mb / {ev.BytesTotal / 1024}Mb";
                            progressUpdate.Position = ev.ProgressPercentage;
                        };
                        UpdateHelpers.applicationDeployment.UpdateAsync();
                    }));
                }
                else
                {
                    updateNow = false;
                }
            }
        }
    }
}