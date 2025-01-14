using DesignPatternsWebApi.DesignPatterns.Repository;
using Xunit;

namespace DesignPatternsWebApi.UnitTests;

public class RepositoryTests
{
    [Fact]
    public void UserRepository_Should_Add_And_Retrieve_Users()
    {
        var repository = new UserRepository();

        repository.Add("Alice");
        repository.Add("Bob");

        var users = repository.GetAll();

        Assert.Contains("Alice", users);
        Assert.Contains("Bob", users);
    }
}