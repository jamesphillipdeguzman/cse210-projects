namespace Develop05;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    protected string _goals;

    public Goal(string goals, string name, string description, int points)
    {
        _goals = goals;
        _shortName = name;
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
