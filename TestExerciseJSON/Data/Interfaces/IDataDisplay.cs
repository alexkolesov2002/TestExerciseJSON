using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestExerciseJSON.Data.Models;

namespace TestExerciseJSON.Data.Interfaces
{
    /// <summary>
    /// Interface representing method for displaing persons information
    /// </summary>
    internal interface IDataDisplay
    {
        /// <summary>
        /// Display information from Person collection
        /// </summary>
        /// <param name="persinList">Person collection</param>
        public static void DisplayResult(IEnumerable<Person> persinList)
        {

        }
    }
}
