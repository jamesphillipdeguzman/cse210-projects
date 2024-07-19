

namespace Foundation4;

public class CyclingActivity : Activity
{
    // private double _distance;
    private double _speed;
    private double _pace;

    public CyclingActivity() {}
    public CyclingActivity(string name, string date, int length, double pace) : base(name, date, length)
    {
        _name = name;
        _date = date;
        _length = length;
        // _distance = distance;
        _pace = pace;

    // Speed = 60 / pace
    // Pace = 60 / speed

    }


    public override double GetSpeed(double _pace)
    {
        _speed = 60 / _pace;
        return _speed;
    }

    public override double GetPace(double _speed)
    {
        _pace = 60 / _speed;
        return _pace;
    }

    public override double GetDistance(double speed, int length)
    {
        double _distance = (speed / length) * 60;
        return _distance;
    }

    public override string GetSummary()
    {
        return $"{_date} {_name} ({_length} min)-Speed: {_speed} kph, Pace: {_pace} min per km";
    }

}
