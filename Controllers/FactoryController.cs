using DesignPatternsWebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatternsWebApi.Controllers
{
    [ApiController]
    [Route("api/factory")]
    public class FactoryController : ControllerBase
    {
        private readonly FactoryService _factoryService;

        public FactoryController(FactoryService factoryService)
        {
            _factoryService = factoryService;
        }

        [HttpGet("{type}")]
        public IActionResult GetProduct(string type)
        {
            try
            {
                var product = _factoryService.GetProduct(type);
                return Ok(new { ProductName = product.GetName() });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { Error = ex.Message });
            }
        }
    }
}