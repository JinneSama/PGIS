using System;
using System.ComponentModel;
using System.Net;
using System.Threading.Tasks;

namespace PGISLauncher.Interfaces
{
    public interface IInstaller
    {
        Task Install(string AppURL);
        void UnInstall(string appName);
        void DownloadFileCompleted(object sender, AsyncCompletedEventArgs e);
        void DownloadProgressChanged(object s, DownloadProgressChangedEventArgs e);
        void InitInstaller(Action downloadCompletedCallback = null, Action<object, DownloadProgressChangedEventArgs> downloadProgressChangedCallBack = null);
    }
}
