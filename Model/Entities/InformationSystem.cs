using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [MaxLength(128)]
        public string AbbrevName { get; set; }
        [MaxLength(128)]
        public string AcrName { get; set; }
        public DateTime? DatePublished { get; set; }
        [MaxLength(128)]
        public string Description { get; set; }
        [MaxLength(128)]
        public string ProductName { get; set; }
        [MaxLength(128)]
        public string DownloadURL { get; set; }
        [MaxLength(128)]
        public string PublisherName { get; set; }
        [MaxLength(128)]
        public string SolutionName { get; set; }
        [MaxLength(128)]
        public string Creator { get; set; }
        [MaxLength(128)]
        public string Webpage { get; set; }
        [MaxLength(128)]
        public string IconPath { get; set; }
        [MaxLength(128)]
        public string IconPathSecurityStamp { get; set; }
        public bool? IsDefaultApp { get; set; }
        public virtual ICollection<ISImage> Images { get; set; }
        public virtual ICollection<UserAccess> UserAccesses { get; set; }
        public virtual ICollection<OfficeAccess> OfficeAccesses { get; set; }
        public virtual ICollection<AppUsage> AppUsage { get; set; }
    }
}
