namespace Foundation4;

public class RunningActivity : Activity
{
    private double _distance;
    private double _speed;
    private double _pace;

    public RunningActivity(string name, string date, int length, double distance) : base(name, date, length)
    {
        _name = name;
        _date = date;
        _length = length;
        _distance = distance;

    }

    public override string GetSummary()
    {
        return $"{_date} {_name} ({_length} min)-Distance {_distance} km, Speed: {_speed} kph, Pace: {_pace} min per km";
    }

    public override double GetSpeed(double distance, int minutes)
    {
        _speed = (distance / minutes) * 60;
        return _speed;
    }

    public override double GetPace(int minutes, double distance)
    {
        _pace = minutes / distance;
        return _pace;
    }
}
