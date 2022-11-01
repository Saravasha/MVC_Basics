namespace MVC_Basics.Models
{
    public class GuessingGame
    {
        public static int GuessNumber;
        public static bool GameOver { get; internal set; }
        public static int SetCount { get; internal set; }
        public static string? Message { get; private set; }

        internal static int GenerateNumber()
        {
            GameOver = false;
            SetCount = 0;
            Random random = new Random();
            return random.Next(0, 101);
        }

        internal static string Game(string playerGuess)
        {
            try
            {

                if (int.Parse(playerGuess) < GuessNumber)
                    Message = "Too small, try a larger number!";
                else if (int.Parse(playerGuess) > GuessNumber)
                    Message = "Too large, try a smaller number!";
                else
                {
                    Message = $"{GuessingGame.GuessNumber} is correct! It took you {GuessingGame.SetCount} number of guesses! Good job! :D\nReloading! :)";
                    GameOver = true;
                }
            }
            catch
            {
                Message = "Invalid input";
            }

            return Message;
        }
    }
}