using Model.Enum;
using System.Collections.Generic;

namespace Model.Entities
{
    public class UserAccess
    {
        public UserAccess()
        {
            InformationSystems = new HashSet<InformationSystem>();
            AppUsage = new HashSet<AppUsage>();
        }
        public int Id { get; set; }
        public string OFMISId { get; set; }
        public UserRole UserRole { get; set; }
        public virtual ICollection<InformationSystem> InformationSystems { get; set; }
        public virtual ICollection<AppUsage> AppUsage { get; set; }
    }
}
