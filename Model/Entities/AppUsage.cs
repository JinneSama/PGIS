using Model.Enum;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
    public class AppUsage
    {
        public int Id { get; set; }
        public DateTime? AccessedDate { get; set; }
        public AppAccessType AccessType { get; set; }
        [MaxLength(128)] 
        public string SecurityStamp { get; set; }
        [MaxLength(128)]
        public string OFMISId { get; set; }
        public int? InfoSystemId { get; set; }
        [ForeignKey("InfoSystemId")]
        public InformationSystem InformationSystem { get; set; }
        public int? UserAccessId { get; set; }
        [ForeignKey("UserAccessId")]
        public UserAccess UserAccess { get; set; }
    }
}
