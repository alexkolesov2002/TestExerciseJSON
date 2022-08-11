using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestExerciseJSON.Classes;
using TestExerciseJSON.Data.Interfaces;

namespace TestExerciseJSON.Data.Models
{
    /// <summary>
    ///  Сontaining statistical data and methods for generating data
    /// </summary>
    class RandomData : IDataDisplay, IDataAdded
    {
        private static readonly Random random = new Random();

        public static string[] _maleNames = { "Jame", "Nick", "Alex", "Ostin" }; // Коллекции имен и фамилий
        public static string[] _femaleNames = { "Kate", "Kris", "Jill", "Elizabeth" };
        public static string[] _lastNames = { "Smith", "Jonson", "Boldins", "Vorias" };

        /// <summary>
        /// Phone number generation method
        /// </summary>
        /// <returns> string representation of a random phone number</returns>
        public static string CreatePhoneNumber()
        {
            try
            {
                int num = random.Next(000, 999);
                int num1 = random.Next(000, 999);
                int num2 = random.Next(00, 99);
                int num3 = random.Next(00, 99);
                string result = "+7 " + num.ToString() + " " + num1.ToString() + " " + num2.ToString() + " " + num3.ToString();
                return result;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
                return "";
            }

        }

        /// <summary>
        /// Credit card number creation method
        /// </summary>
        /// <returns> string representation of a random credit card number</returns>
        public static string CreateCreditCardNumber()
        {
            try
            {
                int num = random.Next(0000, 9999);
                int num1 = random.Next(0000, 9999);
                int num2 = random.Next(0000, 999);
                int num3 = random.Next(0000, 9999);
                string result = num.ToString() + " " + num1.ToString() + " " + num2.ToString() + " " + num3.ToString();
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "";

            }

        }
        /// <summary>
        /// Method for displaying information from the collection to the console
        /// </summary>
        /// <param name="personsList">Collection of type Person</param>
        public static void DisplayResult(IEnumerable<Person> personsList)
        {
            try
            {


                double generalAvverageAge = 0;
                int generalCreditCardCount = 0;


                foreach (Person person in personsList)
                {
                    List<int> childrenAge = new List<int>();

                    foreach (Child child in person.Children)
                    {
                        DateTime UNIXDateTime = new UnixTimestamp(child.BirthDate); //Using a third party library unixtimestamp\1.0.0\
                        int age = POSIXDate.GetDifferenceInYears(UNIXDateTime, DateTime.Now);
                        childrenAge.Add(age);
                    }
                    double avvrageAge = childrenAge.Average() * 1.0; // Calculating the average age of children for Person object
                    generalAvverageAge += avvrageAge;
                    generalCreditCardCount += person.CreditCardNumbers.Length;

                    Console.WriteLine($"{person.Id} - id Person, {person.CreditCardNumbers.Length} - person credit card count, {Math.Round(avvrageAge, 2)} -  average value of children age");
                }
                Console.WriteLine("\n");
                Console.WriteLine($"{personsList.Count()} - persons count, {generalCreditCardCount} - persons credit card count, {Math.Round(generalAvverageAge / personsList.Count(), 2)} -  average value of child age");

            }
            catch (Exception ex)
            {   
                  Console.WriteLine(ex.ToString());   
            }
           }



    }
}
