using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExerciseJSON.Data.Models
{
    class Person
    {
        public Person(int id, Guid transportId, string firstName, string lastName, int sequenceId, string[] creditCardNumbers, int age, string[] phones, long birthDate, double salary, bool isMarred, Gender gender, Child[] children)
        {
            Id = id;
            TransportId = transportId;
            FirstName = firstName;
            LastName = lastName;
            SequenceId = sequenceId;
            CreditCardNumbers = creditCardNumbers;
            Age = age;
            Phones = phones;
            BirthDate = birthDate;
            Salary = salary;
            IsMarred = isMarred;
            Gender = gender;
            Children = children;
        }

        public Int32 Id { get; set; }
        public Guid TransportId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public Int32 SequenceId { get; set; }
        public String[] CreditCardNumbers { get; set; }
        public Int32 Age { get; set; }
        public String[] Phones { get; set; }
        public Int64 BirthDate { get; set; }
        public Double Salary { get; set; }
        public Boolean IsMarred { get; set; }
        public Gender Gender { get; set; }
        public Child[] Children { get; set; }
    }
}
