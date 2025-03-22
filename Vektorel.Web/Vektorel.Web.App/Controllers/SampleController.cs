using Microsoft.AspNetCore.Mvc;
using Vektorel.Web.App.Models;

namespace Vektorel.Web.App.Controllers;


/*

HTTP Methods : GET - POST - PUT - DELETE - PATCH 

 */

//https://vektorelakademi.com/Sample
public class SampleController : Controller
{
    // GET https://vektorelakademi.com/Sample/Index
    public IActionResult Index(int mode = 1)
    {
        var vm = new ProductViewModel
        {
            Products = GetProducts(),
            IsTable = mode == 1
        };
        return View(vm); // View klasörü altında -> Sample -> Index.cshtml
    }

    private List<Product> GetProducts()
    {
        return new List<Product>
        {
            new Product { Name = "Chai", Price = 18.10M, Stock = 36 },
            new Product { Name = "Chang", Price = 23.43M, Stock = 45 },
            new Product { Name = "Tofu", Price = 45M, Stock = 12 },
            new Product { Name = "Anyseed Syrup", Price = 10.64M, Stock = 3 },
            new Product { Name = "Tunart", Price = 39.21M, Stock = 22 },
            new Product { Name = "Lakkaliköri", Price = 34.09M, Stock = 76 },
            new Product { Name = "Coke", Price = 3.56M, Stock = 48 },
        };
    }
}