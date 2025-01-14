using DesignPatternsWebApi.DesignPatterns.Factory;

namespace DesignPatternsWebApi.Services;

public class FactoryService
{
    public IProduct GetProduct(string type)
    {
        return ProductFactory.CreateProduct(type);
    }
}