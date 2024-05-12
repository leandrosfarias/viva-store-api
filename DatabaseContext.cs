using Microsoft.EntityFrameworkCore;

namespace VivaStoreApi
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
