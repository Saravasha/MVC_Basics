using Microsoft.AspNetCore.Mvc;
using MVC_Basics.Models;

namespace MVC_Basics.Controllers
{
    public class DoctorController : Controller
    {
        //[HttpGet]

        public IActionResult FeverCheck()
        {
            return View();
        }

        public IActionResult TakeTemp(TempModel model)
        {
            var userTemp = new TempModel();
            return View(userTemp);
        }


        //[HttpPost]
        //public IActionResult Temp(TempModel userTemp)
        //{
        //    return View();

        //}
    }
}
