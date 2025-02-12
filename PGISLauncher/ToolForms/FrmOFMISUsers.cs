using Model.Manager;
using Model.Service.Dto;
using PGISLauncher.Base;
using System;
using System.Linq;

namespace PGISLauncher.ToolForms
{
    public partial class FrmOFMISUsers : BaseForm
    {
        public OFMISUsersDto OFMISUser { get; set; }
        public FrmOFMISUsers()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            gcOFMISUser.DataSource = OFMISManager.GetAllUsers().OrderBy(x => x.FullName).ToList();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var row = (OFMISUsersDto)gridOFMISUser.GetFocusedRow();
            OFMISUser = row;
            this.Close();
        }
    }
}