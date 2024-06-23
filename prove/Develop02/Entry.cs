using System;

namespace Develop02;

// Class Entry's Purpose: To keep track of the date, prompt text, and the text of the entry itself.
public class Entry
{

    // 3 Global Member Variables of class Entry
    public string _date;
    public string _promptText;
    public string _entryText;

    // Entry: This is my constructor for my single journal entry.
    public Entry(string date, string promptText, string entryText)
    {
        this._date = date;
        this._promptText = promptText;
        this._entryText = entryText;

    }
    // ToString(): This override method is needed to convert the entries into String and avoid returning the default string representation (e.g., Develop02.Entry)
    public override string ToString()
    {

        return $"{_date} | {_promptText} | {_entryText}";

    }


    // Display: Inform the user when a journal entry was saved.
    public void Display()
    {
        // Tell the user that their entry was saved
        Console.WriteLine("---------------------");
        Console.WriteLine("To save your entry, choose option 4 in the menu. ");
        Console.WriteLine("---------------------");
    }


}
