using AutoMapper;
using TeDuBlog.Core.Repositories;
using TeDuBlog.Core.SeedWorks;
using TeDuBlog.Data.Repositories;

namespace TeDuBlog.Data.SeedWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TeDuBlogContext _context;
        public IPostRepository Posts {get; private set;}

        public UnitOfWork(TeDuBlogContext context, IMapper mapper)
        {
            _context = context;
            Posts = new PostRepository(_context, mapper);
        }
        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

    }
}