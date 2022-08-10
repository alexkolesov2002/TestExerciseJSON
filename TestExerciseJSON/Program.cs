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
        async static Task Main()
        {

            try
            {
                Console.WriteLine("Привет мир. Я - тестовое задание на обработку JSON файла, мой автор Колесов А.Д.");
                Console.WriteLine("Для того что бы продолжить, нажмите любую клавишу");
                ////Console.ReadKey();
                MockPerson person = new MockPerson();
                JSONFileProcessing JSONFileProcessing = new JSONFileProcessing();
                if (person.Persons is List<Person> _personsList)
                {
                    JSONSerializePerson JSONSerializePerson = new JSONSerializePerson();
                    var s = JSONSerializePerson.SerializeJSON(_personsList);
                    _personsList.Clear();


                    if (await Task.Run(() => JSONFileProcessing.WriteInFile(s)) == true)
                    {
                        string notSerializeResult = await JSONFileProcessing.ReadFile();
                        _personsList = JSONSerializePerson.DeserializeJSON(notSerializeResult);
                        RandomData.DisplayResult(_personsList);
                        Console.ReadKey();
                    }
                }
                 
                


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

