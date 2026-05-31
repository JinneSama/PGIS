using PGISLauncher.Domain.Entities;

namespace PGISLauncher.Interfaces
{
    public interface IAccesService
    {
        IBaseService<int, UserAccess> UserAccessService { get; set; }
        IBaseService<int, OfficeAccess> OfficeAccessService { get; set; }
        IBaseService<int, AppUsage> AppUsageService { get; set; }
    }
}
