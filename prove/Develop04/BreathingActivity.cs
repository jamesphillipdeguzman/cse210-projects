namespace Develop04;

public class BreathingActivity : Activity
{

    public BreathingActivity(string name, string description, int duration):base(name, description, duration)
    {
        DisplayStartingMessage();

    }

    public BreathingActivity()
    {

    }


    public void Run()
    {
        base.ShowGetReady(_duration);
        PlayMusic();
        base.ShowCountdown(_duration);
    }


}
