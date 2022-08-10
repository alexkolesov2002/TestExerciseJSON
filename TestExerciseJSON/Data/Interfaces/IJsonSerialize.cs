using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestExerciseJSON.Data.Models;

namespace TestExerciseJSON.Data.Interfaces
{   /// <summary>
    /// Provides methods for working with the JSON format
    /// </summary>
    interface IJsonSerialize
    {
        /// <summary>
        /// JSON string serialization method
        /// </summary>
        /// <typeparam name="T">Class type of the object being serialized</typeparam>
        /// <param name="obj">Object to be serialized</param>
        /// <returns>Serialized JSON string</returns>
        public static string SerializeJSON<T>(IEnumerable<T> obj)
        {
            string ResultJsonStrig = "";
            return ResultJsonStrig;
        }

        /// <summary>
        /// JSON string deserialization method
        /// </summary>
        /// <param name="obj">JSON string</param>
        /// <returns>Desiarylized object</returns>
        public static dynamic DeserializeJSON(string obj)
        {
            var resultObj = "";
            return resultObj;
        }

    }
}
