using Microsoft.AspNetCore.Mvc;

namespace Vektorel.Cinemom.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); // Sayfa aç
        }

        public IActionResult Recent()
        {
            return View(); // Sayfa aç
        }

        public IActionResult Popular()
        {
            return View(); // Sayfa aç
        }

        public IActionResult Support()
        {
            return View(); // Sayfa aç
        }
    }
}
