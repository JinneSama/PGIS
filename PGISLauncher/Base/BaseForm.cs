using DevExpress.XtraEditors;

namespace PGISLauncher.Base
{
    public class BaseForm : XtraForm
    {
        public BaseForm()
        {
            SetFormIcon();
        }

        private void SetFormIcon()
        {
            this.IconOptions.Icon = Properties.Resources.PGNV_ico;
        }
    }
}
