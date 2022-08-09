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
            //try
            //{
                Console.WriteLine("Привет мир. Я - тестовое задание на обработку CSV файла, мой автор Колесов А.Д.");
                Console.WriteLine("Для того что бы продолжить, нажмите любую клавишу");
                //Console.ReadKey();
                MockChild mockChild = new MockChild();
                List<Child> children = mockChild.Children as List<Child>;
                //for (int i = 0; i <= 100; i++)
                //{
                //    Console.Clear();
                //    Console.WriteLine("Подождите идет выполнение программы");
                //    Console.WriteLine(i + "%");
                //    Thread.Sleep(10);  // в будущем ( если необходимо) можно добавить многопоточность

                //}

            //}
            //catch (Exception ex)
            //{
            //    Console.Clear();
            //    Console.WriteLine(ex + "");
            //}
            //finally
            //{

            //    Console.WriteLine("Мне понравилось ваше задание, если вы не против, я напомню еще раз о себе, и попрошу что-то еще. :) Спасибо");
            //    Console.WriteLine("Файл с данными находится в папке Debug, с названием ResultInformation");
            //}

        }

    }
    enum Gender
    {
        Male,
        Female
    }
}

