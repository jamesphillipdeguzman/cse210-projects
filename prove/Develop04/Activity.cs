namespace Develop04;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;


    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public Activity()
    {

    }



    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\n.::Welcome to the  {_name}::.");
        Console.WriteLine($"\n- {_description}");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

    }

    public void DisplayEndingMessage()
    {

    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string>();
        for (int i = 0; i < _duration; i++)
        {
            if (i % 2 == 0)
            {
                spinner.Add(".");
                spinner.Add("..");
            }
            else
            {
                spinner.Add("...");
                spinner.Add("..");
                spinner.Add(".");
            }
        }

        foreach (string c in spinner)
        {
            Console.Write("Get ready");
            Console.Write(c);
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Clear();

        }

    }

    public void ShowCountdown(int seconds)
    {

    }
}
