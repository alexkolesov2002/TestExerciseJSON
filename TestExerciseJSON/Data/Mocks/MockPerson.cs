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
    class MockPerson : IPersonData
    {
        public IEnumerable<Person> Persons {



            get
            {
                List<Person> personsList = new List<Person>();
                Array values = Enum.GetValues(typeof(Gender));
                Random random = new Random();
                DateTime dateStart = new DateTime(1971, 1, 1);
                MockChild mockChild = new MockChild();
                List<Child> children = mockChild.Children as List<Child>;

                long POSIXTime;
                for (int i = 1; i <= 10000; i++)
                {
                    POSIXTime = POSIXDate.RandomDateForPerson(dateStart);
                    StringBuilder firstName = new StringBuilder();
                    StringBuilder lastName = new StringBuilder();
                    Gender randomGender = (Gender)values.GetValue(random.Next(values.Length));

                    Child[] PersonChildren = new Child[random.Next(1,4)];
                    string[] PersonPhones = new string [random.Next(1, 4)];
                    string[] PersonCreditCardNumber = new string [random.Next(1, 4)];
                   
                    for (int j = 0; j < PersonChildren.Length; j++)
                    {
                        int childId = random.Next(0, children.Count-1);
                        PersonChildren[j] = children[childId];
                        children.RemoveAt(childId);
                    }

                    for (int x = 0; x < PersonPhones.Length; x++)
                    {
                        PersonPhones[x] = RandomData.CreatePhoneNumber();
                    }

                    for (int x = 0; x < PersonCreditCardNumber.Length; x++)
                    {
                        PersonCreditCardNumber[x] = RandomData.CreateCreditCardNumber();
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
                    DateTime asDateTime = new UnixTimestamp(POSIXTime);

                    //int dur = (int)DateTime.Now.Month - (int)TimeSpan.FromSeconds(POSIXTime).TotalDays / 365 * 12 - 1970 * 12;
                    //int age;
                    //if (dur > 0)
                    //{
                    //    age = (int)DateTime.Now.Year - (int)TimeSpan.FromSeconds(POSIXTime).TotalDays / 365 - 1970;

                    //}
                    //else
                    //{
                    //    age = (int)DateTime.Now.Year - (int)TimeSpan.FromSeconds(POSIXTime).TotalDays / 365 - 1970 - 1;
                    //}
                    personsList.Add(new Person
                    {
                        Id = i,
                        BirthDate = POSIXTime,
                        Gender = randomGender,
                        FirstName = firstName.ToString(),
                        LastName = lastName.ToString(),
                        Age = POSIXDate.GetDifferenceInYears(asDateTime, DateTime.Now),
                        TransportId = Guid.NewGuid(),
                        IsMarred = random.Next(1) == 0,
                        Salary = Convert.ToDouble(random.Next(150000, 1000000)/10.0),
                        SequenceId =  i-1,
                        Children = PersonChildren,
                        Phones = PersonPhones,
                        CreditCardNumbers = PersonCreditCardNumber


                    });;
                }
                return personsList;
            }





        }

        
    }
}
