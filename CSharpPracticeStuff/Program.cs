using System;

namespace CSharpPracticeStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "Number guessing game";
            string appVersion = "1.0.0";
            string appAuthor = "Nick Adams";


            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("{0}: Version: {2} By: {1}", appName, appAuthor, appVersion);
            Console.ResetColor();


            Console.WriteLine("What is your name?");
            string nameResponse = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game", nameResponse);

            int correctNumber = 7;
            int guess = 0;

            Console.WriteLine("Guess a number from 1 and 10");

            while (guess != correctNumber)
            {
                string playerGuess = Console.ReadLine();
                guess = Int32.Parse(playerGuess);

                if (guess != correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Guess again!!");
                    Console.ResetColor();
                }

            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("You win!!!");
            Console.ResetColor();
                

        }
    }
}
