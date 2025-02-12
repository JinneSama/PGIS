using Model.Entities;
using Model.Interface;
using Model.Repository;
using Model.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Model.Manager
{
    public class UserAppManager
    {
        private static OFMISService _service;
        public static void InitManager()
        {
            _service = new OFMISService();
        }
        public static async Task<IEnumerable<InformationSystem>> GetUserApps(string ofmisId)
        {
            IUnitOfWork unitOfWork = new UnitOfWork();
            var user = await unitOfWork.UserAccessRepo.FindAsync(x => x.OFMISId ==  ofmisId);
            if (user == null) return unitOfWork.InformationSystemRepo.FindAll(x => x.IsDefaultApp == true);
            else return user.InformationSystems;
        }
    }
}
