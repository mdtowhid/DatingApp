using Cleansiness.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Cleansiness.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<ActivityLog> ActivityLogs { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Aspect> Aspects { get; set; }
        public DbSet<AuditDetail> AuditDetails { get; set; }
        public DbSet<AuditMaster> AuditMasters { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Risk> Risks { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<SectionTrack> SectionTracks { get; set; }
    }
}
