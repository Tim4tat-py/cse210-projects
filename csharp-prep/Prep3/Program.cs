using System;
using System.Collections.Concurrent;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {    
        string on = "y";

        //Console.Write("What is the magic number? ");
        //string magicNumberString = Console.ReadLine();
        //float magicNumber = float.Parse(magicNumberString);

        do{
        string correct = "No";
        int count = 0;
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
            do{
                Console.Write("What is your number? ");
                string guessString = Console.ReadLine();
                float guess = float.Parse(guessString);

                if (guess > magicNumber)
                {
                    Console.WriteLine("lower");
                    count ++;
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                    count ++;
                }
                else
                {
                    Console.WriteLine("You got it!!");
                    correct = "Yes";
                    Console.WriteLine($"it took you {count} tries");

                    Console.Write("Play again? y/n ");
                    on = Console.ReadLine();
                }

            } while (correct == "No");
        } while (on == "y");
    }
}