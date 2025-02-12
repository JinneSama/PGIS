using Model.Entities;
using Model.Interface;
using Model.Repository;
using PGISLauncher.Base;
using System.Linq;

namespace PGISLauncher.ToolForms
{
    public partial class FrmDefaultApps : BaseForm
    {
        public FrmDefaultApps()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            IUnitOfWork unitOfWork = new UnitOfWork();
            var data = unitOfWork.InformationSystemRepo.GetAll().ToList();
            gcDefaultApps.DataSource = data;
        }

        private async void gridDefaultApps_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            IUnitOfWork unitOfWork = new UnitOfWork();
            var row = (InformationSystem)gridDefaultApps.GetFocusedRow();
            var infoSystem = await unitOfWork.InformationSystemRepo.FindAsync(x => x.Id == row.Id);
            infoSystem.IsDefaultApp = row.IsDefaultApp;

            await unitOfWork.SaveAsync();
        }
    }
}