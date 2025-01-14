using DesignPatternsWebApi.DesignPatterns.Strategy;
using Xunit;

namespace DesignPatternsWebApi.UnitTests;

public class StrategyTests
{
    [Fact]
    public void PercentageDiscount_Should_Calculate_Correctly()
    {
        var strategy = new PercentageDiscount(10); // %10 indirim
        var discountedPrice = strategy.ApplyDiscount(100);

        Assert.Equal(90, discountedPrice);
    }

    [Fact]
    public void FixedDiscount_Should_Calculate_Correctly()
    {
        var strategy = new FixedDiscount(20); // 20 TL indirim
        var discountedPrice = strategy.ApplyDiscount(100);

        Assert.Equal(80, discountedPrice);
    }

    [Fact]
    public void FixedDiscount_Should_Not_Go_Below_Zero()
    {
        var strategy = new FixedDiscount(200);
        var discountedPrice = strategy.ApplyDiscount(100);

        Assert.Equal(0, discountedPrice);
    }
}