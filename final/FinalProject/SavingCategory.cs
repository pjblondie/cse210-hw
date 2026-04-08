public class SavingCategory : Category
{
    private string _currentSaved;

    public override string GetCategoryDetails()
    {
        if (GetRemaining() <= 0) return "You reached your Savings goal! Keep it up";
    return "Still Saving";;
    }

    public SavingCategory(string name, string description, double limit) : base(name, description, limit)
    {

    }
}