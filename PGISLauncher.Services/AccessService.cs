using PGISLauncher.Domain.Entities;
using PGISLauncher.Interfaces;

namespace PGISLauncher.Services
{
    public class AccessService : IAccesService
    {
        public IBaseService<int, UserAccess> UserAccessService { get; set; }
        public IBaseService<int, OfficeAccess> OfficeAccessService { get; set; }
        public IBaseService<int, AppUsage> AppUsageService { get; set; }

        public AccessService(IBaseService<int, UserAccess> userAccessService,
            IBaseService<int, OfficeAccess> officeAccessService,
            IBaseService<int, AppUsage> appUsageService)
        {
            UserAccessService = userAccessService;
            OfficeAccessService = officeAccessService;
            AppUsageService = appUsageService;
        }
    }
}
