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
    internal class JSONSerializePerson : IJsonProcessing
    {
        private readonly DefaultContractResolver _contractResolver = new DefaultContractResolver
        {
            NamingStrategy = new  CamelCaseNamingStrategy()
            
        };

        public dynamic DeserializeJSON(string Persons)
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

        public  string SerializeJSON<T>(IEnumerable<T> obj)
        {
            string Jsonstring = JsonConvert.SerializeObject(obj, new JsonSerializerSettings
            {
                ContractResolver = _contractResolver,
                Formatting = Formatting.Indented
            });
            return Jsonstring;
        }
    }
}
