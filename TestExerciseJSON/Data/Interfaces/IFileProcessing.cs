using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExerciseJSON.Data.Interfaces
{
    interface IFileProcessing
    {
        public void WriteInFile(string JSONObject);

        public string ReadFile();
    }
}
