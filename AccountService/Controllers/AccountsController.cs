using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AccountService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllAccounts()
        {
            return Ok(new { Message = "Returning all accounts!" });
        }

        [HttpPost]
        public IActionResult CreateAccount()
        {
            return Ok(new { Message = "Account created successfully!" });
        }
    }
}
