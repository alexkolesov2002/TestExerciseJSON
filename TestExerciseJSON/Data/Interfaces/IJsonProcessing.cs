using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestExerciseJSON.Data.Models;

namespace TestExerciseJSON.Data.Interfaces
{
    interface IJsonProcessing
    {
        public string SerializeJSON(IEnumerable<Person> Persons);

        public dynamic DeserializeJSON(string Persons);

    }
}
