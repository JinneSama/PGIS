namespace Model.Service.Dto
{
    public class OFMISUsersDto
    {
        public string OFMISId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public int? OfficeId { get; set; }
    }
}
