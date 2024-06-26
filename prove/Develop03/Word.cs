using System.Diagnostics.Contracts;

namespace Develop03;

// Word Class: To keep track of a single word and whether it is shown or hidden
public class Word
{
    private string _text;
    private bool _isHidden;

    // Keeps track of a single word
    public Word(string text)
    {

    }
    // Hide the word
    public void Hide()
    {

    }
    // Show the word
    public void Show()
    {

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

}
