using DevExpress.XtraEditors;
using Model.Entities;
using Model.Enum;
using Model.Interface;
using Model.Manager;
using Model.Repository;
using Model.Service;
using Model.Service.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGISLauncher.ToolForms
{
    public partial class FrmAddEditOfficeAccess : DevExpress.XtraEditors.XtraForm
    {
        private readonly OfficeAccess _officeAccess;
        private readonly OFMISService _service;

        public FrmAddEditOfficeAccess(OfficeAccess officeAccess)
        {
            InitializeComponent();
            _officeAccess = officeAccess;
            _service = new OFMISService();
            LoadDropdowns();
            LoadDetails();
        }

        public FrmAddEditOfficeAccess()
        {
            InitializeComponent();
            _service = new OFMISService();
            LoadDropdowns();
        }

        private void LoadDetails()
        {
            lueOffice.EditValue = _officeAccess.OfficeId;
            ccbApps.EditValue = string.Join(",", _officeAccess.InformationSystems?.Select(s => s.Id.ToString()) ?? new List<string>());
        }
        private async void LoadDropdowns()
        {
            IUnitOfWork unitOfWork = new UnitOfWork();
            var infoSystems = unitOfWork.InformationSystemRepo.GetAll();
            ccbApps.Properties.DataSource = infoSystems.ToList();

            var offices = await _service.GetOffices();
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
            IUnitOfWork unitOfWork = new UnitOfWork();
            var office = await unitOfWork.OfficeAccessRepo.FindAsync(x => x.Id == _officeAccess.Id);

            await AddApps(office, unitOfWork);
            await unitOfWork.SaveAsync();
        }

        private async Task SaveNewOffice()
        {
            IUnitOfWork unitOfWork = new UnitOfWork();
            var office = new OfficeAccess();

            await AddApps(office, unitOfWork);
            office.OfficeId = (int?)lueOffice.EditValue;
            unitOfWork.OfficeAccessRepo.Insert(office);
            await unitOfWork.SaveAsync();
        }

        private async Task AddApps(OfficeAccess office, IUnitOfWork unitOfWork)
        {
            var apps = ccbApps.EditValue.ToString().Split(',');
            foreach (var app in apps)
            {
                int convertedId = Convert.ToInt32(app);
                var selectedApp = await unitOfWork.InformationSystemRepo.FindAsync(x => x.Id == convertedId);
                office.InformationSystems.Add(selectedApp);
            }
        }
    }
}