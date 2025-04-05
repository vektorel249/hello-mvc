using System.ComponentModel.DataAnnotations;

namespace Vektorel.GameCenter.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime Created { get; set; }
    }
}
