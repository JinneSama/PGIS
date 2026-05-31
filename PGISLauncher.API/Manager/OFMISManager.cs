using PGISLauncher.API.Service;
using PGISLauncher.DataModels.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGISLauncher.API.Manager
{
    public class OFMISManager
    {
        private IEnumerable<OFMISUsersDto> Users { get; set; }
        private OFMISService _service;
        public OFMISManager(OFMISService ofmisService)
        {
            _service = ofmisService;
        }
        public async Task InitData()
        {
            if (Users == null)
                Users = await _service.GetAllUsers();
        }

        public OFMISUsersDto GetUser(string Id)
        {
            return Users.FirstOrDefault(x => x.OFMISId == Id);
        }
        public IEnumerable<OFMISUsersDto> GetAllUsers()
        {
            return Users;
        }
    }
}
