using System.Diagnostics.Contracts;

namespace Develop03;

// Word Class: To keep track of a single word and whether it is shown or hidden
public class Word
{
    private string _text;
    private bool _isHidden;

    // Keeps track of a single word
    public Word(string text, bool isHidden)
    {
        _text = text;
        _isHidden = isHidden;
        Hide();


    }
    // Hide the word
    public void Hide()
    {
        _isHidden = true;

    }
    // Show the word
    public void Show()
    {
        _isHidden = false;
    }
    // Default value of words is to show them
    public bool IsHidden()
    {
        return false;

    }

    public string GetDisplayText()
    {
        return "";
    }

    public override string ToString()
    {
        return $"{_text}";
    }

}
