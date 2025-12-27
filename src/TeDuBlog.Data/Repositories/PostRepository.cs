using Microsoft.EntityFrameworkCore;
using TeDuBlog.Core.Domain.Content;
using TeDuBlog.Core.Repositories;
using TeDuBlog.Data.SeedWorks;

namespace  TeDuBlog.Data.Repositories
{
    public class PostRepository : RepositoryBase<Post, Guid>, IPostRepository
    {
        public PostRepository(TeDuBlogContext context) : base(context)
        {
            
        }
        public Task<List<Post>> GetPopularPostsAsync(int count)
        {
            return _context.Posts.OrderByDescending(x => x.ViewCount).Take(count).ToListAsync();
        }
    }
}