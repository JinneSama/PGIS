using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public class InformationSystem
    {
        public InformationSystem()
        {
            Images = new HashSet<ISImage>();
            UserAccesses = new HashSet<UserAccess>();
            AppUsage = new HashSet<AppUsage>();
            OfficeAccesses = new HashSet<OfficeAccess>();
        }
        public int Id { get; set; }
        public string AbbrevName { get; set; }
        public string AcrName { get; set; }
        public DateTime? DatePublished { get; set; }
        public string Description { get; set; }
        public string ProductName { get; set; }
        public string DownloadURL { get; set; }
        public string PublisherName { get; set; }
        public string SolutionName { get; set; }
        public string Creator { get; set; }
        public string IconPath { get; set; }
        public string IconPathSecurityStamp { get; set; }
        public bool? IsDefaultApp { get; set; }
        public virtual ICollection<ISImage> Images { get; set; }
        public virtual ICollection<UserAccess> UserAccesses { get; set; }
        public virtual ICollection<OfficeAccess> OfficeAccesses { get; set; }
        public virtual ICollection<AppUsage> AppUsage { get; set; }
    }
}
