using System.Net;

namespace Develop05;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    protected int _bonus;

    protected int _amountCompleted;

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
        if (_goals.Contains(":"))
        {
            string[] parts = _goals.Split(":");
            _goals = parts[0].Trim();
        }
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

    public virtual int GetDetailString5(int bonus)
    {
        return _bonus;
    }

    public virtual int GetDetailString6(int amountCompleted)
    {
        return _amountCompleted;
    }

    public abstract string GetStringRepresentation();

}
