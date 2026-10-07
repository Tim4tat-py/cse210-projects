public class Prompts
{
    public List<string> _prompts  = new List<string>
    {
    "What did you eat today?", 
    "What was the best thing that happened today?", 
    "Where did you go today?", 
    "Who did you see today?", 
    "What do you wish you did differently today?"
    };

    public string ChoosePrompt()
    {
        Random random = new Random();
        int i = random.Next(0, 5);
        return _prompts[i];
    }
}