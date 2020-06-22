using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            var userInput = -1;

            Console.WriteLine("Guess my favorite number:");
            while (true)
            {
                userInput = int.Parse(Console.ReadLine());
                if (userInput == favNumber)
                {
                    Console.WriteLine("Correct!");
                    break;
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("Too high");
                }
                else if (userInput < favNumber)
                {
                    Console.WriteLine("Too low");
                }
                else { Console.WriteLine("Nevermind"); }
            }
        }
    }
}
