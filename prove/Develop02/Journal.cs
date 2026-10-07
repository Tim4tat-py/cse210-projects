public class Journal
{
    public Dictionary<string, string> _entries = new Dictionary<string, string>{};
    public void WriteEntry()
    {
        Prompts prompt = new Prompts();
        string question = prompt.ChoosePrompt();
        Console.WriteLine($"{question}");
        Console.Write("> ");
        string promptResponce = Console.ReadLine();

        DateTime todaysDateSystem = (DateTime.Now);
        string todaysDate = "Date:" + todaysDateSystem.ToString();

        string compositeInfo = "Prompt:" + question + " " + promptResponce ;

        _entries.Add(todaysDate, compositeInfo);
    }

    public void DisplayJournal()
    {   
        foreach (KeyValuePair<string, string> entry in _entries)
        {
            //Console.WriteLine(entry.Key + " " + entry.Value);
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        } 
    }

    public void LoadJournal()
    {
        Console.WriteLine("What is the file name?");
        Console.WriteLine("Remember to add '.txt'");
        string fileName = Console.ReadLine();
        
        string[] lines = System.IO.File.ReadAllLines(fileName);

        _entries.Clear();

        foreach (string line in lines)
            {
            string[] parts = line.Split("|");

            string date = parts[0];
            string promptInfo = parts[1];

            _entries.Add(date, promptInfo);

            }
    }

    public void SaveJournal()
    {
        Console.WriteLine("What is the file name?");
        Console.WriteLine("Remember to add '.txt'");
        string fileName = Console.ReadLine();
        
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (KeyValuePair<string, string> entry in _entries)
            {
                outputFile.WriteLine($"{entry.Key}|{entry.Value}");
            }

        }
    }
}