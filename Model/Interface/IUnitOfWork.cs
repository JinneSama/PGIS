using Model.Entities;
using System.Threading.Tasks;

namespace Model.Interface
{
    public interface IUnitOfWork
    {
        IRepository<InformationSystem> InformationSystemRepo { get; }
        IRepository<ISImage> ISImageRepo { get; }
        IRepository<UserAccess> UserAccessRepo { get; }
        IRepository<AppUsage> AppUsageRepo { get; }
        Task SaveAsync();
        void Save();
    }
}
