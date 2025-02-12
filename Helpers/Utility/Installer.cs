using System.IO;
using System.Net;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.ComponentModel;
using Helpers.Interface;

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
    }
}
