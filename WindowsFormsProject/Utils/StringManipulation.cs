using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsProject.Utils
{
    public static class StringManipulation
    {
        public static String GetFileName(String filePath)
        {
            return filePath.Substring(filePath.LastIndexOf('\\') + 1);
        }
    }
}
