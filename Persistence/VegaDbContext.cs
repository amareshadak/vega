using Microsoft.EntityFrameworkCore;
using Viga.Model;

namespace Viga.Persistence
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> option):base(option)
        { }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; }
    }
}