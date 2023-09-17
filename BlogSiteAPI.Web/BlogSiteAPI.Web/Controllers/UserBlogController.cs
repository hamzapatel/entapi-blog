using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogSiteAPI.Web.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class UserBlogController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllBllogs()
        {
            return Ok("Hello World");
        }
    }
}
