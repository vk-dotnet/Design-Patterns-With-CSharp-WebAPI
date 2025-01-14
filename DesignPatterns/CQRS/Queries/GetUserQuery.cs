using MediatR;

namespace DesignPatternsWebApi.DesignPatterns.CQRS.Queries
{
    public class GetUserQuery : IRequest<IEnumerable<string>> { }
}