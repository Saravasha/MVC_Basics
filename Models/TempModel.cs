using Microsoft.AspNetCore.Mvc;

namespace MVC_Basics.Models
{
    public class TempModel
    {
        public static string CheckTemp(double temp)
        {
            if (temp >= 55)
            {
                return "You are Medium-Rare! Bon Appétit!";
            }
            else if (temp >= 37.8)
            {
                return "You have a fever!";
            }
            else if (temp <= 0)
                return "You are likely a popsicle";
            else if (temp <= 35)
            {
                return "Brrr... You have Hypothermia! Seek medical attention!";
            }
            else
            {
                return "You're fine!";
            }
        }
    }
}