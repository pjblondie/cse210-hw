public class Expense
{
    private string _name;

    private double _amount;

    private DateTime _date;

    private Category _category;
    public Expense(string name, double amount, DateTime date, Category category)
    {
        _name = name;
        _amount = amount;
        _date = date;
        _category = category;
    }

    public string DisplayExpense()
    {
        return $"{_date.ToString("d")}: {_name} - ${_amount} [{_category.GetName()}]";
    }

    public string GetName()
    {
        return _name;
    }
    public DateTime GetDate()
    {
        return _date;
    }

    public double GetAmount()
    {
        return _amount;
    }

    public Category GetCategory()
    {
        return _category;
    }
}