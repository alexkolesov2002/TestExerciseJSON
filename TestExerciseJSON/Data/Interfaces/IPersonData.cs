using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestExerciseJSON.Data.Models;

namespace TestExerciseJSON.Data.Interfaces
{
    /// <summary>
    /// representation of a collection of Person objects
    /// </summary>
    interface IPersonData

    {   /// <summary>
        /// Property that represents a collection of objects of type Person
        /// </summary>
        IEnumerable<Person> Persons { get; }
    }
}
