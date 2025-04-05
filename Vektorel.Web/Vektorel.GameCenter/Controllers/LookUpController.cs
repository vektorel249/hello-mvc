using Microsoft.AspNetCore.Mvc;

namespace Vektorel.GameCenter.Controllers;

public class LookUpController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
