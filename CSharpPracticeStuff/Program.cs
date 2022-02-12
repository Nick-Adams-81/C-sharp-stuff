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

            Console.WriteLine("test");


        }
    }
}
