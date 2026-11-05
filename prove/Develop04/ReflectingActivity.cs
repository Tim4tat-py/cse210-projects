using System.Diagnostics;

public class ReflectingActivity : ListingActivity
{
    public ReflectingActivity()
    {
        _activityName = "Reflecting Activity";
        _activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
    private List<string> _reflectionPrompts = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Havee you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not sucsessful?",
        "What is your favorite thing about this experiance?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experiance?",
        "How can you keep this experiance in mind in the future?"
    };
        private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time where you did something very difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truely selfless."
    };

    private string GetReflectionPrompt()
    {
        Random random = new Random();
        int i = random.Next(0, 9);
        return _reflectionPrompts[i];
    }

    private string GetpromptRef()
    {
        Random random = new Random();
        int i = random.Next(0, 4);
        return _prompts[i];
    }
    public void DisplayReflectionPrompt()
    {
        DisplayStartMessage();
        
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {GetpromptRef()} --- ");
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experiance.");
        Console.Write("You may begin in: ");     
        PauseAndCount(5);  

        Console.Clear();

        Stopwatch stopwatch = Stopwatch.StartNew();
        TimeSpan duration = TimeSpan.FromSeconds(_activityDuration);
        while (stopwatch.Elapsed < duration)
        {        
        Console.WriteLine($"> {GetReflectionPrompt()}");
        PauseAndSpin(6);
        }

        DisplayEndMessage();
    }
}