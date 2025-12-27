using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TeDuBlog.Data;

namespace TeDuBlog.Api
{
    public static class MigrationManager
    {
        public static async Task<WebApplication> MigrateDatabaseAsync(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                using (var context = scope.ServiceProvider.GetRequiredService<TeDuBlogContext>())
                {
                    try
                    {
                        await context.Database.MigrateAsync();
                        await new DataSeeder().seedAsync(context);
                    } catch (Exception ex)
                    {
                        var logger = scope.ServiceProvider
                                                .GetRequiredService<ILoggerFactory>()
                                                .CreateLogger("Migration");
                        
                        logger.LogCritical(ex, "Database migration failed");
                        throw;
                    }
                }
            }
            return app;
        }
    }
}