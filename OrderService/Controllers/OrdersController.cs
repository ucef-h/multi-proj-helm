using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllOrders()
        {
            return Ok(new { Message = "Returning all orders!" });
        }

        [HttpPost]
        public IActionResult CreateOrder()
        {
            return Ok(new { Message = "Order created successfully!" });
        }
    }
}
