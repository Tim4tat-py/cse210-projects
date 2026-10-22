using System.Data;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;

public class Reference
{
    private string _book = "";
    private int _chapter = 0;
    private int _verse = 0;
    private int _endVerse = 0;

    public Reference()
    {
        _book = "John";
        _chapter = 3;
        _verse = 16;
    }

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }
    public void GetBookInformation()
    {   
        Console.WriteLine("Please enter scripture information");
        Console.Write("Book: ");
        _book = Console.ReadLine();

        Console.Write("Chapter: ");
        string chapterString = Console.ReadLine(); 
        int chapter = int.Parse(chapterString);
        _chapter = chapter;

        Console.Write("Starting verse Number: ");
        string verseString = Console.ReadLine();
        int verse = int.Parse(verseString);
        _verse = verse;

        Console.Write("Are there multiple verses?(y/n): ");
        string answer = Console.ReadLine();
        if (answer == "y")
        {
            Console.Write("What is the ending verse number? ");
            string endVerseString = Console.ReadLine();
            int endVerse = int.Parse(endVerseString);
            _endVerse = endVerse;
        }   
    }
    public string GetReference()
    {   
        if (_endVerse != 0)
        {
            string completeReference = $"{_book} {_chapter}:{_verse}-{_endVerse}";
            return completeReference;
        }
        else
        {
            string completeReference = $"{_book} {_chapter}:{_verse}";
            return completeReference;
        }
    }
}