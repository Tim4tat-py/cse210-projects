using System;
using System.Data;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Reference reference = new Reference();
        reference.GetBookInformation();
        Console.WriteLine("What is the verse: ");
        string verse = Console.ReadLine();
        Scripture scripture = new Scripture(reference, verse);

        Console.Clear();
        Console.WriteLine(scripture.DisplayRenderedText());

        bool on = true;
        while (on == true)
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string response = Console.ReadLine();
            if (response == "")
            {
                scripture.HideRandomWords();
                Console.Clear();
                Console.WriteLine(scripture.DisplayRenderedText());
                if (scripture.IsCompletelyHidden() == true)
                {
                    on = false;
                }
            }
            else if (response == "quit")
            {
                on = false;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            
        }
    }
}