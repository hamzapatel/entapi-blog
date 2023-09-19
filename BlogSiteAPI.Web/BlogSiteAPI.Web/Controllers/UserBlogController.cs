using BlogSiteAPI.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlogSiteAPI.Web.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/user-blogs")]
    [ApiController]
    public class UserBlogsController : ControllerBase
    {
        private readonly IBlogService _blogService;

        public UserBlogsController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        [HttpGet("list")]
        public async Task<IActionResult> GetBlogList()
        {
            var blogs = await _blogService.GetBlogList();
            return Ok(blogs);
        }
    }
}