using Microsoft.EntityFrameworkCore;

namespace LogistiCore.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Add DbSet<T> properties here later as your models are created
    }
}
