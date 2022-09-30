using Microsoft.AspNetCore.Mvc;

namespace Marcenaria_Godoy.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
