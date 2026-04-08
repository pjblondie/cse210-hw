public class SpendingCategory : Category
{
    private double _currentSpent;

    public override string GetCategoryDetails()
    {
        if (GetRemaining() < 0) return "Over Budget, Limit Spending";
        return "Under Budget, keep up the good work";;
    }
    
     public SpendingCategory(string name, string description, double limit) : base(name, description, limit)
    {

    }
}