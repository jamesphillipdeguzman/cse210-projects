namespace Foundation4;

public class RunningActivity : Activity
{
    private double _distance;
    // private double _speed;
    // private double _pace;

    public RunningActivity(string name, string date, int length, double distance) : base(name, date, length)
    {
        _name = name;
        _date = date;
        _length = length;
        _distance = distance;
        //_speed = speed;
        //_pace = pace;

    }

    public override string GetSummary(Activity activity)
    {
        return "";
    }
}
