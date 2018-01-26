using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using TsudaKageyu;

namespace hzLauncher.Extends
{
    static class utils
    {
        public static Icon getIcon(string fn){

            Icon icon;

            try
            {
                icon = Icon.ExtractAssociatedIcon(fn);
            }
            catch (Exception ee)
            {
                return null;
            }

            return icon;
        }

        public static Bitmap getIconX(string fn){
            Icon icon;
            IconExtractor ie;

            FileInfo inf = new FileInfo(fn);

            if (inf.Extension.ToLower() != ".exe") 
                return Extends.IconHelper.IconReader.GetFileIcon(fn, IconHelper.IconReader.IconSize.Small, false).ToBitmap();

            try 
	            {	        
		             ie = new IconExtractor(fn);
	            }
	            catch (Exception){
		            return null;
	            }
            
            

            // Get the full name of the associated file.

            string fileName = ie.FileName;

            // Get the count of icons in the associated file.

            int iconCount = ie.Count;

            // Extract icons individually.

            Icon icon0 = ie.GetIcon(0);

            // Extract all the icons in one go.

            Icon[] allIcons = ie.GetAllIcons();

            // -----------------------------------------------------------------------------
            // Usage of IconUtil class:

            // Split the variations of icon0 into separate icon objects.

            Icon[] splitIcons = IconUtil.Split(icon0);

            // Convert an icon into bitmap. Unlike Icon.ToBitmap() it preserves the transparency.
            Icon bestOne = null;
            foreach (Icon i in splitIcons)
            {
                if (bestOne == null && i.Height <= Vars.MAXIMUM_ICON_SIZE.Height) bestOne = i;
                if (bestOne != null && i.Height > bestOne.Height && i.Height <= Vars.MAXIMUM_ICON_SIZE.Height) bestOne = i;
            }

            //Bitmap bitmap = splitIcons[0].ToBitmap();

            // Get the bit count of an icon.

            //int bitDepth = IconUtil.GetBitCount(splitIcons[2]);



            return (bestOne ?? Properties.Resources.app_icon).ToBitmap();
        }


        

        public static T cloneControl<T>(this T controlToClone)
            where T : Control
        {
            PropertyInfo[] controlProperties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            T instance = Activator.CreateInstance<T>();

            foreach (PropertyInfo propInfo in controlProperties)
            {
                if (propInfo.CanWrite)
                {
                    if (propInfo.Name != "WindowTarget")
                        propInfo.SetValue(instance, propInfo.GetValue(controlToClone, null), null);
                }
            }

            return instance;
        }



    }


}



public class Shell32
{

    public const int MAX_PATH = 256;
    [StructLayout(LayoutKind.Sequential)]
    public struct SHITEMID
    {
        public ushort cb;
        [MarshalAs(UnmanagedType.LPArray)]
        public byte[] abID;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ITEMIDLIST
    {
        public SHITEMID mkid;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BROWSEINFO
    {
        public IntPtr hwndOwner;
        public IntPtr pidlRoot;
        public IntPtr pszDisplayName;
        [MarshalAs(UnmanagedType.LPTStr)]
        public string lpszTitle;
        public uint ulFlags;
        public IntPtr lpfn;
        public int lParam;
        public IntPtr iImage;
    }

    // Browsing for directory.
    public const uint BIF_RETURNONLYFSDIRS = 0x0001;
    public const uint BIF_DONTGOBELOWDOMAIN = 0x0002;
    public const uint BIF_STATUSTEXT = 0x0004;
    public const uint BIF_RETURNFSANCESTORS = 0x0008;
    public const uint BIF_EDITBOX = 0x0010;
    public const uint BIF_VALIDATE = 0x0020;
    public const uint BIF_NEWDIALOGSTYLE = 0x0040;
    public const uint BIF_USENEWUI = (BIF_NEWDIALOGSTYLE | BIF_EDITBOX);
    public const uint BIF_BROWSEINCLUDEURLS = 0x0080;
    public const uint BIF_BROWSEFORCOMPUTER = 0x1000;
    public const uint BIF_BROWSEFORPRINTER = 0x2000;
    public const uint BIF_BROWSEINCLUDEFILES = 0x4000;
    public const uint BIF_SHAREABLE = 0x8000;

    [StructLayout(LayoutKind.Sequential)]
    public struct SHFILEINFO
    {
        public const int NAMESIZE = 80;
        public IntPtr hIcon;
        public int iIcon;
        public uint dwAttributes;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PATH)]
        public string szDisplayName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = NAMESIZE)]
        public string szTypeName;
    };

    public const uint SHGFI_ICON = 0x000000100;     // get icon
    public const uint SHGFI_DISPLAYNAME = 0x000000200;     // get display name
    public const uint SHGFI_TYPENAME = 0x000000400;     // get type name
    public const uint SHGFI_ATTRIBUTES = 0x000000800;     // get attributes
    public const uint SHGFI_ICONLOCATION = 0x000001000;     // get icon location
    public const uint SHGFI_EXETYPE = 0x000002000;     // return exe type
    public const uint SHGFI_SYSICONINDEX = 0x000004000;     // get system icon index
    public const uint SHGFI_LINKOVERLAY = 0x000008000;     // put a link overlay on icon
    public const uint SHGFI_SELECTED = 0x000010000;     // show icon in selected state
    public const uint SHGFI_ATTR_SPECIFIED = 0x000020000;     // get only specified attributes
    public const uint SHGFI_LARGEICON = 0x000000000;     // get large icon
    public const uint SHGFI_SMALLICON = 0x000000001;     // get small icon
    public const uint SHGFI_OPENICON = 0x000000002;     // get open icon
    public const uint SHGFI_SHELLICONSIZE = 0x000000004;     // get shell size icon
    public const uint SHGFI_PIDL = 0x000000008;     // pszPath is a pidl
    public const uint SHGFI_USEFILEATTRIBUTES = 0x000000010;     // use passed dwFileAttribute
    public const uint SHGFI_ADDOVERLAYS = 0x000000020;     // apply the appropriate overlays
    public const uint SHGFI_OVERLAYINDEX = 0x000000040;     // Get the index of the overlay

    public const uint FILE_ATTRIBUTE_DIRECTORY = 0x00000010;
    public const uint FILE_ATTRIBUTE_NORMAL = 0x00000080;

    [DllImport("Shell32.dll")]
    public static extern IntPtr SHGetFileInfo(
        string pszPath,
        uint dwFileAttributes,
        ref SHFILEINFO psfi,
        uint cbFileInfo,
        uint uFlags
        );
}

/// <summary>
/// Wraps necessary functions imported from User32.dll. Code courtesy of MSDN Cold Rooster Consulting example.
/// </summary>
public class User32
{
    /// <summary>
    /// Provides access to function required to delete handle. This method is used internally
    /// and is not required to be called separately.
    /// </summary>
    /// <param name="hIcon">Pointer to icon handle.</param>
    /// <returns>N/A</returns>
    [DllImport("User32.dll")]
    public static extern int DestroyIcon(IntPtr hIcon);
}