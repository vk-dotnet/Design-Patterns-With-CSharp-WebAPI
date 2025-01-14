namespace DesignPatternsWebApi.DesignPatterns.Factory;

public class ConcreteProductA : IProduct
{
    public string GetName() => "Product A";
}

public class ConcreteProductB : IProduct
{
    public string GetName() => "Product B";
}