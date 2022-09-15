using Microsoft.AspNetCore.Mvc;

namespace MVC_Basics.Models
{
    public class TempModel
    {
    [BindProperty]
        public double Temperature { set; get; }

        public string? Message { set; get; }

        public static string CheckTemp(double Temperature, string Message)
        {
            if (Temperature >= 37.8)
            {
               return Message = "You have a fever!";
            }
            else if (Temperature <= 35)
            {
                return Message = "Brrr... You have Hypothermia! Seek medical attention!";
            }
            else
            {
                return Message = "You're fine!";
            }
        }
    }
}