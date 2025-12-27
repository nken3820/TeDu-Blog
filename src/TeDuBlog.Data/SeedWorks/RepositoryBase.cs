using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using TeDuBlog.Core.SeedWorks;

namespace TeDuBlog.Data.SeedWorks
{
    public class RepositoryBase<T, TKey> : IRepository<T, TKey> where T : class
    {
        private readonly DbSet<T> _dbSet;
        protected readonly TeDuBlogContext _context;
        public RepositoryBase(TeDuBlogContext context)
        {
            _dbSet = context.Set<T>();
            _context = context;
        }
        public void Add(T entity)
        {
            _dbSet.AddAsync(entity);
        }
        public void AddRange(IEnumerable<T> entities)
        {
            _dbSet.AddRange(entities);
        }
        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression);
        }
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
        public async Task<T?> GetByIdAsync(TKey id)
        {
            return await _dbSet.FindAsync(id);
        }
        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }
        public void RemoveRange(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
        }
    }
}