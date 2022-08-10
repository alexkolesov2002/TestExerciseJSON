using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExerciseJSON.Data.Models
{
    /// <summary>
    /// Data model Child
    /// </summary>
    internal class Child
    {

        public Int32 Id { get; set; } //Я не понял почему здесь нет поля AGE, но не стал добавлять его добавлять. Следовал строго ТЗ
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public Int64 BirthDate { get; set; }
        public Gender Gender { get; set; }

    }
}
