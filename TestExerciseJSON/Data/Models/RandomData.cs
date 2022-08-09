using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExerciseJSON.Data.Models
{
    class RandomData
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
      
       

    }
}
