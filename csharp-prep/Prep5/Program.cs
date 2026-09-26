using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        static void main()
        {
            DisplayWelcome();
            string name = PromptUserName();
            int favNumber = PromptUserNumber();

            int birthYear;
            PromptUserBirthyear(out birthYear);

            int squaredNumb = SquaredNumber(favNumber);

            DisplayResult(name, squaredNumb, birthYear);



        }

       static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string Name = Console.ReadLine();

            return Name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string favNumberString = Console.ReadLine();
            int favNumber = int.Parse(favNumberString);

            return favNumber;
        }

        static void PromptUserBirthyear(out int yearBorn)
        {
            Console.Write("Please enter the year you were born: ");
            string yearBornString = Console.ReadLine();
            yearBorn = int.Parse(yearBornString);

        }

        static int SquaredNumber(int num)
        {
            int square = num * num;
            return square;
        }

        static void DisplayResult(string name, int secondNum, int birthNumber)
        {
            Console.WriteLine($"{name}, the square of your number is {secondNum}");

            int age = 2026 - birthNumber;
            Console.WriteLine($"{name}, you will turn {age} this year.");
        }

        main();

    }
}