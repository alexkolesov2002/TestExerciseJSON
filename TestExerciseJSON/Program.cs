using TestExerciseJSON.Classes;
using TestExerciseJSON.Data.Mocks;
using TestExerciseJSON.Data.Models;

namespace TestExerciseJSON
{
    class Programm
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        async static Task Main()
        {

            try
            {
                Console.WriteLine("Hello world. I am - testing exersize for processing JSON file, my author Kolesov A.D.");
                Console.WriteLine("To continue, press any key");
                Console.ReadKey();

                MockPerson persons = new MockPerson();

                if (persons.Persons != null && persons.Persons is List<Person> _personsList)
                {
                    string PersonsInfoJson = JSONSerializePerson.SerializeJSON(_personsList);
                    _personsList.Clear();
                    GC.Collect();

                    if (PersonsInfoJson != null)
                    {
                        if (await Task.Run(() => JSONFileProcessing.WriteInFile(PersonsInfoJson)) == true)
                        {
                            string readResult = await JSONFileProcessing.ReadFile();
                            _personsList = JSONSerializePerson.DeserializeJSON(readResult);
                            RandomData.DisplayResult(_personsList);
                        }
                    }
                   
                }
                GC.Collect();
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.ToString());
            }
            finally
            {

                Console.WriteLine("Мне понравилось ваше задание, если вы не против, я напомню еще раз о себе, и попрошу что-то еще. :) Спасибо");

            }


        }

    }
    enum Gender
    {
        Male,
        Female
    }
}

