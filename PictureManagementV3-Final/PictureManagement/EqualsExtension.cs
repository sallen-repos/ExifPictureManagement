using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureManagement
{
    //This static class is an extension to .Equals() for case insensitive comparisons

    public static class EqualsExtension
    {
        public static bool Equals(this string dataSource, string input, StringComparison comp)
        {
            return dataSource != null && input != null && dataSource.IndexOf(input, comp) >= 0;
        }
    }
}