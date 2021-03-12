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
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, authorName);

            // Reset Color
            Console.ResetColor();
        }
    }
}
