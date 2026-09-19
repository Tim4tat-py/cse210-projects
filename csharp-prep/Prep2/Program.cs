using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradeString = Console.ReadLine();
        float grade = float.Parse(gradeString);

        string letter = "";
        string sign = "";

        if (grade >= 90)
        {
            letter = "A";
            //Console.WriteLine("You have an A ");
        }
        else if(grade >= 80)
        {
            letter = "B";
            //Console.WriteLine("You have a B ");
        }
        else if(grade >= 70)
        {
            letter = "C";
            //Console.WriteLine("You have a C ");
        }
        else if(grade >= 60)
        {
            letter = "D";
            //Console.WriteLine("You have a D ");
        }
        else
        {
            letter = "F";
            //Console.WriteLine("You have an F ");
        }

        if ((grade % 10) >= 7)
        {
            sign = "+";
        }
        else if ((grade % 10) < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (letter == "A" && sign == "+")
        {
            sign = "";
        }

        if (letter == "F" && sign != "")
        {
            sign = "";
        }

        Console.WriteLine($"You have a {letter}{sign}");

        if (grade >= 70)
        {
            Console.Write("Congrats! You have passed!");
        }
        else
        {
            Console.Write("You failed, keep trying");
        }
    }
}