using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
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

            IconExtractor ie = new IconExtractor(fn);

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
                if (bestOne == null) bestOne = i;
                if (i.Height > bestOne.Height) bestOne = i;
            }

            Bitmap bitmap = splitIcons[0].ToBitmap();

            // Get the bit count of an icon.

            //int bitDepth = IconUtil.GetBitCount(splitIcons[2]);



            return bestOne.ToBitmap();
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
