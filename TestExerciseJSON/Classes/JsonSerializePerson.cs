using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestExerciseJSON.Data.Interfaces;
using TestExerciseJSON.Data.Models;

namespace TestExerciseJSON.Classes
{
    /// <summary>
    /// Provides methods for working with the JSON format
    /// </summary>
    internal class JSONSerializePerson : IJsonSerialize
    {
        private static readonly DefaultContractResolver _contractResolver = new DefaultContractResolver
        {
            NamingStrategy = new CamelCaseNamingStrategy()

        };
        /// <summary>
        /// JSON string deserialization method
        /// </summary>
        /// <param name="Persons">JSON string</param>
        /// <returns>Desiarylized object</returns>
        public static dynamic DeserializeJSON(string Persons)
        {
            var resultSerialize = JsonConvert.DeserializeObject<IEnumerable<Person>>(Persons);
            if (resultSerialize != null)
            {
                return resultSerialize;
            }
            else
            {
                return "";
            }

        }
        /// <summary>
        /// JSON string serialization method
        /// </summary>
        /// <typeparam name="T">Class type of the object being serialized</typeparam>
        /// <param name="obj">Object to be serialized</param>
        /// <returns>Serialized JSON string</returns>
        public static string SerializeJSON<T>(IEnumerable<T> obj)
        {
            string JSONstring = JsonConvert.SerializeObject(obj, new JsonSerializerSettings
            {
                ContractResolver = _contractResolver,
                Formatting = Formatting.Indented
            });
            return JSONstring;
        }
    }
}
