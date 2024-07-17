namespace Foundation4;

public class CyclingActivity : RunningActivity
{
    private double _distance;
    private double _speed;
    private double _pace;

    public CyclingActivity(string name, string date, int length, double distance, double speed) : base(name, date, length, distance)
    {
        _name = name;
        _date = date;
        _length = length;
        _distance = distance;
        _speed = speed;
        //_pace = pace;

    }

    public override string GetSummary(Activity activity)
    {
        return "";
    }
}
