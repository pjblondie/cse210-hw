using System.ComponentModel;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(int target, int bonus, string name, string description, int points) : base(name, description, points)
    {
        _amountCompleted = 0;

        _target = target;

        _bonus = bonus;
    }
    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
    {
        return _points + _bonus; 
    }
    
        return _points;
    }

    public void SetAmountCompleted(int amount)
    {
    _amountCompleted = amount;
    }

    public override string StringRep()
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_bonus},{_target},{_amountCompleted}"; ;
    }

    public override bool IsComplete()
    {
    
        return _amountCompleted >= _target;
    }
    public override string StringDetails()
    {
        return base.StringDetails() + $" Currently completed: {_amountCompleted}/{_target}";
    }
}   
