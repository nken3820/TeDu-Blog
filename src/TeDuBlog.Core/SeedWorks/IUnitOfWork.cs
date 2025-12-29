using TeDuBlog.Core.Repositories;

namespace TeDuBlog.Core.SeedWorks
{
    public interface IUnitOfWork
    {
        IPostRepository Posts {get;}
        Task<int> CompleteAsync();
    }
}