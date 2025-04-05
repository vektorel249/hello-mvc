using Microsoft.EntityFrameworkCore;
using Vektorel.GameCenter.Entities;

namespace Vektorel.GameCenter.Data
{
    public class GameCenterContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<LookUp> LookUps { get; set; }
    }
}
