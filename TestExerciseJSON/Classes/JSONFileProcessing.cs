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

        public string ReadFile()
        {
            string readResult = File.ReadAllText(_path + @"\" + "Persons.json");
            return readResult;
        }

        public void WriteInFile(string JSONObject)
        {
            
            File.WriteAllText(_path + @"\" + "Persons.json", JSONObject);
        }
    }
}
