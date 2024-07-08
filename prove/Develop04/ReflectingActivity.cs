using System.ComponentModel;
using System.Security.Cryptography;

namespace Develop04;

public class ReflectingActivity: Activity
{

    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration):base(name, description, duration)
    {
        DisplayStartingMessage();

    }

    public ReflectingActivity()
    {

    }


    public void Run()
    {
        base.ShowGetReady(_duration);
        PlayMusic();
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("When you have something in mind, press enter to continue.");
        // Let user enter something after pressing enter key...
        ConsoleKey key;
        var keyInfo = Console.ReadKey(intercept: false);
        key = keyInfo.Key;
        if (key == ConsoleKey.Enter)
        {
            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
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
            DisplayPrompt();
            ShowSpinner();
            DisplayQuestions();


        }
    }

    public string GetRandomPrompt()
    {
        List<string> _prompts = new List<string>();
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        // Get a random number to return from the prompt list
        Random randomPrompt = new Random();
        int randNum = randomPrompt.Next(0, _prompts.Count);

        string theRandomPrompt = $"Consider the following prompt\n ---- {_prompts[randNum]} ----\n";
        return theRandomPrompt;
    }

    public string GetRandomQuestion()
    {
        List<string> _questions = new List<string>();
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

        // Get a random number to return from the question list
        Random randomQuestion = new Random();
        int randNum = randomQuestion.Next(0, _questions.Count);

        string theRandomQuestion = $"> {_questions[randNum]} ----\n";
        ShowSpinner();
        return theRandomQuestion;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestions()
    {
        Console.WriteLine(GetRandomQuestion());

    }


}
