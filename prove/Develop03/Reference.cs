namespace Develop03;
// Reference Class: Purpose is to keep track of the book, chapter, and verse information.
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;


    // Reference Constructor#1 Keeps track of the book, chapter, and verse information.
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    // Reference Constructor#2 Keeps track of the book, chapter, and range of verse information.
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

}
