namespace DesignPatternsWebApi.DesignPatterns.Strategy;
public class DiscountContext
{
    private IDiscountStrategy _strategy;

    public void SetStrategy(IDiscountStrategy strategy)
    {
        _strategy = strategy;
    }

    public double ExecuteStrategy(double price)
    {
        return _strategy.ApplyDiscount(price);
    }
}
