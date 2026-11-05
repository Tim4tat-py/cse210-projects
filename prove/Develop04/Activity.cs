using System.Runtime.CompilerServices;

public class Activity
{
    protected string _activityName;
    protected string _activityDescription;
    protected int _activityDuration;

    public Activity()
    {
        _activityName = "Null";
        _activityDescription = "Null";
        _activityDuration = 0;
    }

    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine("");
        Console.WriteLine(_activityDescription);

        Console.WriteLine("How long, in seconds, would you like for your session?");
        string durationString = Console.ReadLine();
        int duration = int.Parse(durationString);
        _activityDuration = duration;

        Console.WriteLine("Get ready...");
        PauseAndSpin(2);
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine("Well Done!!");
        PauseAndSpin(2);
    }
    public void PauseAndSpin(int timesSpun)
    {   
        for (int i = 0; i < timesSpun; i++)
        {
            Console.Write("-");

            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write("/");

            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write("|");

            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write(@"\");

            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
    public void PauseAndCount(int number)
    {
        for (int i = number; i > -1 + 1; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}