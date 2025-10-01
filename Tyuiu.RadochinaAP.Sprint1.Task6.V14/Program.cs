using System;
using Tyuiu.RadochinaAP.Sprint1.Task6.V14.Lib;

namespace Tyuiu.RadochinaAP.Sprint1.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.Title = "Спринт 1 | Выполнила: Радочина А. П. | ПИНб-25-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #1                                                                    *");
            Console.WriteLine("* Тема: Работа со строками класс String                                        *");
            Console.WriteLine("* Задание #6                                                                   *");
            Console.WriteLine("* Вариант #14                                                                  *");
            Console.WriteLine("* Выполнила: Радочина Арина Павловна | ПИНб-25-1                               *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что                *");
            Console.WriteLine("* строка составлена только из строчных букв.                                   *");

            Console.WriteLine("Введите текст:");
            string input = Console.ReadLine();

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            bool result = dataService.CheckLowerCaseRusLetters(input);

            Console.WriteLine("Только строчные русские: " + result);

            Console.ReadKey();
        }
    }
}
