using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestExerciseJSON.Data.Models;

namespace TestExerciseJSON.Data.Interfaces
{
    /// <summary>
    /// representation of a collection of Child objects
    /// </summary>
    internal interface IChildData

    {/// <summary>
     /// Property that represents a collection of objects of type Child
     /// </summary>
        IEnumerable<Child> Children { get; }
    }
}
