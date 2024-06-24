using Microsoft.EntityFrameworkCore;
using MonitoringAparat.Entitties;
using System;

namespace MonitoringAparat
{
    public class MonitContext : DbContext
    {
        public DbSet<Apparat> Apparature { get; set; }
        public DbSet<Line> Lines { get; set; }
        public DbSet<Material> Material { get; set; }
        // public DbSet<TimeLimit> TimeLimit { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<Part> Parts { get; set; }

        public DbSet<Period> Periods { get; set; }
 
        public DbSet<DayMat> DayMats{ get; set; }
        public DbSet<CountMaterialDay> CountMaterialDays { get; set; }

        public MonitContext(DbContextOptions<MonitContext> options) : base(options) 
        { 
            Database.EnsureCreated(); 
        }
    }
}
