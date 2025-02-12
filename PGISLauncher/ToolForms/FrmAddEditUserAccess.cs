using Helpers.Interface;
using Helpers.Utility;
using Model.Entities;
using Model.Enum;
using Model.Interface;
using Model.Manager;
using Model.Repository;
using Model.Service.Dto;
using PGISLauncher.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace PGISLauncher.ToolForms
{
    public partial class FrmAddEditUserAccess : BaseForm
    {
        private readonly UserAccess _userAccess;
        private OFMISUsersDto _usersDto;
        public FrmAddEditUserAccess(UserAccess userAccess)
        {
            InitializeComponent();
            _userAccess = userAccess;
            LoadDropdowns();
            LoadDetails();
        }
        public FrmAddEditUserAccess()
        {
            InitializeComponent();
            LoadDropdowns();
        }

        private void LoadDetails()
        {
            btnOFMIS.Enabled = false;
            var user = OFMISManager.GetUser(_userAccess.OFMISId);
            SetOFMISUser(user);
            lueRole.EditValue = _userAccess.UserRole;
            ccbApps.EditValue = string.Join(",", _userAccess.InformationSystems?.Select(s => s.Id.ToString()) ?? new List<string>());
        }
        private void LoadDropdowns()
        {
            IUnitOfWork unitOfWork = new UnitOfWork();
            lueRole.Properties.DataSource = Enum.GetValues(typeof(UserRole)).Cast<UserRole>().ToList()
                .Select(x => new
                {
                    Value = x,
                });

            var infoSystems = unitOfWork.InformationSystemRepo.GetAll();
            ccbApps.Properties.DataSource = infoSystems.ToList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOFMIS_Click(object sender, EventArgs e)
        {
            var frm = new FrmOFMISUsers();
            frm.ShowDialog();

            if (frm.OFMISUser == null) return;
            SetOFMISUser(frm.OFMISUser);
        }

        private void SetOFMISUser(OFMISUsersDto oFMISUser)
        {
            _usersDto = oFMISUser;
            IControlMapper<OFMISUsersDto> controlMapper = new ControlMapper<OFMISUsersDto>();
            controlMapper.MapToControls(_usersDto, this);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_userAccess == null) await SaveNewUser();
            else await UpdateUser();

            this.Close();
        }

        private async Task UpdateUser()
        {
            IUnitOfWork unitOfWork = new UnitOfWork();
            var user = await unitOfWork.UserAccessRepo.FindAsync(x => x.Id == _userAccess.Id);
            user.UserRole = (UserRole)lueRole.EditValue;

            await AddApps(user, unitOfWork);
            await unitOfWork.SaveAsync();
        }

        private async Task AddApps(UserAccess user, IUnitOfWork unitOfWork)
        {
            var apps = ccbApps.EditValue.ToString().Split(',');
            foreach (var app in apps)
            {
                int convertedId = Convert.ToInt32(app);
                var selectedApp = await unitOfWork.InformationSystemRepo.FindAsync(x => x.Id == convertedId);
                user.InformationSystems.Add(selectedApp);
            }
        }

        private async Task SaveNewUser()
        {
            IUnitOfWork unitOfWork = new UnitOfWork();
            var user = new UserAccess();
            user.OFMISId = _usersDto.OFMISId;
            user.UserRole = (UserRole)lueRole.EditValue;

            await AddApps(user, unitOfWork);
            unitOfWork.UserAccessRepo.Insert(user);
            await unitOfWork.SaveAsync();
        }
    }
}