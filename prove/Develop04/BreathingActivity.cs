namespace Develop04;

public class BreathingActivity : Activity
{

    public BreathingActivity(string name, string description, int duration):base(name, description, duration)
    {
        // Console.WriteLine($"\nWelcome to the {name}");
        // Console.WriteLine($"\n{description}");
        // Console.Write("How long, in seconds, would you like for your session? ");
        // duration = int.Parse(Console.ReadLine());
        DisplayStartingMessage();
        Run();
    }

    public BreathingActivity()
    {

    }


    public void Run()
    {

        base.ShowSpinner(_duration);



        // Console.WriteLine("The duration is " + duration);

    }
}
