using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExerciseJSON.Classes
{
    /// <summary>
    /// Provides methods for working with POSIX date
    /// </summary>
    class POSIXDate
    {
        private static Random random = new Random();
        /// <summary>
        /// Returns a specific date in POSIX format from a random range of dates for Child
        /// </summary>
        /// <param name="dateStart">Minimum due date</param>
        /// <returns> Date in POSIX format </returns>
        public static long RandomDateForChild(DateTime dateStart)
        {
            try
            {
                int range = (DateTime.Today - dateStart).Days;
                DateTime days = dateStart.AddDays(random.Next(range));
                DateTimeOffset daysOff = new DateTimeOffset(days);
                return daysOff.ToUnixTimeSeconds();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return 0;
            }

        }
        /// <summary>
        /// Returns a specific date in POSIX format from a random range of dates for Person
        /// </summary>
        /// <param name="date"></param>
        /// <returns>Date in POSIX format</returns>
        public static long RandomDateForPerson(DateTime date)
        {
            try
            {
                int range = (new DateTime(2002, 1, 1) - date).Days; //Parent's minimum date of birth can be 2002
                DateTime days = date.AddDays(random.Next(range));
                DateTimeOffset daysOff = new DateTimeOffset(days);
                return daysOff.ToUnixTimeSeconds();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return 0;
            }

        }
        /// <summary>
        /// Calculating the difference in years between two dates
        /// </summary>
        /// <param name="startDate"> Smaller date</param>
        /// <param name="endDate">Biggest data</param>
        /// <returns>Integer count year</returns>
        public static int GetDifferenceInYears(DateTime startDate, DateTime endDate)
        {
            try
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return 0;
            }
        }
    }

}
