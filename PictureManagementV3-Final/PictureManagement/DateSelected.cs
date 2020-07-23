using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureManagement
{
    public class DateSelected
    {
        public DateSelected(string dateFrom, string dateTo)
        {
            DateComparison(dateFrom, dateTo);
            
        }

        public void  DateComparison(string dateFrom, string dateTo)
        {
            /*if (dateFrom != "" && dateTo != "")
            {
                for (int i = 0; i < dataStore.ImageCount; i++)
                {
                    first = DateSelected(i, first);
                }
                FirstInList(@"No Image between dates selected found", "Image Not Found!", first);
            }*/
        }
    }
}