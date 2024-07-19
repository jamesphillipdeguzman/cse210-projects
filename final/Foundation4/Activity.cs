using System.IO.Pipes;

namespace Foundation4;

public class Activity
{
    protected string _name;
    protected string _date;
    protected int _length;
    public Activity() {}
    public Activity(string name, string date, int length)
    {
        _name = name;
        _date = date;
        _length = length;
    }

    public virtual string GetSummary()
    {
        return "Please override this";
    }

    // Distance(km) = swimming laps * 50 / 1000
    // Speed(mph or kph) = (distance / minutes) * 60
    // Pace(min per mile or min per km)= minutes / distance
    // Speed = 60 / pace
    // Pace = 60 / speed

    public virtual double GetDistance(double laps)
    {
        // Console.WriteLine("Please override this");
        return 0;
    }

    public virtual double GetDistance(double speed, int minutes)
    {
        // Console.WriteLine("Please override this");
        return 0;
    }


    public virtual double GetSpeed(double _pace)
    {
        // Console.WriteLine("Please override this");
        return 0;
    }

    public virtual double GetPace(double _pace)
    {
        // Console.WriteLine("Please override this");
        return 0;
    }


    public virtual double GetSpeed(double distance, int minutes)
    {
        // Console.WriteLine("Please override this");
        return 0;
    }

    public virtual double GetPace(int minutes, double distance)
    {
        // Console.WriteLine("Please override this");
        return 0;
    }

}
