using Microsoft.Extensions.DependencyInjection;
using PGISLauncher.API.Manager;
using PGISLauncher.Base;
using PGISLauncher.DataModels;
using PGISLauncher.Interfaces;
using System;
using System.Linq;

namespace PGISLauncher.ToolForms
{
    public partial class FrmUserAccess : BaseForm
    {
        private readonly IAccesService _accessService;
        private readonly IServiceProvider _serviceProvider;
        private readonly OFMISManager _ofmisManager;
        public FrmUserAccess(IAccesService accessService, OFMISManager ofmisManager,
            IServiceProvider serviceProvider)
        {
            _accessService = accessService;
            _ofmisManager = ofmisManager;
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void LoadData()
        {
            var data = _accessService.UserAccessService.GetAll().ToList().Select(x => new UserAccessViewModel
            {
                UserAccess = x,
                OFMISUser = _ofmisManager.GetUser(x.OFMISId)
            });
            gcUserAccess.DataSource = data;
        }

        private async void FrmUserAccess_Load(object sender, System.EventArgs e)
        {
            await _ofmisManager.InitData();
            LoadData();
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            var row = (UserAccessViewModel)gridUserAccess.GetFocusedRow();
            var frm = _serviceProvider.GetRequiredService<FrmAddEditUserAccess>();
            frm.InitForm(row.UserAccess);
            frm.ShowDialog();

            LoadData();
        }

        private void btnAddUser_Click(object sender, System.EventArgs e)
        {
            var frm = _serviceProvider.GetRequiredService<FrmAddEditUserAccess>();
            frm.ShowDialog();

            LoadData();
        }
    }
}