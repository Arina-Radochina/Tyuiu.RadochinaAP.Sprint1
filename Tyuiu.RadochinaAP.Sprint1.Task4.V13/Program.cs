using Tyuiu.RadochinaAP.Sprint1.Task4.V13.Lib;

namespace Tyuiu.RadochinaAP.Sprint1.Task4.V13
{
    class Program
    {
        static void Main(string[] args)
        {
                DataService ds = new DataService();

                Console.Title = "Спринт 1 | Выполнила: Радочина А. П. | ПИНб-25-1";
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* Спринт #1                                                               *");
                Console.WriteLine("* Тема: Class Math                                    *");
                Console.WriteLine("* Задание #4                                                              *");
                Console.WriteLine("* Вариант #13                                                             *");
                Console.WriteLine("* Выполнила: Радочина Арина Павловна | ПИНб-25-1                          *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* УСЛОВИЕ:                                                                *");
                Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
                Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
                Console.WriteLine("*                                                                         *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
                Console.WriteLine("***************************************************************************");

               double p1;
               Console.WriteLine("Введите значение P1: ");
               p1 = Convert.ToDouble(Console.ReadLine());

               double p2;
               Console.WriteLine("Введите значение P2: ");
               p2 = Convert.ToDouble(Console.ReadLine());

               Console.WriteLine("**************************************************************************");
               Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
               Console.WriteLine("**************************************************************************");

               Console.WriteLine(ds.Calculate(p1,p2));
               Console.ReadKey();



        }
    }
}
