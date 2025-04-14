using Model.Entities;
using Model.Interface;
using Model.Repository;
using Model.Service;
using Model.Service.Dto;
using System;
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
        public static async Task<IEnumerable<InformationSystem>> GetUserApps(OFMISUsersDto ofmisUser)
        {
            IUnitOfWork unitOfWork = new UnitOfWork();
            var user = await unitOfWork.UserAccessRepo.FindAsync(x => x.OFMISId ==  ofmisUser.OFMISId);
            if (user == null)
            {
                var res = await GetOfficeApps(ofmisUser);
                return res;
            }

            return user.InformationSystems;
        }

        private static async Task<IEnumerable<InformationSystem>> GetOfficeApps(OFMISUsersDto ofmisUser)
        {
            IUnitOfWork unitOfWork = new UnitOfWork();
            var office = await unitOfWork.OfficeAccessRepo.FindAsync(x => x.OfficeId == ofmisUser.OfficeId);

            if (office == null) return unitOfWork.InformationSystemRepo.FindAll(x => x.IsDefaultApp == true);
            else return office.InformationSystems;
        }
    }
}
