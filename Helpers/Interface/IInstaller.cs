using System.ComponentModel;
using System.Net;
using System.Threading.Tasks;

namespace Helpers.Interface
{
    public interface IInstaller
    {
        Task Install(string AppURL);
        void DownloadFileCompleted(object sender, AsyncCompletedEventArgs e);
        void DownloadProgressChanged(object s, DownloadProgressChangedEventArgs e);
    }
}
