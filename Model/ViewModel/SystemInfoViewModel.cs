using Helpers.Service;
using Model.Entities;
using System.Drawing;
using System.Threading.Tasks;

namespace Model.ViewModel
{
    public class SystemInfoViewModel
    {
        public InformationSystem SystemInformation { get; set; }
        public Image AppImage { get; set; }
        public string InstallInfo { get; set; }
    }
}
