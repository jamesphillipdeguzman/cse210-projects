namespace Foundation4;

public class Activity
{
    protected string _name;
    protected string _date;
    protected int _length;

    public Activity(string name, string date, int length)
    {
        _name = name;
        _date = date;
        _length = length;
    }

    public virtual string GetSummary(Activity activity)
    {
        return "";
    }

}
