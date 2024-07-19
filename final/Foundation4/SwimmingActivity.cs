using Microsoft.VisualBasic;

namespace Foundation4;

public class SwimmingActivity : Activity
{
    private double _distance;
    private double _speed;
    private double _pace;

    private double _laps;

    public SwimmingActivity(string name, string date, int length, double laps) : base(name, date, length)
    {
        _name = name;
        _date = date;
        _length = length;
        // _distance = distance;
        //_speed = speed;
        // _pace = pace;

    }

    public override double GetDistance(double laps)
    {
        //Distance (km) = swimming laps * 50 / 1000
        double swimDistance = (laps * 50) /1000;
        _distance = swimDistance;

        return _distance;
    }

    public override double GetSpeed(double distance, int minutes)
    {
        _distance = distance;
        _length = minutes;
        _speed = (_distance / _length) * 60;
        return _speed;
    }

    public override string GetSummary()
    {
        return $"{_date} {_name} ({_length} min)-Distance: {_distance} km, Speed: {_speed} km";
    }
}
