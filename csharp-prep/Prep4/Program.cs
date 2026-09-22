using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {
        // set constants
        List<float> numbers = new List<float>();
        bool on = true;
        float total = 0;
        float largest = -99999999;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // collect numbers into a list
        do
        {
            Console.Write("Enter a Number: ");
            string answer = Console.ReadLine();
            if (answer == "0")
            {
                on = false;
            }
            else
            {
                float answerFloat = float.Parse(answer);
                numbers.Add(answerFloat);
            }

        } while (on == true);

        //total
        foreach (float number in numbers)
        {
            total = total + number;

            //largest
            if (number > largest)
            {
                largest = number;
            }
        }
        
        // average
        float average = (total / numbers.Count);



        Console.WriteLine($"The average is {average}.");
        Console.WriteLine($"The total is {total}.");
        Console.WriteLine($"The largest is {largest}.");



    }
}