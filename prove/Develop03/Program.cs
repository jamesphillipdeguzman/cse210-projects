using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using Develop03;

/* Author: James Phillip De Guzman
 * Program Title: Scripture Memorizer
 * Instructor: Brother Duane Richards
 * Date Completed: 7/3/2024
 * Creativity: 1) Menu created where a user can do 4 things:
 *               a) a - load all scriptures
 *               b) b - bak to menu
 *               c) l - loads a random scripture
 *               d) q - quite the program
 *               e) <enter> - press to hide words
 *             2) Random scriptures are loaded from the menu each time user presses 'l' or load.
 *                 Then they can press <enter> key to keep hiding the text from their chosen scripture.
 */
class Program
{
    static void Main(string[] args)
    {
        Console.Beep();
        Console.WriteLine("-------------------------------------");
        Console.WriteLine(".::Welcome to Scripture Memorizer!::.");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("\nIntructions: ");
        Console.WriteLine("\nYou may need to press the commands or letter twice to commit your choice: ");
        Console.WriteLine("a - loads all scriptures");
        Console.WriteLine("b - back to menu");
        Console.WriteLine("l - loads a random scripture");
        Console.WriteLine("q - quit the program");
        Console.WriteLine("<enter> - press to hide words\n");

        ConsoleKey key;
        Scripture scripture = new Scripture();

        do
        {
            DateTime currentDate = DateTime.Now;
            string filePath = "scriptures.csv";

            // Load the scriptures from scriptures.csv file

            Console.Write("> ");
            var keyInfo = Console.ReadKey(intercept: false);
            key = keyInfo.Key;
            switch (key)
            {

                case ConsoleKey.A:
                    Console.Beep();
                    scripture.animationSpinner();
                    Console.WriteLine("\n-------------------------------------");
                    Console.WriteLine($".::Welcome to Scripture Memorizer!::. " + currentDate);
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("\nIntructions: ");
                    Console.WriteLine("\nYou may need to press the commands or letter twice to commit your choice: ");
                    Console.WriteLine("a - loads all scriptures");
                    Console.WriteLine("b - back to menu");
                    Console.WriteLine("l - loads a random scripture");
                    Console.WriteLine("q - quit the program");
                    Console.WriteLine("<enter> - press to hide words\n");
                    Console.WriteLine(File.Exists(filePath) ? LoadFromFile() : "The file does not exist.");
                    break;
                case ConsoleKey.B:
                    Console.Beep();
                    scripture.animationSpinner();
                    Console.WriteLine("\n-------------------------------------");
                    Console.WriteLine($".::Welcome to Scripture Memorizer!::. " + currentDate);
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("\nIntructions: ");
                    Console.WriteLine("\nYou may need to press the commands or letter twice to commit your choice: ");
                    Console.WriteLine("a - loads all scriptures");
                    Console.WriteLine("b - back to menu");
                    Console.WriteLine("l - loads a random scripture");
                    Console.WriteLine("q - quit the program");
                    Console.WriteLine("<enter> - press to hide words\n");

                    break;
                case ConsoleKey.L:
                    Console.Beep();
                    scripture.animationSpinner();
                    ParseScripture();
                    break;

                case ConsoleKey.Q:
                    Console.Beep();
                    Console.WriteLine("\nBye!");
                    break;
                case ConsoleKey.Enter:
                    //Scripture scripture = new Scripture();
                    //scripture.HideRandomWords();
                    ParseScripture();

                    break;

                default:
                    Console.Beep();
                    Console.WriteLine("\nInvalid input!");
                    break;

            }


        } while (key != ConsoleKey.Q);



        static string ParseScripture()
        {
            Scripture scripture1 = new Scripture();
            string filePath = "scriptures.csv";
            int countRows = 0;
            string[] lines = System.IO.File.ReadAllLines(filePath);
            string fileContent = LoadFromFile();
            string refPart = "";
            string txtPart = "";
            string passage = "";
            string rangeVerse = "";
            string book = "";
            int chapter = 0;
            int verse = 0;
            int endVerse = 0;

            // Keep track of the scriptures to be shown at random when user pressed 'l' for load

            // Iterate through each row in the file
            try
            {
                // Count scriptures loaded
                foreach (string line in lines)
                {
                    countRows += 1;
                }
                int rndScripture = 0;
                string rndScriptureString = "";
                Random randScripture = new Random();
                // Catch an error here when only 1 scripture is loaded from file...
                if (lines.Length == 1)
                {
                    rndScripture = randScripture.Next(0);
                    rndScriptureString = lines[rndScripture];
                }
                else
                {
                    rndScripture = randScripture.Next(1, countRows);
                    rndScriptureString = lines[rndScripture];
                }


                // Split into 2 parts, reference (refPart) and text part (txtPart)
                string[] parts = rndScriptureString.Split(" | ");

                refPart = parts[0];
                // Handle extra "\" in front of the refPart
                if (refPart.Contains("\""))
                {
                    string[] refinedRefPart = refPart.Split("\"");
                    refPart = refinedRefPart[1].Trim();
                    txtPart = parts[1];
                    string[] refinedtxtPart = txtPart.Split("\"");
                    txtPart = refinedtxtPart[0].Trim();
                }
                else
                {
                    refPart = parts[0].Trim();
                    txtPart = parts[1].Trim();
                }



                // Split further by space to get the book name and passage (the verse parts)
                string[] bookPart = refPart.Split(" ");
                book = bookPart[0];
                passage = bookPart[1];

                // Split using colon as delimeter to get the range verse (endVerse if there's any)
                string[] chapterPart = passage.Split(":");
                chapter = int.Parse(chapterPart[0]);
                rangeVerse = chapterPart[1];
                string[] versePart = rangeVerse.Split("-");


                // Check if row has dash (-) to determine if has rangeVerse
                if (passage.Contains("-"))
                {
                    // rangeVerse found
                    verse = int.Parse(versePart[0]);
                    endVerse = int.Parse(versePart[1]);
                }
                else
                {
                    // Only single verse found
                    endVerse = 0;
                    verse = int.Parse(versePart[0]);

                }

                if (endVerse != 0)
                {
                    Reference reference = new Reference(book, chapter, verse, endVerse);
                    scripture1.animationSpinner();
                    Console.WriteLine(reference.GetDisplayText());
                    Word word = new Word(txtPart, true);
                    List<Word> words = new List<Word>();
                    words.Add(word);

                    Scripture scripture = new Scripture(reference, words);
                    scripture.GetDisplayText(reference.GetDisplayText(), word);


                }
                else
                {

                    Reference reference = new Reference(book, chapter, verse);
                    scripture1.animationSpinner();
                    Console.Write(reference.GetDisplayText());
                    // Create a word object where you can pass in a string text and bool true/false value
                    Word word = new Word(txtPart, true);
                    // Put the word you created in a collection called 'words'.
                    List<Word> words = new List<Word>();
                    words.Add(word);

                    // Put the reference you created from above and the collection of words in the scripture object
                    Scripture scripture = new Scripture(reference, words);
                    scripture.GetDisplayText(reference.GetDisplayText(), word);

                }

                // Get random indexfor the scriptureBank
                int indScripture = Randomizer(countRows);
                if (countRows == 1) indScripture = 0; // for single scripture saved in scriptures.csv

                return "";

            }

            catch (Exception e)
            {
                Console.WriteLine($"An error occured {e.Message}");
            }

            return "";

        }

    }

    // Get a random number
    static int Randomizer(int ctr)
    {
        Random randNum = new Random();
        int randScripture = randNum.Next(1, ctr);
        return randScripture;
    }

    // Load the file
    static string LoadFromFile()
    {
        string fileName = "scriptures.csv";
        int ctr = 0;
        string[] lines = System.IO.File.ReadAllLines(fileName);
        string fileContent = System.IO.File.ReadAllText(fileName);

        try
        {
            if (lines.Length == 0)
            {
                Console.WriteLine("The file is empty");
            }

        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occured {e.Message}");
        }

        // Count scriptures loaded
        foreach (string line in lines)
        {
            ctr += 1;
        }
        Console.WriteLine($"\n>>{ctr} scriptures loaded from {fileName}. \nPress <enter> to enter prompt or continue to press <enter> key again to start Scripture Memorizer game... Enjoy! =) \n");

        return fileContent;

    }

}

