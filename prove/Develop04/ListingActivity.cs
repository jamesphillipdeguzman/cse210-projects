using System.Diagnostics.Contracts;

namespace Develop04;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration):base(name, description, duration)
    {

    }

    public void Run()
    {

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
