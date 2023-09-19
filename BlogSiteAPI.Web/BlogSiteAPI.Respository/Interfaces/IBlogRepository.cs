using BlogSiteAPI.Respository.Models;

namespace BlogSiteAPI.Respository.Interfaces
{
    public interface IBlogRepository
    {
        Task<List<Blog>> GetBlogList();
    }
}
