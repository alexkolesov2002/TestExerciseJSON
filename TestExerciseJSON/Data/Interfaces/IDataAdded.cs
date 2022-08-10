using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestExerciseJSON.Data.Models;
namespace TestExerciseJSON.Data.Interfaces
{
    /// <summary>
    /// Interface representing methods for generating random numbers 
    /// </summary>
    internal interface IDataAdded
    {
        /// <summary>
        /// Phone number generation method
        /// </summary>
        /// <returns> string representation of a random phone number</returns>
        public static string CreatePhoneNumber()
        {
            string result = "";
            return result;
        }
        /// <summary>
        /// Credit card number creation method
        /// </summary>
        /// <returns> string representation of a random credit card number</returns>
        public static string CreateCreditCardNumber()
        {
            string result = "";
            return result;
        }
    }
}
