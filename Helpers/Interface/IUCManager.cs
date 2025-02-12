using System.Windows.Forms;

namespace Helpers.Interface
{
    public interface IUCManager<TControl> where TControl : Control
    {
        void ShowUCSystemDetails(string key, object rowData);
        void RemoveUCSystemDetails(string key);
        void ClearCache();
        void NavigateForward();
        void NavigateBack();
    }
}
