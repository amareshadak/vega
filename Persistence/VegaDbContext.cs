using Microsoft.EntityFrameworkCore;
using vega.Model;
using Viga.Model;

namespace Viga.Persistence
{
    public class VegaDbContext : DbContext
    {
        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; }
        public VegaDbContext(DbContextOptions<VegaDbContext> option):base(option)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleFeature>().HasKey(
                vf =>
                new { vf.VehicleId, vf.FeatureId}
            );
        }
        
    }
}