using Microsoft.AspNetCore.Mvc;
using ShippingApi.Models;
using ShippingApi.Services;

namespace ShippingApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShippingController : ControllerBase
    {
        private readonly ShippingCalculatorService _calculator; 
        public ShippingController() 
        { 
            _calculator = new ShippingCalculatorService(); 
        }
        [HttpPost("calculate")] 
        public IActionResult Calculate([FromBody] Order order) 
        { 
            try 
            { 
                var cost = _calculator.CalculateShippingCost(order); 
                return Ok(new { ShippingMethod = order.ShippingMethod, Cost = cost }); 
            } 
            catch (ArgumentException ex) 
            { 
                return BadRequest(new { Error = ex.Message }); 
            } 
        }
    }
}
