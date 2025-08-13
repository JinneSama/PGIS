using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
    public class ISImage
    {
        public int Id { get; set; }
        [MaxLength(128)]
        public string FileName { get; set; }
        [MaxLength(128)]
        public string SecurityStamp { get; set; }
        public int FileOrder { get; set; }
        public int? InformationSystemId { get; set; }
        [ForeignKey("InformationSystemId")]
        public InformationSystem InformationSystem { get; set; }
    }
}
