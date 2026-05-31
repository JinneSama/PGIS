using PGISLauncher.Core.Enums;
using PGISLauncher.DataModels;
using System;
using System.Threading.Tasks;

namespace PGISLauncher.Interfaces
{
    public interface ILauncher
    {
        DirectoryData IsShortcutPresentAsync(string publisherName, string productName);
        Task WaitForInstallAsync(string publisherName, string productName);
        Task WaitForUnInstallAsync(string publisherName, string productName);
        Task TrackStatus(string processName);
        void UpdateStatus(ProcessStatus status);
        void UpdateUninstallStatus(bool status);
        void InitLauncher(Action<ProcessStatus> statusUpdateCallback = null, Action<bool> uninstallStatusCallBack = null);
    }
}
