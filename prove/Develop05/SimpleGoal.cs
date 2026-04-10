using System.Runtime.CompilerServices;

public class SimpleGoal : Goal
{
    private bool _isComplete;
    /// <summary>
    /// Initializes a new simple goal and sets its completion status to false.
    /// </summary>
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
    /// <summary>
    /// Marks the goal as finished and returns the points awarded for completion.
    /// </summary>
    /// <returns>The point value of the goal.</returns>
    public override int RecordEvent()
    {
        _isComplete = true;

        return _points;
    }
    /// <summary>
    /// Manually sets the completion status, primarily used when loading saved data.
    /// </summary>
    /// <param name="isComplete">The status to set the goal to (true or false).</param>
    public void SetComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }
    /// <summary>
    /// Returns the current completion status of the simple goal.
    /// </summary>
    /// <returns>True if the goal has been recorded; otherwise, false.</returns>
    public override bool IsComplete()
    {
        return _isComplete;
    }  
    /// <summary>
    /// Formats the simple goal's data into a string for storage in a text file.
    /// </summary>
    /// <returns>A string containing the goal type, name, description, points, and completion status.</returns>
    public override string StringRep()
    {
        return $"SimpleGoal:{_name},{_description},{_points},{_isComplete}";
    }
}


