public class EternalGoal : Goal
{
    /// <summary>
    /// Initializes an eternal goal with a name, description, and point value.
    /// </summary>
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }
    /// <summary>
    /// Records an entry for the eternal goal and returns the associated points.
    /// </summary>
    /// <returns>The points earned for this specific instance of the activity.</returns>
    public override int RecordEvent()
    {
        return _points;
    }

    /// <summary>
    /// Formats the eternal goal's data into a string for saving to a file.
    /// </summary>
    /// <returns>A formatted string indicating the type and attributes of the eternal goal.</returns>
    public override string StringRep()
    {
        return $"EternalGoal:{_name},{_description},{_points},false";
    }
}