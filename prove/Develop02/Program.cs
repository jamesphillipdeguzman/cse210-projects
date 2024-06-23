using System;
using System.Diagnostics.Contracts;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using Develop02;

/* Author: James Phillip K. De Guzman
 * Programming Language: C Sharp or C#
 * Instructor: Brother Duane Richards
 * Date Started: June 21, 2024
 * Date Finished: June 23, 2024
 * Testing: Did a ton of them, and yet, my program still isn't perfect. Sorry about that.
   On the brigther side, it runs and generally, each menu function works as intended. :)
*/

/* Creativity and Exceeding Core Requirements:
 * 1) Added new prompt questions to the journal (at least 17 more, a total of 22 prompts or questions).
 * 2) Added number of characters the journal entries has stored.
 * 3) Implemented some error trapping for incorrect user inputs.
 * 4) Performed checks if journal.csv exists and whether it has contents.
 */



class Program
{
    // This is my class Main - where my Journal program starts executing...
    static void Main(string[] args)
    {
        // Instantiate a new Journal here to use it's member methods / functions...
        Journal theJournal = new Journal();

        // Initialize other variables here (e.g., user's menu choice and the current date, prompt, reply and input file)
        string userChoice = "";
        string thePrompt = "";
        string myReply = "";
        string inputFile = "journal.csv";
        string allJournalEntries = "";
        bool isLoaded = false;
        DateTime currentDate = DateTime.Now;
        string dateText = currentDate.ToShortDateString();

        // Check if file exists and has something in there in the txt or csv file...

        if (File.Exists(inputFile))
        {
            string fileContent = File.ReadAllText(inputFile);

            if (fileContent.Length > 0)
            {

                if (!isLoaded)
                {
                    Console.WriteLine($">> {inputFile} file exists and has contents. \n\nIMPORTANT! To avoid deletion of existing data, save at least 2 entries AFTER YOU LOAD your journal.");
                }
                else
                {
                    Console.WriteLine($">> {inputFile} file exists, and has been loaded.");
                }

            }
            else
            {
                Console.WriteLine($">> {inputFile} file exists, but has no contents.");
            }

        }
        else
        {
            Console.WriteLine(">> No journal file was found.");

        }
        // Show the welcome screen for the Journal C# program
        // Console.WriteLine();
        // Console.Write("--------------------------------------- ");
        Console.WriteLine(".::Welcome to the Journal Program!::.");
        // Console.WriteLine("--------------------------------------- ");
        // Console.WriteLine();
        do
        {
            // Show user menu
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            userChoice = Console.ReadLine();



            // Select from the menu
            switch (userChoice.Trim())
            {
                // 1. Write - A journal entry is written and stored along with the date.
                case "1":

                    // If inputFile does not exist yet
                    if (inputFile == "")
                    {
                        // Pass a single journal entry
                        PromptGenerator myPrompt = new PromptGenerator();
                        thePrompt = myPrompt.GetRandomPrompt();
                        // Console.WriteLine(thePrompt);
                        Console.Write("> ");
                        myReply = Console.ReadLine();
                        Entry anEntry = new Entry(dateText, thePrompt, myReply);
                        theJournal.AddEntry(anEntry);
                        anEntry.Display();

                        break;
                    }
                    else
                    // inputFile exists
                    {
                        // Pass a single journal entry
                        PromptGenerator myPrompt = new PromptGenerator();
                        thePrompt = myPrompt.GetRandomPrompt();
                        // Console.WriteLine(thePrompt);
                        Console.Write("> ");
                        myReply = Console.ReadLine();


                        // If there are new journal entries, please store them in the file, too.
                        // Pass a single journal entry
                        Entry anEntry = new Entry(dateText, thePrompt, myReply);
                        // Return the journal entries from journal.txt
                        allJournalEntries = theJournal.LoadFromFile(inputFile);
                        // Add the journal entry to a list
                        theJournal.AddEntry(anEntry);
                        anEntry.Display();

                    }

                    continue;

                // 2. Display
                case "2":
                    // Console.WriteLine(">> Here's what your entries look so far for today...");
                    Console.WriteLine();
                    theJournal.DisplayAll();
                    break;
                // 3. Load
                case "3":

                    Console.WriteLine("What is the filename? ");
                    Console.Write("> ");
                    inputFile = Console.ReadLine();

                    Console.WriteLine();
                    Console.WriteLine(">> <Read your entries starting here...>");
                    Console.WriteLine();
                    if (File.Exists(inputFile))
                    {

                        allJournalEntries = theJournal.LoadFromFile(inputFile);
                    }
                    else
                    {
                        Console.WriteLine(">> Invalid or empty file!");
                        break;
                    }

                    Console.WriteLine($"{inputFile} contains:\n{allJournalEntries}");
                    Console.WriteLine(">> <...End of entries> ");
                    Console.WriteLine();
                    isLoaded = true;
                    break;
                // 4. Save
                case "4":
                    string myFileName = "";
                    Console.WriteLine("What is the filename? ");
                    Console.Write("> ");
                    myFileName = Console.ReadLine();

                    theJournal.SaveToFile(myFileName, allJournalEntries);
                    Console.WriteLine($">> Congrats! Your entries were saved to {myFileName}");
                    Console.WriteLine();

                    break;
                // 5. Quit
                case "5":
                    Console.WriteLine(">> Have a nice day!");
                    break;
                default:
                    Console.WriteLine("That's not part of the menu. Please select again.");
                    break;
            }
        } while (userChoice != "5"); // quit the program on select of Menu #5

    }



}

