using Xunit;
using DesignPatternsWebApi.DesignPatterns.CQRS.Commands;
using DesignPatternsWebApi.DesignPatterns.CQRS.Queries;
using DesignPatternsWebApi.DesignPatterns.CQRS.Handlers;
using DesignPatternsWebApi.Services;

namespace DesignPatternsWebApi.UnitTests
{
    public class CqrsTests
    {
        [Fact]
        public async Task CreateUserCommand_Should_Add_User()
        {
            var userService = new CqrsService();
            var handler = new CreateUserHandler(userService);

            var command = new CreateUserCommand { UserName = "TestUser" };
            var result = await handler.Handle(command, CancellationToken.None);

            Assert.True(result);
            Assert.Contains("TestUser", userService.GetUsers());
        }

        [Fact]
        public async Task GetUserQuery_Should_Return_Users()
        {
            var userService = new CqrsService();
            userService.AddUser("Alice");
            userService.AddUser("Bob");

            var handler = new GetUserHandler(userService);
            var result = await handler.Handle(new GetUserQuery(), CancellationToken.None);

            Assert.Contains("Alice", result);
            Assert.Contains("Bob", result);
        }
    }
}