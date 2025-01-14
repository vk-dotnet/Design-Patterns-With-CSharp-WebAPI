namespace DesignPatternsWebApi.DesignPatterns.Strategy;

public interface IDiscountStrategy
{
    double ApplyDiscount(double price);
}