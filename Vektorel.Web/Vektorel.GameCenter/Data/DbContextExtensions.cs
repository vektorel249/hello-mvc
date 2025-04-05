using Microsoft.EntityFrameworkCore;
using Vektorel.GameCenter.Common;

namespace Vektorel.GameCenter.Data
{
    public static class DbContextExtensions
    {
        public static void AddGameCenterContext(this IServiceCollection services, DatabaseSettings settings)
        {
            services.AddDbContext<GameCenterContext>(builder =>
            {
                builder.UseSqlServer(settings.ConnectionString);
            });
        }
    }
}
