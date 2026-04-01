using System.ComponentModel;

public abstract class Category
{
    protected string _name;

    protected string _description; 
    protected double _limitAmount;

    public Category(string name, string description, double limit)
    {
        _name = name;
        _description = description;
        _limitAmount = limit;

    }

    public abstract string GetCategoryDetails();
}