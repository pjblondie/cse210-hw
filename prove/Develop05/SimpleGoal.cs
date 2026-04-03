using System.Runtime.CompilerServices;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
    public override int RecordEvent()
    {
        _isComplete = true;

        return _points;
    }

    public void SetComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }  

    public override string StringRep()
    {
        return $"SimpleGoal:{_name},{_description},{_points},{_isComplete}";
    }
}


