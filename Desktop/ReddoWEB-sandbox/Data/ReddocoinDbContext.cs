using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Reddocoin.Models;
using Reddocoin.Models.Dto;

namespace Reddocoin.Data
{
    public class ReddocoinDbContext : DbContext
    {
        public ReddocoinDbContext(DbContextOptions<ReddocoinDbContext> options) : base(options) { }
        public ReddocoinDbContext() { }

        public DbSet<ReddocoinValue> ReddocoinValues { get; set; }
        public DbSet<Chart> Charts { get; set; }

    }
}
