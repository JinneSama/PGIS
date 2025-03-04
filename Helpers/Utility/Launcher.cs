using System.IO;
using System;
using Helpers.Utility.Model;
using System.Linq;
using Helpers.Interface;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using Helpers.Enum;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Helpers.Utility
{
    public class Launcher : ILauncher
    {
        private CancellationTokenSource cts; 
        private Action<ProcessStatus> _statusUpdateCallback;
        private Action<bool> _uninstallStatusCallBack;

        public Launcher(Action<ProcessStatus> statusUpdateCallback = null, Action<bool> uninstallStatusCallBack = null)
        {
            _statusUpdateCallback = statusUpdateCallback;
            _uninstallStatusCallBack = uninstallStatusCallBack;
        }

        public void UpdateUninstallStatus(bool status)
        {
            _uninstallStatusCallBack.Invoke(status);
        }
        public void UpdateStatus(ProcessStatus status)
        {
            _statusUpdateCallback?.Invoke(status);
        }

        public DirectoryData IsShortcutPresentAsync(string publisherName, string productName)
        {
            string startMenuPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu), "Programs", publisherName, productName);

            if (Directory.Exists(startMenuPath))
            {
                var directory = Directory.GetFiles(startMenuPath, "*.appref-ms", SearchOption.TopDirectoryOnly);
                var directoryData = new DirectoryData
                {
                    AppPath = directory.FirstOrDefault(),
                    Exists = directory.Any(file => file.Contains(productName))
                };
                return directoryData;
            }
            return null;
        }

        public async Task TrackStatus(string processName)
        {
            UpdateStatus(ProcessStatus.Launching);
            await Task.Delay(3000);
            cts?.Cancel();
            cts = new CancellationTokenSource();

            try
            {
                await Task.Run(async () =>
                {
                    while (!cts.Token.IsCancellationRequested)
                    {
                        Process trackedProcess = Process.GetProcessesByName(processName).FirstOrDefault();
                        if (trackedProcess != null && !trackedProcess.HasExited)
                            UpdateStatus(ProcessStatus.Running);
                        else
                        {
                            UpdateStatus(ProcessStatus.Closed);
                        }

                        await Task.Delay(1000, cts.Token);
                    }
                }, cts.Token);
            }
            catch (TaskCanceledException)   
            {
                UpdateStatus(ProcessStatus.Cancelled);
            }
        }

        public async Task WaitForInstallAsync(string publisherName, string productName)
        {
            bool isInstalled = false;
            var installCompletion = new TaskCompletionSource<bool>();
            await Task.Run(async () =>
            {
                while (!isInstalled)
                {
                    if (IsShortcutPresentAsync(publisherName, productName) != null)
                    {
                        UpdateUninstallStatus(true);
                        isInstalled = true;
                        installCompletion.SetResult(true);
                    }
                    await Task.Delay(1000);
                }
            });
            await installCompletion.Task;
        }

        public async Task WaitForUnInstallAsync(string publisherName, string productName)
        {
            bool isUnInstalled = false;
            var uninstallCompletion = new TaskCompletionSource<bool>();
            await Task.Run(async () =>
            {
                while (!isUnInstalled)
                {
                    if (IsShortcutPresentAsync(publisherName, productName) == null)
                    {
                        UpdateUninstallStatus(false);
                        isUnInstalled = true;
                        uninstallCompletion.SetResult(true);
                    }
                    await Task.Delay(1000);
                }
            });
            await uninstallCompletion.Task;
        }
    }
}
