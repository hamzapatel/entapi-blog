using BlogSiteAPI.Respository.Interfaces;
using BlogSiteAPI.Service.Interfaces;

namespace BlogSiteAPI.Service.Implementation
{
    public class BlogService : IBlogService
    {
        private readonly IBlogRepository blogRepository;

        public BlogService(IBlogRepository _blogRepository)
        {
            blogRepository = _blogRepository;
        }

        public async Task<bool> GetBlogList()
        {
            await blogRepository.GetBlogList();
            return true;
        }
    }
}
