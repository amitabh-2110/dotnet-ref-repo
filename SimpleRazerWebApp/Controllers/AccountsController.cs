using Microsoft.AspNetCore.Mvc;

namespace SimpleRazerWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> AccountsData()
        {
            // For status code based result we have to use ActionResult or IActionResult
            // in the return type.
            return Ok("hello world");
        }
    }
}
