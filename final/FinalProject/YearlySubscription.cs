public class YearlySubscription : Subscription
{

    public YearlySubscription(string name, double price, Category category) 
        : base(name, price, category) { }
    public override double GetMonthlyCost()
    {
        return _price/12;
    }
    
    
}