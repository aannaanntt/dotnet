using crudApi.Model;
using Microsoft.EntityFrameworkCore;

namespace crudApi.DBContext
{
    // Data/ApplicationDbContext.cs
    using Microsoft.EntityFrameworkCore;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
