using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDataAnalyzerProject
{
    public static class FileInfoExtensions
    {

        public static bool IsTextFile(this FileInfo fileInfo)
        {
            return fileInfo.Extension.Equals(".txt", StringComparison.OrdinalIgnoreCase);
        }
        public static bool IsCsvFile(this FileInfo fileInfo)
        {
            //if (fileInfo.Extension == ".csv")
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            return fileInfo.Extension.Equals(".csv", StringComparison.OrdinalIgnoreCase);
        }
    }
}
