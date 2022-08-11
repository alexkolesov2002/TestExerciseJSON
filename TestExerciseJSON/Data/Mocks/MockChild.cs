using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestExerciseJSON.Data.Interfaces;
using TestExerciseJSON.Data.Models;
using TestExerciseJSON.Classes;

namespace TestExerciseJSON.Data.Mocks
{
    /// <summary>
    ///Class for populating a collection with objects of type Child
    /// </summary>
    class MockChild : IChildData
    {
        /// <summary>
        /// Property that represents a collection of objects of type  Child
        /// </summary>
        public IEnumerable<Child> Children
        {
            
            get
            {
                try
                {
                    List<Child> childList = new List<Child>();
                    Array values = Enum.GetValues(typeof(Gender));
                    Random random = new Random();
                    DateTime dateStart = new DateTime(2002, 1, 1); //Minimum date of birth of child

                    for (int i = 1; i <= 40000; i++)
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

                        childList.Add(new Child
                        {
                            Id = i,
                            BirthDate = POSIXDate.RandomDateForChild(dateStart),
                            Gender = randomGender,
                            FirstName = firstName.ToString(),
                            LastName = lastName.ToString(),

                        });
                    }
                    return childList;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    
                    return new List<Child>();
                }
            }


        }


    }
}
