using PGISLauncher.API.Manager;
using PGISLauncher.Base;
using PGISLauncher.DataModels.DTO;
using System;
using System.Linq;

namespace PGISLauncher.ToolForms
{
    public partial class FrmOFMISUsers : BaseForm
    {
        public readonly OFMISManager _ofmisManager;
        public OFMISUsersDto OFMISUser { get; set; }
        public FrmOFMISUsers(OFMISManager ofmisManager)
        {
            _ofmisManager = ofmisManager;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            gcOFMISUser.DataSource = _ofmisManager.GetAllUsers().OrderBy(x => x.FullName).ToList();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var row = (OFMISUsersDto)gridOFMISUser.GetFocusedRow();
            OFMISUser = row;
            this.Close();
        }
    }
}