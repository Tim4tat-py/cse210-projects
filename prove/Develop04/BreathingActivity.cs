using System.Diagnostics;
using System.Runtime.Serialization;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _activityName = "Breathing Activity";
        _activityDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void AlternatingMessage()
    {
        DisplayStartMessage();


        Stopwatch stopwatch = Stopwatch.StartNew();
        TimeSpan duration = TimeSpan.FromSeconds(_activityDuration);

        while (stopwatch.Elapsed < duration)
        {
            Console.WriteLine("Breath in...");
            PauseAndCount(3);
            Console.WriteLine("");

            Console.WriteLine("Breath out...");
            PauseAndCount(5);
            Console.WriteLine();
        }

        DisplayEndMessage();
    }
}