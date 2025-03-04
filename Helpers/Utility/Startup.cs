using Helpers.Interface;
using Microsoft.Win32;
using System.IO;
using System;
using System.Windows.Forms;
using System.Linq;

namespace Helpers.Utility
{
    public class Startup : IStartup
    {
        public void CheckAndSetStartup()
        {
            string appName = "PGIS";
            string publisherName = "GO-PITD";
            string productName = "PGIS";
            string startMenuPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu), "Programs", publisherName, productName);
            string appPath = Directory.GetFiles(startMenuPath, "*.appref-ms", SearchOption.TopDirectoryOnly).FirstOrDefault();
            string runKeyPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
            string startupApprovedPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\StartupApproved\Run";

            RegistryKey runKey = Registry.CurrentUser.OpenSubKey(runKeyPath, true);
            RegistryKey approvedKey = Registry.CurrentUser.OpenSubKey(startupApprovedPath, false);

            bool isStartupEnabled = runKey?.GetValue(appName) != null;
            bool isStartupDisabledByUser = approvedKey?.GetValue(appName) != null;

            if (!isStartupEnabled && !isStartupDisabledByUser)
            {
                runKey.SetValue(appName, appPath);
            }
        }
    }
}
