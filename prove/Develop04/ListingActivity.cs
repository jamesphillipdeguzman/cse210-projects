using System;
using System.Collections.Generic;
using System.IO;

namespace Develop04;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration):base(name, description, duration)
    {
        DisplayStartingMessage();

    }

    public ListingActivity()
    {

    }


    public void Run()
    {
        base.ShowGetReady(_duration);
        PlayMusic();


            int i = 5;
            do
            {
                Console.Clear();
                Console.Write($"You may begin in: {i}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
                i--;

            } while (i != 0);

            Console.Clear();
        GetRandomPrompt();


    }

    public void GetRandomPrompt()
    {
        List<string> _prompts = new List<string>();
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        // Get a random number to return from the prompt list
        Random randomPrompt = new Random();
        int randNum = randomPrompt.Next(0, _prompts.Count);

        string theRandomPrompt = $"List as many responses you can to the following prompt: \n ---- {_prompts[randNum]} ----\n";
        Console.WriteLine(theRandomPrompt);
        GetListFromUser(_prompts[randNum]);

    }

    public string GetListFromUser(string thePrompt)
    {
        int j = _duration / 5;
        List<string> listFromUser = new List<string>();
        do
        {
            Console.Write("> ");

            string userInput = Console.ReadLine();
            listFromUser.Add(userInput);

            j--;
        } while (j != 0);

        string allList = "";
        _prompts = listFromUser;
        foreach (string prompt in _prompts)
        {
            allList += prompt + " | ";
        }

        // Add date and time
        DateTime currentDate = DateTime.Now;
        string dateText = currentDate.ToShortDateString();
        string allListEntry = thePrompt + " | " + dateText + " | " + allList;
        Console.WriteLine("Your entry was saved!");

        SaveToFile("listing.csv", allListEntry);
        return allListEntry;
    }

    // Auto save my listing entries to listing.csv
    public void SaveToFile(string fileName, string myList)
    {
        if (myList.Length != 0)
        {
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    // Save my journal entries in a text file.

                    writer.WriteLine($"{myList.Trim()}");

                }
            }
        }

    }

    public string LoadFromFile(string fileName)
    {

        // Check if file name is not empty
        if (fileName != "")
        {

            // load default filename if empty to avoid error
            fileName = "listing.csv";
            string[] lines = System.IO.File.ReadAllLines(fileName);
            // Read the contents only
            string fileContent = File.ReadAllText(fileName);
            if (fileContent.Length != 0)
            {

            }
            string[] theFileCleaned = fileContent.Split("\"");
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(theFileCleaned[i]);
            }
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
                string[] theFileCleaned = fileContent.Split("\"");
                for (int i=0; i<lines.Length; i++)
                {
                    Console.WriteLine(theFileCleaned[i]);
                }

            }

            return "";
        }
    }


}

