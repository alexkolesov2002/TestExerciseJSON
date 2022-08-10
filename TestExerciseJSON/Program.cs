// See https://aka.ms/new-console-template for more information
using TestExerciseJSON.Classes;
using TestExerciseJSON.Data.Mocks;
using TestExerciseJSON.Data.Models;

namespace TestExerciseJSON
{
    class Programm
    {/// <summary>
     /// Входная точка программы
     /// </summary>
        static void Main()
        {
            try
            {
                Console.WriteLine("Привет мир. Я - тестовое задание на обработку CSV файла, мой автор Колесов А.Д.");
                Console.WriteLine("Для того что бы продолжить, нажмите любую клавишу");
                ////Console.ReadKey();
                MockPerson person = new MockPerson();
                List<Person> personsList = person.Persons as List<Person>;
                JSONSerializePerson jsonSerializePerson = new JSONSerializePerson();
                var s = jsonSerializePerson.SerializeJSON(personsList);
                personsList.Clear();

                JSONFileProcessing JSONFileProcessing = new JSONFileProcessing();
                JSONFileProcessing.WriteInFile(s);

                string notSerializeResult = JSONFileProcessing.ReadFile();
                personsList = jsonSerializePerson.DeserializeJSON(notSerializeResult) ;
                RandomData.DisplayResult(personsList);
                Console.ReadKey();



                GC.Collect();



            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex + "");
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

