namespace DesignPatternsWebApi.DesignPatterns.Strategy;

public class PercentageDiscount : IDiscountStrategy
{
    private readonly double _percentage;

    public PercentageDiscount(double percentage)
    {
        _percentage = percentage;
    }

    public double ApplyDiscount(double price)
    {
        return price * ((100 - _percentage) / 100);
    }
}