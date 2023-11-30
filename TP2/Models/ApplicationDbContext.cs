using Microsoft.EntityFrameworkCore;

namespace TP2.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Movie>? movies { get; set; }
        public DbSet<Genre> genres { get; set; }
        public DbSet<Customer> customers { get; set; }
        public ApplicationDbContext(DbContextOptions options): base(options)
        {
        }
    }
}
