using System;
using Develop05;
using System.IO;

/* Author: James Phillip K. De Guzman
 * Programming Language: C Sharp or C#
 * Instructor: Brother Duane Richards
 * Date Started: June 10, 2024
 * Date Finished: June 13, 2024
 * Testing: Did a huge amount of it...was tiring, but I really learned something :)

*/

/* Creativity and Exceeding Core Requirements:
 * 1) Added a goals.txt checker (if the file exists).
 * 2) Added number of characters the journal entries has stored.
 * 3) Implemented some error trapping for incorrect user inputs.
 * 4) Performed checks if journal.csv exists and whether it has contents.
 */
class Program
{
    static void Main(string[] args)
    {
        string inputFile = "goals.txt";
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
                    Console.WriteLine($">> {inputFile} file exists and has contents. \n\nIMPORTANT! Ideally, you must load the goals.txt before you can use this program.");
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
            Console.WriteLine(">> Goal file was not found.");

        }
        // Show the welcome screen for the Journal C# program
        Console.WriteLine();
        Console.WriteLine("--------------------------------------- ");
        Console.WriteLine(".::Welcome to the Eternal Quest Program!::. " + dateText);
        Console.WriteLine("--------------------------------------- ");
        Console.WriteLine();

        GoalManager goalManager = new GoalManager();

        // Start the program here...
        goalManager.Start();
    }
}
