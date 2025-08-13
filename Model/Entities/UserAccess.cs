using Model.Enum;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [MaxLength(128)]
        public string OFMISId { get; set; }
        public UserRole UserRole { get; set; }
        public virtual ICollection<InformationSystem> InformationSystems { get; set; }
        public virtual ICollection<AppUsage> AppUsage { get; set; }
    }
}
