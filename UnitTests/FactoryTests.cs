using DesignPatternsWebApi.DesignPatterns.Factory;
using Xunit;

namespace DesignPatternsWebApi.UnitTests;

public class FactoryTests
{
    [Fact]
    public void CreateProduct_Should_Return_ProductA_When_Type_Is_A()
    {
        var product = ProductFactory.CreateProduct("A");

        Assert.NotNull(product);
        Assert.IsType<ConcreteProductA>(product);
        Assert.Equal("Product A", product.GetName());
    }

    [Fact]
    public void CreateProduct_Should_Return_ProductB_When_Type_Is_B()
    {
        var product = ProductFactory.CreateProduct("B");

        Assert.NotNull(product);
        Assert.IsType<ConcreteProductB>(product);
        Assert.Equal("Product B", product.GetName());
    }

    [Fact]
    public void CreateProduct_Should_Throw_Exception_For_Invalid_Type()
    {
        Assert.Throws<ArgumentException>(() => ProductFactory.CreateProduct("X"));
    }
}