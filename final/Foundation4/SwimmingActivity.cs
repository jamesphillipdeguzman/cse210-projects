namespace Foundation4;

public class SwimmingActivity : CyclingActivity
{
    private double _distance;
    private double _speed;
    private double _pace;

    public SwimmingActivity(string name, string date, int length, double distance, double speed, double pace) : base(name, date, length, distance, speed)
    {
        _name = name;
        _date = date;
        _length = length;
        _distance = distance;
        _speed = speed;
        _pace = pace;

    }

    public override string GetSummary(Activity activity)
    {
        return "";
    }
}
