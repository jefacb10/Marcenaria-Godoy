using Microsoft.AspNetCore.Mvc;

namespace Marcenaria_Godoy.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
