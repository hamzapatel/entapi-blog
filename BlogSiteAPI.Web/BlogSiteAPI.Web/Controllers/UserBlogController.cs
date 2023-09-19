using BlogSiteAPI.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlogSiteAPI.Web.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class UserBlogController : ControllerBase
    {
        private readonly IBlogService blogService;

        public UserBlogController(IBlogService _blogService)
        {
            blogService = _blogService;
        }

        [HttpGet("bloglist")]
        public async Task<IActionResult> GetBlogList()
        {
            var result = await blogService.GetBlogList();
            return Ok(result);
        }
    }
}
