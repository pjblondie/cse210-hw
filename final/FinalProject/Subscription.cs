public abstract class Subscription
{
    protected string _name;

    protected double _price;

    protected Category _category;
    public Subscription(string name, double price, Category category)
    {
        _name = name;
        _price = price;
        _category = category;
    }

    public abstract double GetMonthlyCost();

    public string GetName()
    {
        return _name;
    }

    public double GetPrice()
    {
        return _price;
    }

    public Category GetCategory()
    {
        return _category;
    }
}