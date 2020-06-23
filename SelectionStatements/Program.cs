using System;
using System.Security.Cryptography.X509Certificates;

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
            var favSubject = FavoriteSubject();

            Console.WriteLine(favSubject);
        }
        // Second part of the assignmnet, asking about school subjects
        public static string FavoriteSubject()
        {
            Console.WriteLine("What is your favorite school subject?");

            var favSubject = Console.ReadLine();

            switch (favSubject)
            {
                case "Math":
                    return "The highest form of pure thought is in mathematics - Plato";
                case "Social Studies":
                    return "Do you like people?";
                case "Gym":
                     return "I think I see a proffessional athele";
                case "History":
                    return "The more you know about the past, the better prepared you are for the future";
                case "Art":
                    return "The art of a people is a true mirror into their minds";
                case "Science":
                    return "Somewhere, something incredible is waiting to be known";
                default:
                    return "I haven't taken that subject before";
            }
        }
    }
}
