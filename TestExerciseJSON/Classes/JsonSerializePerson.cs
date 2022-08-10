﻿using Newtonsoft.Json;
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
    internal class JsonSerializePerson : IJsonProcessing
    {
        DefaultContractResolver contractResolver = new DefaultContractResolver
        {
            NamingStrategy = new  CamelCaseNamingStrategy()
            
        };

        public dynamic DeserializeJSON(string Persons)
        {
            var resultSerialize = JsonConvert.DeserializeObject<List<Person>>(Persons);
            return resultSerialize;
        }

        public  string SerializeJSON(IEnumerable<Person> Persons)
        {
            string Jsonstring = JsonConvert.SerializeObject(Persons, new JsonSerializerSettings
            {
                ContractResolver = contractResolver,
                Formatting = Formatting.Indented
            });
            return Jsonstring;
        }
    }
}