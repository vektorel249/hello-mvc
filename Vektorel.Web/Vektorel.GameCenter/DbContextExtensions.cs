using Microsoft.EntityFrameworkCore;
using Vektorel.GameCenter.Common;
using Vektorel.GameCenter.Data;

namespace Vektorel.GameCenter
{
    public static class ApplicationExtensions
    {
        public static void AddGameCenterContext(this IServiceCollection services, DatabaseSettings settings)
        {
            services.AddDbContext<GameCenterContext>(builder =>
            {
                builder.UseSqlServer(settings.ConnectionString);
            });
        }

        public static T AddCustomConfig<T>(this WebApplicationBuilder builder) where T : class
        {
            builder.Services.Configure<T>(builder.Configuration.GetSection(typeof(T).Name));
            return builder.Configuration.GetSection(typeof(T).Name).Get<T>();
        }
    }
}
