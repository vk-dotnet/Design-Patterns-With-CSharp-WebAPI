using DesignPatternsWebApi.DesignPatterns.Singleton;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatternsWebApi.Controllers
{
    [ApiController]
    [Route("api/singleton")]
    public class SingletonController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetSingleton()
        {
            return Ok(new { message = SingletonBasic.Instance.GetMessage() });
        }
    }
}