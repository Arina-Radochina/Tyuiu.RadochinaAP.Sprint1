using Tyuiu.RadochinaAP.Sprint1.Task5.V7.Lib;
namespace Tyuiu.RadochinaAP.Sprint1.Task5.V7
{
        class Program
        {
            static void Main(string[] args)
            {
                DataService ds = new DataService();

                Console.Title = "Спринт 1 | Выполнила: Радочина А. П. | ПИНб-25-1";
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* Спринт #1                                                               *");
                Console.WriteLine("* Тема: Преобразование типов и классов                                                        *");
                Console.WriteLine("* Задание #5                                                              *");
                Console.WriteLine("* Вариант #7                                                             *");
                Console.WriteLine("* Выполнила: Радочина Арина Павловна | ПИНб-25-1                          *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("*                                                                         *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
                Console.WriteLine("***************************************************************************");

                double x;
                Console.WriteLine("Введите значение X: ");
                x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("**************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("**************************************************************************");

                Console.WriteLine($"{ds.AngleToHoursMinutes(x)}");
                Console.ReadKey();



        }
        }
    }


