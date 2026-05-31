using PGISLauncher.Base;
using PGISLauncher.Domain.Entities;
using PGISLauncher.Interfaces;
using System.Linq;

namespace PGISLauncher.ToolForms
{
    public partial class FrmDefaultApps : BaseForm
    {
        private readonly IInfoSystemService _infoSystemService;
        public FrmDefaultApps(IInfoSystemService infoSystemService)
        {
            _infoSystemService = infoSystemService;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var data = _infoSystemService.GetAll().ToList();
            gcDefaultApps.DataSource = data;
        }

        private async void gridDefaultApps_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            var row = (InformationSystem)gridDefaultApps.GetFocusedRow();
            var infoSystem = await _infoSystemService.GetByIdAsync(row.Id);
            infoSystem.IsDefaultApp = row.IsDefaultApp;

            await _infoSystemService.SaveChangesAsync();
        }
    }
}