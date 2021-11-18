using Microsoft.EntityFrameworkCore;

namespace RTD.Web.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<ActivityLog> ActivityLog { get; set; }
        public DbSet<Interview> Interviews { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }
        public DbSet<Sickness> Sicknesses { get; set; }
        public DbSet<SiteData> SiteDatas { get; set; }
    }
}
