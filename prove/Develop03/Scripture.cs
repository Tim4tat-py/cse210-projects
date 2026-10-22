using System.Runtime.CompilerServices;
using System.Security;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string scripture)
    {
        _reference = reference;

        string[] words = scripture.Split(" ");
        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    public string DisplayRenderedText()
    {
        string reference = _reference.GetReference();
        string fullText = reference;
        foreach (Word part in _words)
        {
           fullText = fullText + " " + part.GetRenderedText();
        }

        return fullText;
    }
    public void HideRandomWords()
    {
        for (int i = 0; i < 4; i++)
        {
        int randomNumber = Random.Shared.Next(_words.Count);
        _words[randomNumber].HideWord();            
        }
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word part in _words)
        {
            if (part.IsHidden() == false)
            {
                return false;
            }
        }
        return true; 
    }
}