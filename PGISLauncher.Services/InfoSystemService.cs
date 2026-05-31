using PGISLauncher.Domain.Entities;
using PGISLauncher.Interfaces;
using PGISLauncher.Services.Base;

namespace PGISLauncher.Services
{
    public class InfoSystemService : BaseService<int, InformationSystem> , IInfoSystemService
    {
        public InfoSystemService(IRepository<int, InformationSystem> baseRepo) : base(baseRepo)
        {
        }
    }
}
