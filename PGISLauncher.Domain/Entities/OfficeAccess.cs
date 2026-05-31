using System.Collections.Generic;

namespace PGISLauncher.Domain.Entities
{
    public class OfficeAccess
    {
        public OfficeAccess()
        {
            InformationSystems = new HashSet<InformationSystem>();  
        }
        public int Id { get; set; }
        public int? OfficeId { get; set; }
        public virtual ICollection<InformationSystem> InformationSystems { get; set; }
    }
}
