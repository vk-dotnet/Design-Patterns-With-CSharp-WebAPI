using MediatR;
using DesignPatternsWebApi.Services;
using DesignPatternsWebApi.DesignPatterns.CQRS.Queries;

namespace DesignPatternsWebApi.DesignPatterns.CQRS.Handlers
{
    public class GetUserHandler : IRequestHandler<GetUserQuery, IEnumerable<string>>
    {
        private readonly CqrsService _userService;

        public GetUserHandler(CqrsService userService)
        {
            _userService = userService;
        }

        public Task<IEnumerable<string>> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_userService.GetUsers());
        }
    }
}