using System.ComponentModel;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
/// <summary>
/// Represents a goal that must be completed a specific number of times to earn a bonus.
/// </summary>
    public ChecklistGoal(int target, int bonus, string name, string description, int points) : base(name, description, points)
    {
        _amountCompleted = 0;

        _target = target;

        _bonus = bonus;
    }
    /// <summary>
    /// Checks if the goal has reached the required target number of completions.
    /// </summary>
    /// <returns> True if the amount completed is greater than or equal to the target.</returns>
    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            return _points + _bonus;
        }

        return _points;
    }
    /// <summary>
    /// Sets the current completion count to a specific value.
    /// </summary>
    /// <param name="amount">The number of times the goal has already been completed.</param>
    public void SetAmountCompleted(int amount)
    {
    _amountCompleted = amount;
    }
   /// <summary>
   /// Creates a formatted string of the goal's data for file storage.
   /// </summary>
   /// <returns>A string containing the goal type and all its current values.</returns>    
    public override string StringRep()
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_bonus},{_target},{_amountCompleted}"; ;
    }
    /// <summary>
    /// Determines if the goal has met the target number of completions.
    /// </summary>
    /// <returns>True if the goal is finished; otherwise, false.</returns>
    public override bool IsComplete()
    {
    
        return _amountCompleted >= _target;
    }
    /// <summary>
    /// Provides a description of the goal and the current completion progress.
    /// </summary>
    /// <returns> A string containing the goal's status, name, description, and count.</returns>
    public override string StringDetails()
    {
        return base.StringDetails() + $" Currently completed: {_amountCompleted}/{_target}";
    }
}   
