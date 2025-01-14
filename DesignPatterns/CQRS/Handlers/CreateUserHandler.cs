using DesignPatternsWebApi.DesignPatterns.CQRS.Commands;
using MediatR;
using DesignPatternsWebApi.Services;

namespace DesignPatternsWebApi.DesignPatterns.CQRS.Handlers
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, bool>
    {
        private readonly CqrsService _userService;

        public CreateUserHandler(CqrsService userService)
        {
            _userService = userService;
        }

        public Task<bool> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            _userService.AddUser(request.UserName);
            return Task.FromResult(true);
        }
    }
}