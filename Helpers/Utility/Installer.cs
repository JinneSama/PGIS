using System.IO;
using System.Net;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.ComponentModel;
using Helpers.Interface;
using Microsoft.Win32;
using System.Windows.Forms;

namespace Helpers.Utility
{
    public class Installer : IInstaller
    {
        private Action _downloadCompletedCallback;
        private Action<object, DownloadProgressChangedEventArgs> _downloadProgressChangedCallBack;
        public Installer(Action downloadCompletedCallback = null, Action<object, DownloadProgressChangedEventArgs> downloadProgressChangedCallBack = null)
        {
            _downloadCompletedCallback = downloadCompletedCallback;
            _downloadProgressChangedCallBack = downloadProgressChangedCallBack;
        }
        public async Task Install(string AppURL)
        {
            using (WebClient webClient = new WebClient())
            {
                string downloadPath = Path.Combine(Path.GetTempPath(), "setup.exe");
                File.Delete(downloadPath);
                webClient.DownloadProgressChanged += DownloadProgressChanged;
                webClient.DownloadFileCompleted += DownloadFileCompleted;
                await webClient.DownloadFileTaskAsync(new Uri(AppURL), downloadPath);
            }
        }

        public void DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            string installerPath = Path.Combine(Path.GetTempPath(), "setup.exe");
            Process.Start(installerPath);
            _downloadCompletedCallback?.Invoke();
        }

        public void DownloadProgressChanged(object s, DownloadProgressChangedEventArgs e)
        {
            _downloadProgressChangedCallBack?.Invoke(s, e);
        }

        public void UnInstall(string appName)
        {
            string registryRoot = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(registryRoot))
            {
                if (key == null) return;
                foreach (string subKeyName in key.GetSubKeyNames())
                {
                    using (RegistryKey subKey = key.OpenSubKey(subKeyName))
                    {
                        if (subKey == null) continue;

                        object displayName = subKey.GetValue("DisplayName");
                        object uninstallString = subKey.GetValue("UninstallString");

                        if (displayName != null && uninstallString != null && displayName.ToString().Contains(appName))
                        {
                            string uninstallCmd = uninstallString.ToString();

                            Process.Start(new ProcessStartInfo
                            {
                                FileName = "cmd.exe",
                                Arguments = $"/c {uninstallCmd}",
                                UseShellExecute = false,
                                CreateNoWindow = true
                            });
                            return;
                        }
                    }
                }
            }
        }
    }
}
