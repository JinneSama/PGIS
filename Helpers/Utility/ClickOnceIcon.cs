using System.Runtime.InteropServices;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Helpers.Utility
{
    public class ClickOnceIcon
    {
        [DllImport("Shell32.dll")]
        public static extern int SHGetFileInfo(
            string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi,
            uint cbFileInfo, uint uFlags);

        private const uint SHGFI_ICON = 0x000000100;
        private const uint SHGFI_LARGEICON = 0x000000000;

        [StructLayout(LayoutKind.Sequential)]
        public struct SHFILEINFO
        {
            public IntPtr hIcon;
            public int iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        }

        public static Image GetIcon(string appRefPath)
        {
            Image img = null;
            if (System.IO.File.Exists(appRefPath))
            {
                SHFILEINFO shinfo = new SHFILEINFO();
                SHGetFileInfo(appRefPath, 0, ref shinfo, (uint)System.Runtime.InteropServices.Marshal.SizeOf(shinfo),
                    SHGFI_ICON | SHGFI_LARGEICON);

                if (shinfo.hIcon != IntPtr.Zero)
                {
                    Icon appIcon = Icon.FromHandle(shinfo.hIcon);
                    img = appIcon.ToBitmap();
                }
            }
            return img;
        }
    }
}
