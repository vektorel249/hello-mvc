using Microsoft.AspNetCore.Mvc;
using Vektorel.Cinemom.Services;

namespace Vektorel.Cinemom.Controllers
{
    public class HomeController : Controller
    {
        private readonly MovieRepository repository;

        public HomeController(MovieRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {
            var movies = repository.GetMovies();
            return View(movies); // Sayfa aç
        }

        public IActionResult GetImage(int id)
        {
            return Redirect("https://picsum.photos/200/200");
        }

        public IActionResult Recent()
        {
            var movies = repository.GetMovies()
                                   .Where(f => f.PublishedYear > 2020)
                                   .ToList();
            return View(movies); // Sayfa aç
        }

        public IActionResult Popular()
        {
            var movies = repository.GetMovies()
                                   .Where(f => f.Rating > 8)
                                   .ToList();
            return View(movies); // Sayfa aç
        }

        public IActionResult Support()
        {
            return View(); // Sayfa aç
        }
    }
}
