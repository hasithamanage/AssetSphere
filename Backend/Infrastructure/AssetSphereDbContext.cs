using Microsoft.EntityFrameworkCore;
using AssetSphere.Domain.Entities;

namespace AssetSphere.Infrastructure
{
    public class AssetSphereDbContext : DbContext
    {
        public AssetSphereDbContext(DbContextOptions<AssetSphereDbContext> options)
            : base(options)
        {
        }

        // DbSets for your entities
        public DbSet<Asset> Assets { get; set; }
        public DbSet<WorkOrder> WorkOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure entity mappings here if needed
        }
    }
}
