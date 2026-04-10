using System.ComponentModel;
using System.Net.NetworkInformation;

public abstract class Goal
{
    protected string _name;
    protected string _description;

    protected int _points;
    /// <summary>
    /// Sets up a goal with its basic name, description, and point value.
    /// </summary>
        public Goal(string name, string description, int points)
    {
        _name = name;

        _description = description;

        _points = points;

    }
    /// <summary>
    /// Returns the name of the goal.
    /// </summary>
    public string GetName()
    {
        return _name;
    }
    /// <summary>
    /// When overridden, handles the logic for finishing or progressing in a goal.
    /// </summary>
    /// <returns>The number of points earned for the event.</returns>
    public abstract int RecordEvent();
    /// <summary>
    /// Indicates whether the goal has been finished. Defaults to false for eternal goals.
    /// </summary>
    public virtual bool IsComplete()
    {
        return false;
    }
    /// <summary>
    /// Returns a string showing the completion status, name, and description for the user.
    /// </summary>
    public virtual string StringDetails()
    {
        string checkMark;
        if (IsComplete())
        {
            checkMark = "X";
        }
        else
        {
            checkMark = " ";
        }
        return $"[{checkMark}] {_name} ({_description})";;
    }
    /// <summary>
    /// When overridden, provides a machine-readable string for saving to a file.
    /// </summary>
    public abstract string StringRep();


}