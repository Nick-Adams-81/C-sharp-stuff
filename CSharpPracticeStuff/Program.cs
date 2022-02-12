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



            while (true)
            {

                Random random = new Random();
                int correctNumber = random.Next(1, 10);
                int guess = 0;

                Console.WriteLine("Guess a number from 1 and 10");
                while (guess != correctNumber)
                {
                    string playerGuess = Console.ReadLine();

                    if (!int.TryParse(playerGuess, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please guess a number");
                        Console.ResetColor();
                        continue;
                    }

                    guess = Int32.Parse(playerGuess);

                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong number, Guess again!!");
                        Console.ResetColor();
                    }

                }

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("You win!!!");
                Console.ResetColor();

                Console.WriteLine("Play again[Y/N]?");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    Console.WriteLine("Thanks for playing!!!");
                    return;
                }
                else
                {
                    return;
                }

            }


        }
    }
}
