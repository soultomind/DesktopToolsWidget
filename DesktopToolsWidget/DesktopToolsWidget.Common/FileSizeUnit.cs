using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopToolsWidget.Common
{
    public class FileSizeUnit
    {
        public static string ConvertSize(double size)
        {
            //https://social.msdn.microsoft.com/Forums/sqlserver/en-US/68ecd276-ef2f-4f49-8352-2f9c23af6a74/convert-from-bytes-to-gb?forum=winforms
            string[] units = new string[] { "B", "KB", "MB", "GB", "TB", "PB" };
            double mod = 1024.0;
            int i = 0;
            while (size >= mod)
            {
                size /= mod;
                i++;
            }
            return Math.Round(size) + units[i];
        }

        public static bool TryConvertSize(double size, out string convertSize)
        {
            try
            {
                convertSize = ConvertSize(size);
                return true;
            }
            catch (IndexOutOfRangeException)
            {
                convertSize = String.Empty;
                return false;
            }
        }
    }
}
