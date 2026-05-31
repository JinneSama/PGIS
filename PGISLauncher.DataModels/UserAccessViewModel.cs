using PGISLauncher.DataModels.DTO;
using PGISLauncher.Domain.Entities;

namespace PGISLauncher.DataModels
{
    public class UserAccessViewModel
    {
        public UserAccess UserAccess { get; set; }
        public OFMISUsersDto OFMISUser { get; set; }
    }
}
