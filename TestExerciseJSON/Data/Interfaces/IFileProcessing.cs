using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExerciseJSON.Data.Interfaces
{
    /// <summary>
    /// Provides methods for working with the JSON file
    /// </summary>
    interface IFileProcessing
    {
        /// <summary>
        /// File reading method
        /// </summary>
        /// <param name="Object">string for Write</param>
        /// <returns>Boolean variable signaling completion</returns>  
        async static public Task<bool> WriteInFile(string obj)
        {
            return true;
        }

        /// <summary>
        /// Desktop File Reading Method
        /// </summary>
        /// <returns>Text from file</returns>
        async static public Task<string> ReadFile()
        {
            string readResult = "";
            return readResult;
        }
    }
}
