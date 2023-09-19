using BlogSiteAPI.Repository.Models;

namespace BlogSiteAPI.Repository.Interfaces
{
    public interface IBlogRepository
    {
        Task<List<Blog>> GetBlogListAsync();
    }
}