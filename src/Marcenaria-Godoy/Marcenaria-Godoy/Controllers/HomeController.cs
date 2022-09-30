using Marcenaria_Godoy.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Marcenaria_Godoy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return RedirectToRoute(new { controller = "AboutUs", action = "Index"});
        }

        public IActionResult Projects()
        {
            return RedirectToRoute(new { controller = "Projects", action = "Index" });
        }

        public IActionResult Contact()
        {
            return RedirectToRoute(new { controller = "Contact", action = "Index" });
        }

        public IActionResult Bathroom()
        {
            return RedirectToRoute(new { controller = "Projects", action = "Bathroom" });
        }

        public IActionResult Bedroom()
        {
            return RedirectToRoute(new { controller = "Projects", action = "Bedroom" });
        }

        public IActionResult Kitchen()
        {
            return RedirectToRoute(new { controller = "Projects", action = "Kitchen" });
        }

        public IActionResult Office()
        {
            return RedirectToRoute(new { controller = "Projects", action = "Office" });
        }

        public IActionResult Room()
        {
            return RedirectToRoute(new { controller = "Projects", action = "Room" });
        }

        public IActionResult Kids()
        {
            return RedirectToRoute(new { controller = "Projects", action = "Kids" });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            _logger.LogError("Erro ao acessar o site");
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}