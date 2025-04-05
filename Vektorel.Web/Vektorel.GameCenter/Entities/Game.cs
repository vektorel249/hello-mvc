using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vektorel.GameCenter.Enums;

namespace Vektorel.GameCenter.Entities
{
    public class Game : BaseEntity
    {
        [Required]
        [MaxLength(16)]
        public string Title { get; set; }
        public short PublishedYear { get; set; }
        public Kind Kind { get; set; }
        [Required]
        public Guid CompanyId { get; set; }
        public string Description { get; set; }

        [ForeignKey(nameof(CompanyId))]
        public Company Company { get; set; }
    }
}
