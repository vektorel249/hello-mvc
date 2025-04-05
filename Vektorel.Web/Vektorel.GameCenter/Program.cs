using Vektorel.GameCenter.Common;
namespace Vektorel.GameCenter;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        var databaseSettings = builder.AddCustomConfig<DatabaseSettings>();
        var tcmbSettings = builder.AddCustomConfig<TcmbSettings>();
        builder.AddCustomConfig<PageSettings>();

        builder.Services.AddControllersWithViews();
        builder.Services.AddCurrencyService(tcmbSettings);
        builder.Services.AddGameCenterContext(databaseSettings);

        var app = builder.Build();

        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}
