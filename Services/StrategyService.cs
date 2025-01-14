using DesignPatternsWebApi.DesignPatterns.Strategy;

namespace DesignPatternsWebApi.Services;

public class StrategyService
{
    public double CalculateDiscount(string type, double price, double value)
    {
        IDiscountStrategy strategy = type.ToLower() switch
        {
            "percentage" => new PercentageDiscount(value),
            "fixed" => new FixedDiscount(value),
            _ => throw new ArgumentException("Invalid Discount Type")
        };

        DiscountContext context = new DiscountContext();
        context.SetStrategy(strategy);

        return context.ExecuteStrategy(price);
    }
}