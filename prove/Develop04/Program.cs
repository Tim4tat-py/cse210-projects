using System;
using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        bool on = true;
        Console.Clear();
        int counter1 = 0;
        while (on == true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("     1. Start breathing activity");
            Console.WriteLine("     2. Start reflecting activity");
            Console.WriteLine("     3. Start listing activity");
            Console.WriteLine("     4. Quit");
            Console.Write("Select a choice from the menu: ");

            string selection = Console.ReadLine();

            if (selection == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                Console.Clear();

                breathingActivity.AlternatingMessage();

                counter1 += 1;
            }

            else if (selection == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                Console.Clear();

                reflectingActivity.DisplayReflectionPrompt();

                counter1 += 1;
            }

            else if (selection == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                Console.Clear();

                listingActivity.DisplayPrompt();

                counter1 += 1;
            }

            else if (selection == "4")
            {
                Console.Clear();
                Console.WriteLine("Goodbye");
                on = false;
            }

            else
            {
                Console.WriteLine("Invalid input");
            }

        }
        Console.Clear();
        Console.WriteLine($"You did {counter1} activities");
        
    }
}