using PGISLauncher.Domain.Entities;
using System.Drawing;

namespace PGISLauncher.DataModels
{
    public class SystemInfoViewModel
    {
        public InformationSystem SystemInformation { get; set; }
        public Image AppImage { get; set; }
        public string InstallInfo { get; set; }
    }
}
