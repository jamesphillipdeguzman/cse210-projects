using System.Diagnostics.Contracts;

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
        // 

        int j = _duration/5;
            List<string> listFromUser = new List<string>();
            do
            {
                Console.Write("> ");

                string userInput = Console.ReadLine();
                listFromUser.Add(userInput);

                j--;
            } while (j != 0);
            GetListFromUser(listFromUser);

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

    }

    public string GetListFromUser(List<string> prompts)
    {
        List<string> _prompts = new List<string>();
        _prompts = prompts;
        return "";
    }
}
