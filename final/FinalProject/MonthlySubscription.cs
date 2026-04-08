public class MonthlySubscription : Subscription
{
    public override double GetMonthlyCost()
    {
        return _price;
    }
    
    public MonthlySubscription(string name, double price, Category category) 
        : base(name, price, category) { }
}