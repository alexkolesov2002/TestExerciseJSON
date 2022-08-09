using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExerciseJSON.Classes
{
    class POSIXDate
    {
        static Random rnd = new Random();
        static DateTime start = new DateTime(2002, 1, 1);
        public static long RandomDay()
        {
            int range = (DateTime.Today - start).Days;
            DateTime days = start.AddDays(rnd.Next(range));
            DateTimeOffset daysoff = new DateTimeOffset(days);
            return daysoff.ToUnixTimeSeconds();
        }


    }

}
