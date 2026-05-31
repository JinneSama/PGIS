using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace PGISLauncher.Interfaces
{
    public interface IUCManager<TControl> where TControl : Control
    {
        void SetControls(PanelControl panelDetails);
        void ShowUCSystemDetails(string key, object rowData);
        void RemoveUCSystemDetails(string key);
        void ClearCache();
        void NavigateForward();
        void NavigateBack();
    }
}
