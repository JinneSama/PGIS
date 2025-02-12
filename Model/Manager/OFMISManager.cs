using Model.Service;
using Model.Service.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model.Manager
{
    public class OFMISManager
    {
        private static IEnumerable<OFMISUsersDto> Users { get; set; }
        private static OFMISService _service;
        public static async Task InitData()
        {
            _service = new OFMISService();
            if (Users == null)
                Users = await _service.GetAllUsers();
        }

        public static OFMISUsersDto GetUser(string Id)
        {
            return Users.FirstOrDefault(x => x.OFMISId == Id);
        }
        public static IEnumerable<OFMISUsersDto> GetAllUsers()
        {
            return Users;
        }
    }
}
