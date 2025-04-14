using Model.Interface;
using Model.Repository;
using Model.Service;
using Model.Service.Dto;
using Model.ViewModel;
using System.Linq;
using System.Threading.Tasks;

namespace PGISLauncher.ToolForms
{
    public partial class FrmOfficeAccess : DevExpress.XtraEditors.XtraForm
    {
        private readonly OFMISService _service;
        public FrmOfficeAccess()
        {
            InitializeComponent();
            _service = new OFMISService();
        }

        private async Task LoadData()
        {
            IUnitOfWork unitOfWork = new UnitOfWork();
            var offices = await _service.GetOffices();
            var data = unitOfWork.OfficeAccessRepo.GetAll().ToList().Select(x => new OfficeAccessViewModel
            {
                Id = x.Id,
                OfficeId = x.OfficeId,
                OfficeName = offices.FirstOrDefault(w => w.OfficeId == x.OfficeId).OfficeName
            });

            gcOfficeAccess.DataSource = data.ToList();
        }

        private async void btnEdit_Click(object sender, System.EventArgs e)
        {
            var row = (OfficeAccessViewModel)gridUserAccess.GetFocusedRow();
            IUnitOfWork unitOfWork = new UnitOfWork();
            var res = await unitOfWork.OfficeAccessRepo.FindAsync(x => x.Id == row.Id);
            var frm = new FrmAddEditOfficeAccess(res);
            frm.ShowDialog();

            await LoadData();
        }

        private async void btnAddNewOffice_Click(object sender, System.EventArgs e)
        {
            var frm = new FrmAddEditOfficeAccess();
            frm.ShowDialog();

            await LoadData();
        }

        private async void FrmOfficeAccess_Load(object sender, System.EventArgs e)
        {
            await LoadData();
        }
    }
}