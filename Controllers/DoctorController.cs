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
        public IActionResult SendTemp(double temp) 
        {
            ViewBag.Message = TempModel.CheckTemp(temp);
          
            return View("FeverCheck");
        }
    }
}
