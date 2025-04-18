using Microsoft.AspNetCore.Identity;
using Vektorel.GameCenter.Common;
using Vektorel.GameCenter.Data;
using Vektorel.GameCenter.Entities;
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
        
        //builder.Services.AddMemoryCache(); Zaten var MVC'de o sebeple eklemedik
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

        app.UseAuthentication();
        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}
