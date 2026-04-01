public class SavingCategory : Category
{
    private string _currentSaved;

    public override string GetCategoryDetails()
    {
        return "";
    }

    public SavingCategory(string name, string description, double limit) : base(name, description, limit)
    {

    }
}