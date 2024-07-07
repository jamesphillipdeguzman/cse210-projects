using System.ComponentModel;

namespace Develop04;

public class ReflectingActivity: Activity
{

    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration):base(name, description, duration)
    {
        // Console.WriteLine($"\nWelcome to the {name}");
        // Console.WriteLine($"\n{description}");
        // Console.Write("How long, in seconds, would you like for your session? ");
        // duration = int.Parse(Console.ReadLine());
        DisplayStartingMessage();
        Run();
    }

    public ReflectingActivity()
    {

    }


    public void Run()
    {
        base.ShowSpinner(_duration);
    }

    public string GetRandomPrompt()
    {
        return "";
    }

    public string GetRandomQuestion()
    {
        return "";
    }

    public void DisplayPrompt()
    {

    }

    public void DisplayQuestions()
    {

    }


}
