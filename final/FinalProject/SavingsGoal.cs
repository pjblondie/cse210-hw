public class SavingsGoal
{
    private string _goalName;
    private string _promptText;
    private string _userResponse;
    private bool _isAchieved;

    public SavingsGoal(string name, string prompt)
    {
        _goalName = name;
        _promptText = prompt;
        _isAchieved = false;
    }

    public void AskGoal()
    {
        Console.WriteLine("Your Goal is: ");
        Console.WriteLine($"Goal: {_goalName}");
        Console.Write($"{_promptText} ");
        _userResponse = Console.ReadLine();
    }

    public void MarkAsAchieved()
    {
        _isAchieved = true;
        Console.WriteLine($"Congratulations! Goal '{_goalName}' has been achieved!");
    }

    public string GetGoalSummary()
    {
        string status = _isAchieved ? "[Achieved]" : "[In Progress]";
        return $"{status} {_goalName}: {_userResponse}";
    }

    public string GetGoalName()
    {
        return _goalName;
    }

    public string GetPromptText()
    {
        return _promptText;
    }

    public string GetUserResponse()
    {
        return _userResponse;
    }

    public bool GetIsAchieved()
    {
        return _isAchieved;
    }
    public void SetLoadedData(string response, bool achieved)
    {
        _userResponse = response;
        _isAchieved = achieved;
    }
}