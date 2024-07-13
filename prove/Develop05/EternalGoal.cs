namespace Develop05;

public class EternalGoal : Goal
{
    public EternalGoal(string goals, string name, string description, int points) : base(goals, name, description, points)
    {

    }

    public EternalGoal(){}
    // This method should return the point value associated with recording the event
    public override int RecordEvent(Goal goal)
    {
        // return EternalGoal points
        return _points;
    }

    // This method should return true if the goal is completed. The way you determine if a goal is complete is different for each type of goal.
    public override bool IsComplete(bool status)
    {
        return false;
    }

    // This method should provide all of the details of a goal in a way that is easy to save to a file, and then load later.
    public override string GetStringRepresentation() // Eternal Goal
    {
        // Check if the goal name was previously saved to goals.txt.
        // If yes, remove the colon because the GetStringRepresentation will add it instead.
        if (_goals.Contains(":"))
        {
            string[] parts = _goals.Split(":");
            _goals = parts[0].Trim();
        }
        return $"{_goals}: | {_shortName} | {_description} | {_points}";
    }

}
