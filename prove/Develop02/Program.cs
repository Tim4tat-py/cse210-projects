using System;
using System.IO;
using System.Transactions;
class Program
{
    static void Main(string[] args)
    {
        int comment = 0;
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
            
            int response = int.Parse(Console.ReadLine());

            if (response == 1)
            {
                journal.WriteEntry();
            }
            else if (response == 2)
            {
                journal.DisplayJournal();
            }
            else if (response == 3)
            {
                journal.LoadJournal();
            }
            else if (response == 4)
            {
                journal.SaveJournal();
            }
            else if (response == 5)
            {
                Console.WriteLine("Goodbye");
                power = false;
            }
            else
            {
                Console.WriteLine("That is an invalid option. Please try again.");
            }
        }
        //I added a mood section to the entry and handled 
        //the case where an unexpected input is put into
        //the main section
    }
}

