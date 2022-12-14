using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestExerciseJSON.Classes;
using TestExerciseJSON.Data.Interfaces;
using TestExerciseJSON.Data.Models;

namespace TestExerciseJSON.Data.Mocks
{
    /// <summary>
    ///Class for populating a collection with objects of type Person
    /// </summary>
    class MockPerson : IPersonData
    {
        /// <summary>
        /// Property that represents a collection of objects of type Person
        /// </summary>
        public IEnumerable<Person> Persons
        {

            get
            {
                try
                {


                    List<Person> personsList = new List<Person>();
                    Array valuesGender = Enum.GetValues(typeof(Gender));
                    Random random = new Random();
                    DateTime dateStart = new DateTime(1940, 1, 1); //Minimum date of birth of person
                    MockChild mockChild = new MockChild();
                    if (mockChild.Children is List<Child> childrenList)
                    {

                        long POSIXTime;
                        for (int i = 1; i <= 10000; i++)
                        {
                            POSIXTime = POSIXDate.RandomDateForPerson(dateStart);

                            StringBuilder firstName = new StringBuilder();
                            StringBuilder lastName = new StringBuilder();

                            Gender randomGender = (Gender)valuesGender.GetValue(random.Next(valuesGender.Length));

                            Child[] personChildren = new Child[random.Next(1, 4)];
                            string[] personPhones = new string[random.Next(1, 4)];
                            string[] personCreditCardNumber = new string[random.Next(1, 4)];

                            for (int j = 0; j < personChildren.Length; j++) // Filling an array of children with data from the created collection
                            {
                                int childId = random.Next(0, childrenList.Count - 1);
                                personChildren[j] = childrenList[childId];
                                childrenList.RemoveAt(childId); //For each collection object of type Person there will be a unique array of Child objects
                            }

                            for (int x = 0; x < personPhones.Length; x++) //Filling an array of phone numbers with random data 
                            {
                                personPhones[x] = RandomData.CreatePhoneNumber();
                            }

                            for (int x = 0; x < personCreditCardNumber.Length; x++)
                            {
                                personCreditCardNumber[x] = RandomData.CreateCreditCardNumber();
                            }

                            if (randomGender == Gender.Male)
                            {
                                firstName.Append(RandomData._maleNames[new Random().Next(0, RandomData._maleNames.Length)]);
                            }

                            else if (randomGender == Gender.Female)
                            {
                                firstName.Append(RandomData._femaleNames[new Random().Next(0, RandomData._femaleNames.Length)]);
                            }

                            lastName.Append(RandomData._lastNames[new Random().Next(0, RandomData._lastNames.Length)]);
                            DateTime asDateTime = new UnixTimestamp(POSIXTime); //Using a third party library unixtimestamp\1.0.0\


                            personsList.Add(new Person
                            {
                                Id = i,
                                BirthDate = POSIXTime,
                                Gender = randomGender,
                                FirstName = firstName.ToString(),
                                LastName = lastName.ToString(),
                                Age = POSIXDate.GetDifferenceInYears(asDateTime, DateTime.Now),
                                TransportId = Guid.NewGuid(),
                                IsMarred = random.Next(0, 3) == 0,
                                Salary = Convert.ToDouble(random.Next(150000, 1000000) / 10.0),
                                SequenceId = i - 1,
                                Children = personChildren,
                                Phones = personPhones,
                                CreditCardNumbers = personCreditCardNumber


                            });
                        }
                    }

                    return personsList;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return new List<Person>();
                }
            }


        }




    }
}
