using MediatR;
using Microsoft.AspNetCore.Mvc;
using DesignPatternsWebApi.DesignPatterns.CQRS.Commands;
using DesignPatternsWebApi.DesignPatterns.CQRS.Queries;

namespace DesignPatternsWebApi.Controllers
{
    [ApiController]
    [Route("api/cqrs")]
    public class CqrsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CqrsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddUser([FromQuery] string username)
        {
            var command = new CreateUserCommand { UserName = username };
            await _mediator.Send(command);
            return Ok(new { Message = "User added successfully", Username = username });
        }

        [HttpGet("users")]
        public async Task<IActionResult> GetUsers()
        {
            var query = new GetUserQuery();
            var users = await _mediator.Send(query);
            return Ok(users);
        }
    }
}