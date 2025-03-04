using Helpers.Enum;
using Helpers.Utility.Model;
using System.Threading.Tasks;

namespace Helpers.Interface
{
    public interface ILauncher
    {
        DirectoryData IsShortcutPresentAsync(string publisherName, string productName);
        Task WaitForInstallAsync(string publisherName, string productName);
        Task WaitForUnInstallAsync(string publisherName, string productName);
        Task TrackStatus(string processName);
        void UpdateStatus(ProcessStatus status);
        void UpdateUninstallStatus(bool status);
    }
}
