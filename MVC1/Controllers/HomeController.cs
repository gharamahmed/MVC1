using Microsoft.AspNetCore.Mvc;

namespace MVC1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
