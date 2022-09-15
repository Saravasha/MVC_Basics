using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using MVC_Basics.Models;

namespace MVC_Basics.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult FeverCheck()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult SendTemp() 
        { 
            TempModel userTemp = new TempModel();
            return View(userTemp);
        }

        [HttpGet]
        public IActionResult YourTemp(string Message, double Temperature)
        {
            return View();
        }
    }
}
