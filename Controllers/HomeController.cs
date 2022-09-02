using Microsoft.AspNetCore.Mvc;

namespace CodeAlong.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Doctor()
        {
            return View();
        }
    }
}