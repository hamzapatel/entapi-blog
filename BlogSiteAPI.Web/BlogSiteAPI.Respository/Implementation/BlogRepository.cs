using BlogSiteAPI.Respository.Interfaces;
using BlogSiteAPI.Respository.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogSiteAPI.Respository.Implementation
{
    public class BlogRepository : IBlogRepository
    {
        private readonly TechblogsContext techblogsContext;

        public BlogRepository(TechblogsContext _techblogsContext)
        {
            techblogsContext = _techblogsContext;
        }

        public async Task<List<Blog>> GetBlogList()
        {
            return await techblogsContext.Blogs.ToListAsync();
        }
    }
}
