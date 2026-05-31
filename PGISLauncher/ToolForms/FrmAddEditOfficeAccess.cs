using PGISLauncher.API.Service;
using PGISLauncher.Domain.Entities;
using PGISLauncher.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PGISLauncher.ToolForms
{
    public partial class FrmAddEditOfficeAccess : DevExpress.XtraEditors.XtraForm
    {
        private readonly IInfoSystemService _infoSystemService;
        private readonly IAccesService _accesService;
        private OfficeAccess _officeAccess;
        private readonly OFMISService _ofmisService;

        public FrmAddEditOfficeAccess(OFMISService ofmisService, IAccesService accesService)
        {
            _ofmisService = ofmisService;
            _accesService = accesService;
            InitializeComponent();
            LoadDropdowns();
        }

        public void InitForm(OfficeAccess officeAccess = null)
        {
            _officeAccess = officeAccess;
            if(officeAccess != null)
                LoadDetails();
        }

        private void LoadDetails()
        {
            lueOffice.EditValue = _officeAccess.OfficeId;
            ccbApps.EditValue = string.Join(",", _officeAccess.InformationSystems?.Select(s => s.Id.ToString()) ?? new List<string>());
        }
        private async void LoadDropdowns()
        {
            var infoSystems = _infoSystemService.GetAll();
            ccbApps.Properties.DataSource = infoSystems.ToList();

            var offices = await _ofmisService.GetOffices();
            lueOffice.Properties.DataSource = offices.ToList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_officeAccess == null) await SaveNewOffice();
            else await UpdateOffice();

            this.Close();
        }

        private async Task UpdateOffice()
        {
            var office = await _accesService.OfficeAccessService.GetByIdAsync(_officeAccess.Id);

            await AddApps(office);
            await _accesService.OfficeAccessService.SaveChangesAsync();
        }

        private async Task SaveNewOffice()
        {
            var office = new OfficeAccess();

            await AddApps(office);
            office.OfficeId = (int?)lueOffice.EditValue;
            await _accesService.OfficeAccessService.AddAsync(office);
            await _accesService.OfficeAccessService.SaveChangesAsync();
        }

        private async Task AddApps(OfficeAccess office)
        {
            var apps = ccbApps.EditValue.ToString().Split(',');
            foreach (var app in apps)
            {
                int convertedId = Convert.ToInt32(app);
                var selectedApp = await _infoSystemService.GetByIdAsync(convertedId);
                office.InformationSystems.Add(selectedApp);
            }
        }
    }
}