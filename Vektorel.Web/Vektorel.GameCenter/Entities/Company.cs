using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vektorel.GameCenter.Entities
{
    public class Company : BaseEntity
    {
        [Required]
        [MaxLength(16)]
        public string Name { get; set; }
        [Required]
        public Guid CountryId { get; set; }

        [ForeignKey(nameof(CountryId))]
        public LookUp Country { get; set; }
    }
}
