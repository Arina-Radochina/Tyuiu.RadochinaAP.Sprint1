using Tyuiu.RadochinaAP.Sprint1.Task3.V16.Lib;

namespace Tyuiu.RadochinaAP.Sprint1.Task1.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт 1 | Выполнила: Радочина А. П. | ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифмитические операторы в C#                                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнила: Радочина Арина Павловна | ПИНб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x1;
            double x2;
            Console.WriteLine("Введите значение x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение X2: ");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Коэффицент квадратного уравнения = " + ds.CoeffOfQuadraticEquation(x1, x2));
        }
    }
}
