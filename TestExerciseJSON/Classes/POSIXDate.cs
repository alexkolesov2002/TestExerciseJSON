using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExerciseJSON.Classes
{
    class POSIXDate
    {
        static Random random = new Random();
      
        public static long RandomDateForChild(DateTime date)
        {
            int range = (DateTime.Today - date).Days;
            DateTime days = date.AddDays(random.Next(range));
            DateTimeOffset daysoff = new DateTimeOffset(days);
            return daysoff.ToUnixTimeSeconds();
        }

        public static long RandomDateForPerson(DateTime date)
        {
            int range = (new DateTime(2002,1,1) - date).Days;
            DateTime days = date.AddDays(random.Next(range));
            DateTimeOffset daysoff = new DateTimeOffset(days);
            return daysoff.ToUnixTimeSeconds();
        }
       
        public static int GetDifferenceInYears(DateTime startDate, DateTime endDate)
        {
            
            int years = endDate.Year - startDate.Year;

            if (startDate.Month == endDate.Month && endDate.Day < startDate.Day)
            {
                years--;
            }
            else if (endDate.Month < startDate.Month)
            {
                years--;
            }

            return years;
        }
    }

}
