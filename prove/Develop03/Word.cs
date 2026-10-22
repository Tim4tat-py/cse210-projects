using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

public class Word
{
    private string _text = "";
    private bool _isHidden = false;

    public Word(string text)
    {
        _text = text;
    }
    public void HideWord()
    {
        _isHidden = true;
    }
    public string GetRenderedText()
    {
        if (_isHidden == true)
        {
            return "___";
        }
        else
        {
            return _text;
        }
    }
    public bool IsHidden()
    {
        if (_isHidden == false)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}