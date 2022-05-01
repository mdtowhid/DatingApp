using JobPortal.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace JobPortal.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
              : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Employer> Employers { get; set; }
    }
}
