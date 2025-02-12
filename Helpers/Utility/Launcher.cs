using System.IO;
using System;
using Helpers.Utility.Model;
using System.Linq;
using Helpers.Interface;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using Helpers.Enum;

namespace Helpers.Utility
{
    public class Launcher : ILauncher
    {
        private CancellationTokenSource cts; 
        private Action<ProcessStatus> _statusUpdateCallback;

        public Launcher(Action<ProcessStatus> statusUpdateCallback = null)
        {
            _statusUpdateCallback = statusUpdateCallback;
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
                        isInstalled = true;
                        installCompletion.SetResult(true);
                    }
                    await Task.Delay(1000);
                }
            });
            await installCompletion.Task;
        }
    }
}
