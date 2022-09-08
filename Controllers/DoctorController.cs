using Microsoft.AspNetCore.Mvc;
using MVC_Basics.Models;

namespace MVC_Basics.Controllers
{
    public class DoctorController : Controller
    {
        [HttpGet]
        public IActionResult PostTemp(double Temp)
        {
            var userTemp = new FeverCheck(); 
            return View(userTemp);
        }

        [HttpPost]
        public IActionResult ReturnedTemp(FeverCheck userTemp)
        {
            return View();

        }
    }
}
