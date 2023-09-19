using BlogSiteAPI.Repository.Interfaces;
using BlogSiteAPI.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogSiteAPI.Repository.Implementation
{
    public class BlogRepository : IBlogRepository
    {
        private readonly TechblogsContext _techblogsContext;

        public BlogRepository(TechblogsContext techblogsContext)
        {
            _techblogsContext = techblogsContext;
        }

        public async Task<List<Blog>> GetBlogListAsync()
        {
            return await _techblogsContext.Blogs.ToListAsync();
        }
    }
}
