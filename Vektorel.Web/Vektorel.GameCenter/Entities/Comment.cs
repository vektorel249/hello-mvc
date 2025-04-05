using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vektorel.GameCenter.Entities
{
    public class Comment : BaseEntity
    {
        public Guid GameId { get; set; }
        [MaxLength(16)]
        public string Gamer { get; set; }
        public short Rating { get; set; }
        [MaxLength(128)]
        public string Content { get; set; }

        [ForeignKey(nameof(GameId))]
        public Game Game { get; set; }
    }
}
