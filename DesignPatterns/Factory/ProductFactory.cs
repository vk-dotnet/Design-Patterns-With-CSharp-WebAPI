namespace DesignPatternsWebApi.DesignPatterns.Factory;

public class ProductFactory
{
    public static IProduct CreateProduct(string type)
    {
        return type switch
        {
            "A" => new ConcreteProductA(),
            "B" => new ConcreteProductB(),
            _ => throw new ArgumentException("Invalid Product Type")
        };
    }
}