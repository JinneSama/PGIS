using PGISLauncher.Core.Enums;
using PGISLauncher.DataModels.DTO;

namespace PGISLauncher.API.Common
{
    public class UserStore
    {
        public UserStore(string username, string password, OFMISUsersDto authUser, UserRole userRole)
        {
            Username = username;
            Password = password;
            OFMISUserDto = authUser;
            UserRole = userRole;

            Credentials = new ArgumentCredentialsDto
            {
                Username = username,
                Password = password
            };
        }
        public string Username;
        public string Password;
        public UserRole UserRole;
        public OFMISUsersDto OFMISUserDto { get; set; }  
        public ArgumentCredentialsDto Credentials { get; set; }
    }
}
