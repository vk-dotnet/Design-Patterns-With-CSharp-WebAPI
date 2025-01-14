namespace DesignPatternsWebApi.DesignPatterns.Strategy;

public class FixedDiscount : IDiscountStrategy
{
    private readonly double _discountAmount;

    public FixedDiscount(double discountAmount)
    {
        _discountAmount = discountAmount;
    }

    public double ApplyDiscount(double price)
    {
        return price - _discountAmount > 0 ? price - _discountAmount : 0;
    }
}