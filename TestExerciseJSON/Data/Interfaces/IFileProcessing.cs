using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExerciseJSON.Data.Interfaces
{
    interface IFileProcessing
    {
        async public Task<bool> WriteInFile(string JSONObject)
        {
            return true;
        }

        async public Task<string> ReadFile()
        {
            string readResult = "";
            return readResult;
        }
    }
}
