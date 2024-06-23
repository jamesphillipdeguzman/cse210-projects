using System;
using System.Collections.Generic;
using System.IO;

namespace Develop02;
// A Journal should store a list of Entry objects. The data type for this should be List<Entry>.
public class Journal
{
    // Declare a global variable which is a list, and is of type Entry.
    public List<Entry> _entries = new List<Entry>();


    // Menu# 1 - AddEntry: Stores a list of journal entries
    public void AddEntry(Entry newEntry)
    {

        _entries.Add(newEntry);

    }
    // Menu# 2 - DisplayAll: Display my journal entries along with the date and prompt associated with that entry.
    public void DisplayAll()
    {

        foreach (Entry entry in _entries)
        {
            // Display the entries using this format
            Console.WriteLine($"{entry._date} - {entry._promptText}\n{entry._entryText}\n");
        }
        if (_entries.Count == 0)
        {
            Console.WriteLine(">> Nothing to display for now. To start writing, choose option 1.");

        }
    }



    // Menu# 3 - LoadFromFile: To load my journal entries from a file chosen by the user.
    public string LoadFromFile(string fileName)
    {
        int ctrEntries = 0;
        int lineLength = 0;
        // Check if file name is not empty
        if (fileName == "")
        {

            // load default filename if empty to avoid error
            fileName = "journal.csv";
            string[] lines = System.IO.File.ReadAllLines(fileName);
            // Read the contents only
            string fileContent = File.ReadAllText(fileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                if (parts[0] == "")
                {   // skip any line breaks and print the next entry...
                    lineLength -= 1;
                    continue;

                }
                else
                {
                    string dateText = parts[0].Trim();
                    string promptText = parts[1].Trim();
                    string entryText = parts[2].Trim();
                    //Console.WriteLine($" {dateText} - {promptText}\n {entryText}\n");
                    //allEntries = $" {dateText} - {promptText}\n {entryText}\n";
                    ctrEntries += 1;

                }

            }
            // if (lineLength == ctrEntries)
            // {
            //     Console.WriteLine("The number of entries is " + ctrEntries);
            // }
            // Console.WriteLine($"{ctrEntries} entries loaded from file");
            // Console.WriteLine($">> The file content is: \n{fileContent}\n>> Number of characters: {fileContent.Length}");
            return fileContent;

        }
        else
        {
            if (File.Exists(fileName))
            {
                // Read the contents of the text file line per line
                string[] lines = System.IO.File.ReadAllLines(fileName);
                // Read the contents only
                string fileContent = File.ReadAllText(fileName);

                lineLength = lines.Length;
                foreach (string line in lines)
                {
                    string[] parts = line.Split("|");

                    if (parts[0].Trim() == "")
                    {   // skip any line breaks and print the next entry...
                        lineLength -= 1;
                        continue;

                    }
                    else
                    {
                        string dateText = parts[0].Trim();
                        string promptText = parts[1].Trim();
                        string entryText = parts[2].Trim();
                        Console.WriteLine($" {dateText} - {promptText}\n {entryText}\n");
                        //allEntries = $" {dateText} - {promptText}\n {entryText}\n";
                        ctrEntries += 1;

                    }

                }
                if (lineLength == ctrEntries)
                {
                    Console.WriteLine("The number of entries is " + ctrEntries);

                    //Console.WriteLine($"{ctrEntries} entries loaded from file");
                    //Console.WriteLine($">> The file content is: \n{fileContent}\n>> Number of characters: {fileContent.Length}");
                    return fileContent;
                }
            }

            return "";
        }
    }


    // Menu# 4 - SaveToFile: To save my journal entries to a file chosen by the user.
    public void SaveToFile(string fileName, string journalContent)
    {
        int ctrSaveCount = 0;
        string myJournalContents = "";
        myJournalContents = journalContent;
        foreach (Entry entry in _entries)
        {
            // save newEntry as pipe-delimited text entry here
            string newEntry = $"{entry._date} | {entry._promptText} | {entry._entryText}";
            ctrSaveCount += 1;
            if (myJournalContents.Length != 0)
            {
                if (myJournalContents.Contains(newEntry))
                {
                    // myJournalContents = journalContent;
                    continue;
                }
                else
                {
                    myJournalContents += newEntry + " | " + "\n";
                }

                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    // Save my journal entries in a text file.

                    writer.WriteLine($"{myJournalContents.Trim()}");

                }
            }
            else
            {
                myJournalContents += newEntry + " | " + "\n";
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    // Save my journal entries in a text file.

                    writer.WriteLine($"{myJournalContents.Trim()}");

                }
            }


        }
    }
}
