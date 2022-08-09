using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestExerciseJSON.Data.Models;

namespace TestExerciseJSON.Data.Interfaces
{
    interface IPersonData
    {
        IEnumerable<Person> Persons { get; }
    }
}
