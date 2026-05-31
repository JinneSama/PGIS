using PGISLauncher.API.Service;
using PGISLauncher.DataModels.DTO;
using PGISLauncher.Domain.Entities;
using PGISLauncher.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGISLauncher.API.Manager
{
    public class UserAppManager
    {
        private static OFMISService _service;
        private IRepository<int, UserAccess> _userAccessRepo;
        private IRepository<int, OfficeAccess> _officeAccessRepo;
        private IRepository<int, InformationSystem> _informationSystemRepo;
        public UserAppManager(OFMISService ofmisService, IRepository<int, OfficeAccess> officeAccessRepo,
            IRepository<int, UserAccess> userAccessRepo, IRepository<int, InformationSystem> informationSystemRepo)
        {
            _service = ofmisService;
            _officeAccessRepo = officeAccessRepo;
            _userAccessRepo = userAccessRepo;
            _informationSystemRepo = informationSystemRepo;
        }
        public async Task<IEnumerable<InformationSystem>> GetUserApps(OFMISUsersDto ofmisUser)
        {
            var user = await _userAccessRepo.GetByFilterAsync(x => x.OFMISId ==  ofmisUser.OFMISId);
            if (user == null)
            {
                var res = await GetOfficeApps(ofmisUser);
                return res;
            }

            return user.InformationSystems;
        }

        private async Task<IEnumerable<InformationSystem>> GetOfficeApps(OFMISUsersDto ofmisUser)
        {
            var office = await _officeAccessRepo.GetByFilterAsync(x => x.OfficeId == ofmisUser.OfficeId);

            if (office == null) return _informationSystemRepo.GetAll().Where(x => x.IsDefaultApp == true);
            else return office.InformationSystems;
        }
    }
}
