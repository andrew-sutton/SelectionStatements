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
            // Second part of the assignmnet, asking about school subjects
            Console.WriteLine("What is your favorite school subject?");

            var favoriteSubject = Console.ReadLine();

            switch (favoriteSubject)
            {
                case "Math":
                    Console.WriteLine("The highest form of pure thought is in mathematics - Plato");
                    break;
                case "Social Studies":
                    Console.WriteLine("Do you like people?");
                    break;
                case "Gym":
                    Console.WriteLine("I think I see a proffessional athele");
                    break;
                case "History":
                    Console.WriteLine("The more you know about the past, the better prepared you are for the future");
                    break;
                case "Art":
                    Console.WriteLine("The art of a people is a true mirror into their minds");
                    break;
                case "Science":
                    Console.WriteLine("Somewhere, something incredible is waiting to be known");
                    break;
                default:
                    Console.WriteLine("I haven't taken that subject before");
                    break;
            }
        }
    }
}
