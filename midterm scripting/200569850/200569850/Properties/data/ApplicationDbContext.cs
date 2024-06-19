using Microsoft.EntityFrameworkCore;
using YourNamespace.Models;

namespace YourNamespace.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        // Other DbSet properties for your other models, if any
    }
}
