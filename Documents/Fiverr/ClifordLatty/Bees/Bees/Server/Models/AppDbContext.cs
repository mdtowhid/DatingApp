using Bees.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Bees.Server.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
               : base(options)
        { }

        public DbSet<User> Users { get; set; }
    }
}
