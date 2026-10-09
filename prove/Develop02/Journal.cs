using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public List<Entry> _entries = new List<Entry> {};
    public void WriteEntry()
    {
        Entry entry1 = new Entry();
        Prompts prompt = new Prompts();
        string question = prompt.ChoosePrompt();
        Console.WriteLine($"{question}");
        Console.Write("> ");
        string promptResponse = Console.ReadLine();

        DateTime todaysDateSystem = (DateTime.Now);
        string todaysDate = "Date:" + todaysDateSystem.ToString();

        //string compositeInfo = "Prompt:" + question + " " + promptResponse ;
        entry1._date = todaysDate;
        entry1._question = question;
        entry1._response = promptResponse;

        _entries.Add(entry1);
    }

    public void DisplayJournal()
    {   
        foreach (Entry entry in _entries)
        {
            //Console.WriteLine(entry.Key + " " + entry.Value);
            Console.WriteLine(entry._date);
            Console.WriteLine(entry._question);
            Console.WriteLine(entry._response);
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
            Entry entryNew = new Entry();
            
            string[] parts = line.Split("|");

            string date = parts[0];
            string question = parts[1];
            string response = parts[2];

            entryNew._date = date;
            entryNew._question = question;
            entryNew._response = response;

            _entries.Add(entryNew);

            }
    }

    public void SaveJournal()
    {
        Console.WriteLine("What is the file name?");
        Console.WriteLine("Remember to add '.txt'");
        string fileName = Console.ReadLine();
        
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._question}|{entry._response}");
            }

        }
    }
}