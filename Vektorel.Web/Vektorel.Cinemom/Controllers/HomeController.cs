using Microsoft.AspNetCore.Mvc;

namespace Vektorel.Cinemom.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); // Sayfa a�
        }

        public IActionResult Recent()
        {
            return View(); // Sayfa a�
        }

        public IActionResult Popular()
        {
            return View(); // Sayfa a�
        }

        public IActionResult Support()
        {
            return View(); // Sayfa a�
        }
    }
}
