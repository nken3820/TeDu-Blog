using TeDuBlog.Core.Domain.Content;
using TeDuBlog.Core.SeedWorks;

namespace TeDuBlog.Core.Repositories
{
    public interface IPostRepository : IRepository<Post, Guid>
    {
        Task<List<Post>> GetPopularPostsAsync(int count);
    }
}