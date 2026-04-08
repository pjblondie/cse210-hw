using System.ComponentModel;
using System.Dynamic;

public abstract class Category
{
    protected string _name;

    protected string _description;
    protected double _limitAmount;

    protected double _totalSpent = 0;

    public Category(string name, string description, double limit)
    {
        _name = name;
        _description = description;
        _limitAmount = limit;

    }

    public abstract string GetCategoryDetails();

    public string GetDescription()
    {
        return _description;
    }
    public string GetName()
    {
        return _name;
    }

    public double GetLimit()
    {
        return _limitAmount;
    }

    public void AddSpending(double amount)
    {
        _totalSpent += amount;
    }

    public double GetRemaining()
    {
        return _limitAmount - _totalSpent;
    }
    public double GetTotalSpent()
{
    return _totalSpent;
}
}