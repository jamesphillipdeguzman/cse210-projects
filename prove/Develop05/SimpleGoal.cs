namespace Develop05;
// This class needs to track when the simple goal is complete.
public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string goals, string name, string description, int points): base(goals, name, description, points)
    {
        _shortName = name;
        _points = points;

    }

    public SimpleGoal(){}
    // This method should do whatever is necessary for each specific kind of goal, such as marking a simple goal complete.
    // It should return the point value associated with recording the event
    public override int RecordEvent(Goal goal)
    {
        int points = int.Parse(goal.GetDetailString3());

        // return SimpleGoal points
        return points;

    }

    // This method should return true if the goal is completed. The way you determine if a goal is complete is different for each type of goal.
    public override bool IsComplete(bool status)
    {
        _isComplete = status;
        return _isComplete;
    }

    // This method should provide all of the details of a goal in a way that is easy to save to a file, and then load later.
    public override string GetStringRepresentation() // Simple Goal
    {
        // Check if the goal name was previously saved to goals.txt.
        // If yes, remove the colon because the GetStringRepresentation will add it instead.
        if(_goals.Contains(":"))
        {
            string[] parts = _goals.Split(":");
            _goals = parts[0].Trim();
        }
        return $"{_goals}: | {_shortName} | {_description} | {_points} | {_isComplete}";
    }


}
