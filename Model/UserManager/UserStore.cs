using Model.Enum;
using Model.Service.Dto;

namespace Model.UserManager
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
        public static string Username;
        public static string Password;
        public static UserRole UserRole;
        public static OFMISUsersDto OFMISUserDto { get; set; }  
        public static ArgumentCredentialsDto Credentials { get; set; }
    }
}
