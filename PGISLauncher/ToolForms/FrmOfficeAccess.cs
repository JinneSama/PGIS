using Microsoft.Extensions.DependencyInjection;
using PGISLauncher.API.Service;
using PGISLauncher.DataModels;
using PGISLauncher.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PGISLauncher.ToolForms
{
    public partial class FrmOfficeAccess : DevExpress.XtraEditors.XtraForm
    {
        private readonly IAccesService _accessService;
        private readonly IServiceProvider _serviceProvider;
        private readonly OFMISService _ofmisService;
        public FrmOfficeAccess(OFMISService ofmisService, IAccesService accesService,
            IServiceProvider serviceProvider)
        {
            _ofmisService = ofmisService;
            _accessService = accesService;
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private async Task LoadData()
        {
            var offices = await _ofmisService.GetOffices();
            var data = _accessService.OfficeAccessService.GetAll().ToList().Select(x => new OfficeAccessViewModel
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
            var res = await _accessService.OfficeAccessService.GetByIdAsync(row.Id);
            var frm = _serviceProvider.GetRequiredService<FrmAddEditOfficeAccess>();
            frm.InitForm(res);
            frm.ShowDialog();

            await LoadData();
        }

        private async void btnAddNewOffice_Click(object sender, System.EventArgs e)
        {
            var frm = _serviceProvider.GetRequiredService<FrmAddEditOfficeAccess>();
            frm.ShowDialog();

            await LoadData();
        }

        private async void FrmOfficeAccess_Load(object sender, System.EventArgs e)
        {
            await LoadData();
        }
    }
}