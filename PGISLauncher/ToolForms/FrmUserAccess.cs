using Model.Interface;
using Model.Manager;
using Model.Repository;
using Model.ViewModel;
using PGISLauncher.Base;
using System.Linq;

namespace PGISLauncher.ToolForms
{
    public partial class FrmUserAccess : BaseForm
    {
        public FrmUserAccess()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            IUnitOfWork unitOfWork = new UnitOfWork();
            var data = unitOfWork.UserAccessRepo.GetAll().ToList().Select(x => new UserAccessViewModel
            {
                UserAccess = x,
                OFMISUser = OFMISManager.GetUser(x.OFMISId)
            });
            gcUserAccess.DataSource = data;
        }

        private async void FrmUserAccess_Load(object sender, System.EventArgs e)
        {
            await OFMISManager.InitData();
            LoadData();
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            var row = (UserAccessViewModel)gridUserAccess.GetFocusedRow();
            var frm = new FrmAddEditUserAccess(row.UserAccess);
            frm.ShowDialog();

            LoadData();
        }

        private void btnAddUser_Click(object sender, System.EventArgs e)
        {
            var frm = new FrmAddEditUserAccess();
            frm.ShowDialog();

            LoadData();
        }
    }
}