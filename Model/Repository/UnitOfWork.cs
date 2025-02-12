using Model.Context;
using Model.Entities;
using Model.Interface;
using System.Threading.Tasks;

namespace Model.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork()
        {
            _context = new ApplicationDbContext();
        }
        private IRepository<InformationSystem> _InformationSystemRepo;
        public IRepository<InformationSystem> InformationSystemRepo 
        {
            get
            {
                if (_InformationSystemRepo == null) _InformationSystemRepo = new Repository<InformationSystem>(_context);
                return _InformationSystemRepo;
            }
        }

        private IRepository<ISImage> _ISImageRepo;
        public IRepository<ISImage> ISImageRepo
        {
            get
            {
                if (_ISImageRepo == null) _ISImageRepo = new Repository<ISImage>(_context);
                return _ISImageRepo;
            }
        }

        private IRepository<UserAccess> _UserAccessRepo;
        public IRepository<UserAccess> UserAccessRepo
        {
            get
            {
                if (_UserAccessRepo == null) _UserAccessRepo = new Repository<UserAccess>(_context);
                return _UserAccessRepo;
            }
        }

        private IRepository<AppUsage> _AppUsageRepo;
        public IRepository<AppUsage> AppUsageRepo
        {
            get
            {
                if (_AppUsageRepo == null) _AppUsageRepo = new Repository<AppUsage>(_context);
                return _AppUsageRepo;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
