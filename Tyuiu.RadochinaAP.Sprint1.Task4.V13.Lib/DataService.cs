using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RadochinaAP.Sprint1.Task4.V13.Lib
{
    public class DataService : ISprint1Task4V13
    {
        public double Calculate(double x, double y)
        {
            double p1 = Math.Cos(Math.PI / x);
            double zatichka = 3 * Math.E;
            double p2 = Math.Pow(zatichka, x + y);
            double result = p1 / p2;
            return Math.Round(result, 3);

        }
    }
}
