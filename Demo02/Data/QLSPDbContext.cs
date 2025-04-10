using Demo02.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo02.Data
{
    public class QLSPDbContext : DbContext
    {
        public QLSPDbContext(DbContextOptions<QLSPDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
