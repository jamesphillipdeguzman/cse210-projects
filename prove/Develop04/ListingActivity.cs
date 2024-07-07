using System.Diagnostics.Contracts;

namespace Develop04;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration):base(name, description, duration)
    {
        // Console.WriteLine($"\nWelcome to the {name}");
        // Console.WriteLine($"\n{description}");
        // Console.Write("How long, in seconds, would you like for your session? ");
        // duration = int.Parse(Console.ReadLine());
        DisplayStartingMessage();
        Run();
    }

    public ListingActivity()
    {

    }


    public void Run()
    {
        base.ShowSpinner(_duration);
    }

    public void GetRandomPrompt()
    {

    }

    public string GetListFromUser(List<string> prompts)
    {
        List<string> _prompts = new List<string>();
        _prompts = prompts;
        return "";
    }
}
