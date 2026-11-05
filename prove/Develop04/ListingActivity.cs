using System.Diagnostics;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heros?"
    };
    public ListingActivity()
    {
        _activityName = "Listing Activity";
        _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public String GetPrompt()
    {
        Random random = new Random();
        int i = random.Next(0, 5);
        return _prompts[i];
    }
    public void DisplayPrompt()
    {
        DisplayStartMessage();

        Console.WriteLine("List as many responces you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {GetPrompt()} --- ");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        PauseAndCount(5);
        Console.WriteLine();

        Stopwatch stopwatch = Stopwatch.StartNew();
        TimeSpan duration = TimeSpan.FromSeconds(_activityDuration);
        while (stopwatch.Elapsed < duration)
        {
            Console.Write("> "); 
            Console.ReadLine();
        }

        DisplayEndMessage();

    }
}
