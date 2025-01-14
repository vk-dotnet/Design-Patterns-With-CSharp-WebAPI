using DesignPatternsWebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatternsWebApi.Controllers
{
    [ApiController]
    [Route("api/repository")]
    public class RepositoryController : ControllerBase
    {
        private readonly UserService _userService;

        public RepositoryController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost("add")]
        public IActionResult AddUser([FromQuery] string username)
        {
            _userService.AddUser(username);
            return Ok(new { Message = "User added successfully", Username = username });
        }

        [HttpGet("users")]
        public IActionResult GetUsers()
        {
            var users = _userService.GetUsers();
            return Ok(users);
        }
    }
}