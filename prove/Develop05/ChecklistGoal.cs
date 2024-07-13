using System.Runtime.CompilerServices;

namespace Develop05;
// This class needs to track the number of times it has been completed, the target number of times the user is striving for, and the bonus for achieving that target.
public class ChecklistGoal : Goal
{
    private int _target;


    public ChecklistGoal(string goals, string name, string description, int points, int bonus, int target, int amountCompleted) : base(goals, name, description, points)
    {
        _points = points;
        _bonus = bonus;
        _target = target;
        _amountCompleted = amountCompleted;
    }

    public ChecklistGoal(){}

    // This method should do whatever is necessary for each specific kind of goal, such as adding to the number of times
    // a checklist goal has been completed. It should return the point value associated with recording the event
    // Keep in mind that it may contain a bonus in some cases if a checklist goal was just finished.
    public override int RecordEvent(Goal goal)
    {
        // return ChecklistGoal points
        return _points;
    }

    // This method should return true if the goal is completed. The way you determine if a goal is complete is different for each type of goal.
    public override bool IsComplete(bool status)
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    // This method should return the details of a goal that could be shown in a list. It should include the checkbox,
    // the short name, and description. Then in the case of the ChecklistGoal class, it should be overridden to shown
    //the number of times the goal has been accomplished so far.
    public override string GetDetailString4(bool IsComplete, int amountCompleted, int bonus)
    {
        _amountCompleted = amountCompleted;
        // Checklist goal was not completed yet
        if (IsComplete == false && _amountCompleted != _target)
        {
            return $"[ ] {_shortName} ({_description}) -- Currently completed {_amountCompleted}/{_target}";
        }
        // Target goal was reached and completed
        else
        {
            return $"[X] {_shortName} ({_description}) -- Currently completed {_amountCompleted}/{_target}";

        }

    }

    public override int GetDetailString5(int bonus)
    {

        return _bonus;
    }

    public override int GetDetailString6(int amountCompleted)
    {
        if(amountCompleted > 0) {
            _amountCompleted = amountCompleted;
            return _amountCompleted;
        }
        else
        {
            return _amountCompleted;
        }

    }
    // This method should provide all of the details of a goal in a way that is easy to save to a file, and then load later.
    public override string GetStringRepresentation()  // Checklist Goal
    {
        // Check if the goal name was previously saved to goals.txt.
        // If yes, remove the colon because the GetStringRepresentation will add it instead.
        if (_goals.Contains(":"))
        {
            string[] parts = _goals.Split(":");
            _goals = parts[0].Trim();
        }
        return $"{_goals}: | {_shortName} | {_description} | {_points} | {_bonus} | {_target} | {_amountCompleted}";
    }
}
