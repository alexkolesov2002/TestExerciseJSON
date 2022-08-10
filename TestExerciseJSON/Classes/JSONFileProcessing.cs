using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestExerciseJSON.Data.Interfaces;
using TestExerciseJSON.Data.Models;

namespace TestExerciseJSON.Classes
{
    internal class JSONFileProcessing : IFileProcessing
    {
        string _path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

        async public Task<string> ReadFile()
        {
           
            var readResultAsync = File.ReadAllTextAsync(_path + @"\" + "Persons.json");
            string readResult = await readResultAsync;
            return readResult;
        }

        async public Task<bool> WriteInFile(string JSONObject)
        {

          await  File.WriteAllTextAsync(_path + @"\" + "Persons.json", JSONObject);
          return true;

        }
    }
}
