using System;

// namespace
namespace NumberGuesser
{
    // Main class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            // Set App Vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string authorName = "Mason Protsman";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Blue;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, authorName);

            // Reset Color
            Console.ResetColor();

            // Prompt user name
            Console.WriteLine("What is your name?");

            // Get User Input
            string userName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", userName);

            // Set Correct Number
            int correctNumber = 7;

            // Init Guess Var
            int userGuess = 0;

            // Prompt User For Number
            Console.WriteLine("Guess a number between 1 and 10");

            // While
            while(userGuess != correctNumber)
            {
                //Get User Input
                string input = Console.ReadLine();

                // Cast Input To Int
                userGuess = Int32.Parse(input);

                // Check User Guess
                if(userGuess != correctNumber)
                {
                    // Change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    // Write out Wrong message
                    Console.WriteLine("Wrong answer, please try again...");

                    // Reset Color
                    Console.ResetColor();
                }

            }
            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out correct message
            Console.WriteLine("Your guess is correct. You win!!!");
        }
    }
}
