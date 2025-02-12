using Model.Entities;
using System.Data.Entity;

namespace Model.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
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
    }
}
