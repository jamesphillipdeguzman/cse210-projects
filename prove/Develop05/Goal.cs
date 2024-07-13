using System.Net;

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
    public Goal(){}

    public abstract int RecordEvent(Goal goal);


    public abstract bool IsComplete(bool _isComplete);


    public virtual string GetDetailString(bool _isComplete)
    {
        // Goal was not completed
        if (_isComplete == false)
        {
            return $"[ ] {_shortName} ({_description})";
        }
        // Show that goal was completed
        else
        {
            return $"[X] {_shortName} ({_description})";
        }

    }


    public virtual string GetDetailString2()
    {
        return $"{_goals} {_shortName} - {_points}";
    }

    public virtual string GetDetailString3()
    {
        return $"{_points}";
    }

    public virtual string GetDetailString4(bool _isComplete, int _amountCompleted, int bonus)
    {
        if (_isComplete == false)
        {
            return $"[ ] {_shortName} ({_description})";
        }
        else
        {
            return $"[X] {_shortName} ({_description})";
        }

    }



    public abstract string GetStringRepresentation();

}
