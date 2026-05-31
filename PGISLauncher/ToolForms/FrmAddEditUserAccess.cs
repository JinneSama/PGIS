using Microsoft.Extensions.DependencyInjection;
using PGISLauncher.API.Manager;
using PGISLauncher.Base;
using PGISLauncher.Core.Enums;
using PGISLauncher.DataModels.DTO;
using PGISLauncher.Domain.Entities;
using PGISLauncher.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGISLauncher.ToolForms
{
    public partial class FrmAddEditUserAccess : BaseForm
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IInfoSystemService _infoSystemService;
        private readonly IAccesService _accessService;
        private readonly IControlMapper<OFMISUsersDto> _ofmisUsersMapper;
        private UserAccess _userAccess;
        private OFMISUsersDto _usersDto;
        public FrmAddEditUserAccess(IServiceProvider serviceProvider, IInfoSystemService infoSystemService,
            IControlMapper<OFMISUsersDto> ofmisUsersMapper, IAccesService accessService)
        {
            _serviceProvider = serviceProvider;
            _infoSystemService = infoSystemService;
            _ofmisUsersMapper = ofmisUsersMapper;
            _accessService = accessService;
            InitializeComponent();
            LoadDropdowns();
        }

        public void InitForm(UserAccess userAccess = null)
        {
            if(userAccess != null)
                LoadDetails();
        }

        private void LoadDetails()
        {
            btnOFMIS.Enabled = false;
            var user = _serviceProvider.GetRequiredService<OFMISManager>().GetUser(_userAccess.OFMISId);
            SetOFMISUser(user);
            lueRole.EditValue = _userAccess.UserRole;
            ccbApps.EditValue = string.Join(",", _userAccess.InformationSystems?
                .Select(s => s.Id.ToString()) ?? new List<string>());
        }
        private void LoadDropdowns()
        {
            lueRole.Properties.DataSource = Enum.GetValues(typeof(UserRole)).Cast<UserRole>().ToList()
                .Select(x => new
                {
                    Value = x,
                });

            var infoSystems = _infoSystemService.GetAll();
            ccbApps.Properties.DataSource = infoSystems.ToList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOFMIS_Click(object sender, EventArgs e)
        {
            var frm = _serviceProvider.GetRequiredService<FrmOFMISUsers>();
            frm.ShowDialog();

            if (frm.OFMISUser == null) return;
            SetOFMISUser(frm.OFMISUser);
        }

        private void SetOFMISUser(OFMISUsersDto oFMISUser)
        {
            _usersDto = oFMISUser;
            _ofmisUsersMapper.MapToControls(_usersDto, this);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_userAccess == null) await SaveNewUser();
            else await UpdateUser();

            this.Close();
        }

        private async Task UpdateUser()
        {
            var user = await _accessService.UserAccessService.GetByFilterAsync(x => x.Id == _userAccess.Id);
            user.UserRole = (UserRole)lueRole.EditValue;

            await AddApps(user);
            await _accessService.UserAccessService.SaveChangesAsync();
        }

        private async Task AddApps(UserAccess user)
        {
            var apps = ccbApps.EditValue.ToString().Split(',');
            foreach (var app in apps)
            {
                int convertedId = Convert.ToInt32(app);
                var selectedApp = await _infoSystemService.GetByFilterAsync(x => x.Id == convertedId);
                user.InformationSystems.Add(selectedApp);
            }
        }

        private async Task SaveNewUser()
        {
            var user = new UserAccess();
            user.OFMISId = _usersDto.OFMISId;
            user.UserRole = (UserRole)lueRole.EditValue;

            await AddApps(user);
            await _accessService.UserAccessService.AddAsync(user);
            await _accessService.UserAccessService.SaveChangesAsync();
        }
    }
}