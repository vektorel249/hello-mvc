using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vektorel.GameCenter.Entities
{
    public class LookUp : BaseEntity
    {
        [Required]
        [MaxLength(16)]
        public string Name { get; set; }
        public Guid? ParentId { get; set; }

        [ForeignKey(nameof(ParentId))]
        public LookUp Parent { get; set; }
    }
}
