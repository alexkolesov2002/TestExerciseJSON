using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestExerciseJSON.Classes;
using TestExerciseJSON.Data.Interfaces;

namespace TestExerciseJSON.Data.Models
{
    class RandomData: IDisplayData
    {
        public static Random random = new Random();

        public static string[] _maleNames = { "Jame", "Nick", "Alex", "Ostin" };
        public static string[] _femaleNames = { "Kate", "Kris", "Jill", "Elizabeth" };
        public static string[] _lastNames = { "Smith", "Jonson", "Boldins", "Vorias" };

        public static string CreatePhoneNumber()
        {
            
            int num = random.Next(000, 999);
            int num1 = random.Next(000, 999);
            int num2 = random.Next(00, 99);
            int num3 = random.Next(00, 99);
            string result = "+7 "+  num.ToString()+ " " + num1.ToString() + " " + num2.ToString() + " " + num3.ToString();
            return result;
        }

        public static string CreateCreditCardNumber()
        {
          
            int num = random.Next(0000, 9999);
            int num1 = random.Next(0000, 9999);
            int num2 = random.Next(0000, 999);
            int num3 = random.Next(0000, 9999);
            string result =   num.ToString() +" " + num1.ToString() + " " + num2.ToString() + " " + num3.ToString();
            return result;
        }

        public static void DisplayResult(IEnumerable<Person> persinList)
        {
            

            foreach (Person person in persinList)
            {
                List<int> childrenAge = new List<int>();
                foreach (Child child in person.Children)
                {
                    DateTime asDateTime = new UnixTimestamp(child.BirthDate);
                    int age = POSIXDate.GetDifferenceInYears(asDateTime, DateTime.Now);
                    childrenAge.Add(age);
                }
                double avvrageAge = childrenAge.Average()*1.0;


                Console.WriteLine($"{person.Id} - id пользователя, {person.CreditCardNumbers.Length} - количество крединтых карт пользователя, {avvrageAge}- Среднее значение возраста детей, {person.Children.Length} - Количество детей" );
            }
            
        }

       
    }
}
