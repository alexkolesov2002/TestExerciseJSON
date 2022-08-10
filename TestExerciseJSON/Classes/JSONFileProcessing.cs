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
    /// Provides methods for working with the JSON file
    /// </summary>
    internal class JSONFileProcessing : IFileProcessing
    {
        readonly static string _path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

        /// <summary>
        /// Desktop File Reading Method
        /// </summary>
        /// <returns>JSON string</returns>
        async static public Task<string> ReadFile()
        {

            var readResultAsync = File.ReadAllTextAsync(_path + @"\" + "Persons.json");
            string readResult = await readResultAsync;
            return readResult;
        }
        /// <summary>
        /// Desktop file reading method
        /// </summary>
        /// <param name="JSONObject">JSON string</param>
        /// <returns>Boolean variable signaling completion</returns>
        async static public Task<bool> WriteInFile(string JSONObject)
        {

            await File.WriteAllTextAsync(_path + @"\" + "Persons.json", JSONObject);
            return true;

        }
    }
}
