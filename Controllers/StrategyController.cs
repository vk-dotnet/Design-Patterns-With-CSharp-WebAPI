using DesignPatternsWebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatternsWebApi.Controllers;

[ApiController]
[Route("api/strategy")]
public class StrategyController : ControllerBase
{
    private readonly StrategyService _strategyService;

    public StrategyController(StrategyService strategyService)
    {
        _strategyService = strategyService;
    }

    [HttpGet("discount")]
    public IActionResult GetDiscount([FromQuery] string type, [FromQuery] double price, [FromQuery] double value)
    {
        try
        {
            double discountedPrice = _strategyService.CalculateDiscount(type, price, value);
            return Ok(new { OriginalPrice = price, DiscountedPrice = discountedPrice });
        }
        catch (ArgumentException ex)
        {
            return BadRequest(new { Error = ex.Message });
        }
    }
}