using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            return Ok(new { Message = "Returning all users!" });
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            return Ok(new { Message = $"Returning user with ID {id}" });
        }
    }
}
