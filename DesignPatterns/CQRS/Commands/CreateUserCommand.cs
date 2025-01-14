using MediatR;

namespace DesignPatternsWebApi.DesignPatterns.CQRS.Commands
{
    public class CreateUserCommand : IRequest<bool>
    {
        public string UserName { get; set; }
    }
}