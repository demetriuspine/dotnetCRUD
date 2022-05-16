using Microsoft.EntityFrameworkCore;

namespace dotnetCRUD.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        public DbSet<Product> Product { get; set; }

    }
}
