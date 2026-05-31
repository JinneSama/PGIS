using PGISLauncher.Domain.Entities;
using System.Data.Entity;

namespace PGISLauncher.Domain.Context
{
    public class PGISContext : DbContext
    {
        public PGISContext() : base("DefaultConnection")
        {
        }
        public void FixEfProviderServicesProblem()
        {
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public DbSet<InformationSystem> InformationSystem { get; set; }
        public DbSet<UserAccess> UserAccess { get; set; }
        public DbSet<ISImage> ISImage { get; set; }
        public DbSet<AppUsage> AppUsage { get; set; }
        public DbSet<OfficeAccess> OfficeAccesses { get; set; }
    }
}
