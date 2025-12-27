using TeDuBlog.Core.Domain.Content;
using TeDuBlog.Core.Models;
using TeDuBlog.Core.Models.Content;
using TeDuBlog.Core.SeedWorks;

namespace TeDuBlog.Core.Repositories
{
    public interface IPostRepository : IRepository<Post, Guid>
    {
        Task<List<Post>> GetPopularPostsAsync(int count);
        Task<PagedResult<PostInListDto>> GetPostPagingAsync(string keyword, Guid? categoryId, int pageIndex = 1, int pageSize = 10 );
        
    }
}