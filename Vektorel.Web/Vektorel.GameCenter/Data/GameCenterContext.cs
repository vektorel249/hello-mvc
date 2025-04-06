using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Vektorel.GameCenter.Entities;

namespace Vektorel.GameCenter.Data
{
    public class GameCenterContext : IdentityDbContext<User>
    {
        public GameCenterContext(DbContextOptions<GameCenterContext> options) : base(options)
        {
            
        }
        public DbSet<Game> Games { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<LookUp> LookUps { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
