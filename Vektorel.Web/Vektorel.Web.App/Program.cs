namespace Vektorel.Web.App;

/*
 MVC: Model - View - Controller
 DI : Dependency Injection
 Builder Pattern
 */

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllersWithViews();
        var app = builder.Build();

        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles(); // Projede resim, css, js gibi asset'leri kullanabilmemizi sa�lar
        app.UseRouting(); // Projenin adres y�nlendirmesi sa�lar 
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}
