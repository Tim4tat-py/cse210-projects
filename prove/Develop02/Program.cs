using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool power = true;

        Console.WriteLine("");
        Console.WriteLine("Welcome to the Journal program!");

        while (power == true)
        {
            Console.WriteLine("");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            
            int responce = int.Parse(Console.ReadLine());

            if (responce == 1)
            {
                journal.WriteEntry();
            }
            else if (responce == 2)
            {
                journal.DisplayJournal();
            }
            else if (responce == 3)
            {
                journal.LoadJournal();
            }
            else if (responce == 4)
            {
                journal.SaveJournal();
            }
            else if (responce == 5)
            {
                Console.WriteLine("Goodbye");
                power = false;
            }
            else
            {
                Console.WriteLine("That is an invalid option. Please try again.");
            }
        }
    }
}