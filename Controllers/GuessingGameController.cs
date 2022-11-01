using Microsoft.AspNetCore.Mvc;
using MVC_Basics.Models;

namespace MVC_Basics.Controllers
{
    public class GuessingGameController : Controller
    {
        private CookieOptions? options;
        
        public IActionResult Game()
        {
            loadHighscore();
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("Number")))
            {
                GuessingGame.GuessNumber = GuessingGame.GenerateNumber();
                HttpContext.Session.SetString("Number", GuessingGame.GuessNumber.ToString());
            }
            else
            {
                GuessingGame.GuessNumber = int.Parse(HttpContext.Session.GetString("Number"));
            }

            return View();
        }

        private void loadHighscore()
        {
            if (!String.IsNullOrEmpty(HttpContext.Request.Cookies["Highscore"]))
            {
                ViewBag.Highscore = $"Highscore (number of guesses before win): {HttpContext.Request.Cookies["Highscore"]}" ;
            }
            else
                ViewBag.Highscore = "";
        }

        [HttpPost]

        public IActionResult Game(string playerGuess)
        {
            ViewBag.PlayerGuess = playerGuess;
            ViewBag.Message = GuessingGame.Game(playerGuess);
            if (GuessingGame.GameOver)
            {
                AddCount(GuessingGame.SetCount);
                GuessingGame.SetCount = 0;
                GuessingGame.GuessNumber = GuessingGame.GenerateNumber();
                HttpContext.Session.SetString("Number", GuessingGame.GuessNumber.ToString());
            }
            else
            {
                GuessingGame.SetCount++;
                ViewBag.numAttempts = $"Number of attempts: { GuessingGame.SetCount}";
            }
            loadHighscore();
            return View();
        }

        private void AddCount(int count)
        {

            options = new CookieOptions();
            options.Expires = DateTime.Now.AddDays(1);
            if (!String.IsNullOrEmpty(HttpContext.Request.Cookies["Highscore"]))
            {
                if (int.Parse(HttpContext.Request.Cookies["Highscore"]) > count)
                {
                    HttpContext.Response.Cookies.Append("Highscore", count.ToString(), options);
                }
            }
            else
            {
                HttpContext.Response.Cookies.Append("Highscore", count.ToString(), options);
            }
        }
    }
}