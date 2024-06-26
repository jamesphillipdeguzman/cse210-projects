namespace Develop03;

// Scripture Class: Purpose is to keep track of both the reference and the text of the scripture.
public class Scripture
{

    private Reference _reference;
    private List<Word> _words;

    // Keeps track of both the reference and the text of the scripture.
    public Scripture(Reference reference, string text)
    {

    }
    // Hide words
    public void HideRandomWords(int numberToHide)
    {

    }
    // Get the rendered display of the text.
    public string GetDisplayText()
    {
        return "";
    }
    // Default value of the scripture is to show everything at first.
    public bool IsCompletelyHidden()
    {
        return false;
    }

}
