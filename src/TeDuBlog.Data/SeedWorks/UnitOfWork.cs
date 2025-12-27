using TeDuBlog.Core.SeedWorks;

namespace TeDuBlog.Data.SeedWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TeDuBlogContext _context;

        public UnitOfWork(TeDuBlogContext context)
        {
            _context = context;
        }
        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

    }
}