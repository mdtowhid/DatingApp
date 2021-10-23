using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CertificateWebApp.Shared.Models;

namespace CertificateWebApp.Server.Entities
{
    public class CertificateWebAppDbContext : DbContext
    {
        public CertificateWebAppDbContext(DbContextOptions<CertificateWebAppDbContext> options) : base(options) { }
        public CertificateWebAppDbContext() { }

        public DbSet<QRCodeInfoGenerator> QRCodeInfoGenerators { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
