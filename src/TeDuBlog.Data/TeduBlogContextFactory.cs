using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
namespace  TeDuBlog.Data
{
    public class TeduBlogContextFactory: IDesignTimeDbContextFactory<TeDuBlogContext>
    {
        public TeDuBlogContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                                        .SetBasePath(Directory.GetCurrentDirectory())
                                        .AddJsonFile("appsettings.json")
                                        .Build();
            
            var builder = new DbContextOptionsBuilder<TeDuBlogContext>();
            builder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            return new TeDuBlogContext(builder.Options);
        }
            
    }
}