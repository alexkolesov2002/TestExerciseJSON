using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestExerciseJSON.Data.Interfaces;
using TestExerciseJSON.Data.Models;

namespace TestExerciseJSON.Data.Mocks
{
    class MockPerson : IPersonData
    {
        public IEnumerable<Person> Persons {



            get
            {
                List<Person> personList = new List<Person>();
                Array values = Enum.GetValues(typeof(Gender));
                Random random = new Random();


                for (int i = 1; i <= 10000; i++)
                {

                    StringBuilder firstName = new StringBuilder();
                    StringBuilder lastName = new StringBuilder();
                    Gender randomGender = (Gender)values.GetValue(random.Next(values.Length));

                    if (randomGender == Gender.Male)
                    {
                        firstName.Append(RandomData._maleNames[new Random().Next(0, RandomData._maleNames.Length)]);
                    }

                    else if (randomGender == Gender.Female)
                    {
                        firstName.Append(RandomData._femaleNames[new Random().Next(0, RandomData._femaleNames.Length)]);
                    }

                    lastName.Append(RandomData._lastNames[new Random().Next(0, RandomData._lastNames.Length)]);

                    personList.Add(new Child
                    {
                        Id = i,
                        BirthDate = POSIXDate.RandomDay(),
                        Gender = randomGender,
                        FirstName = firstName.ToString(),
                        LastName = lastName.ToString(),
                    });
                }
                return childList;
            }





        }
    }
}
