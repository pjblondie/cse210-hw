public class SpendingCategory : Category
{
    private double _currentSpent;

    public override string GetCategoryDetails()
    {
        return "";
    }
    
     public SpendingCategory(string name, string description, double limit) : base(name, description, limit)
    {

    }
}