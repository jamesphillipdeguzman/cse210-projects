namespace Develop05;

public abstract class Goal
{
    private string _shortname;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortname = name;
        _description = description;
        _points = points;

    }

    public abstract void RecordEvent();


    public abstract bool IsComplete();


    public virtual string GetDetailString()
    {
        return "";
    }

    public abstract string GetStringRepresentation();

}
