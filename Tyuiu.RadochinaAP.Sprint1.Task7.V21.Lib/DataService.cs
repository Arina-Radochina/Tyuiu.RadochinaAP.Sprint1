using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RadochinaAP.Sprint1.Task7.V21.Lib
{
    public class DataService : ISprint1Task7V21
    {

        public double Calculate(double x, double y)
        {
            double term1 = Math.Pow(y, x) / (Math.Cos(x) - x / 3.0);
            double numerator = Math.Sin(x * x) + Math.Cos(y);
            double denominator = Math.Cos(x) - Math.Sin(y);
            double term2 = (numerator / denominator) * Math.Tan(x * y);

            double res = term1 + term2;
            return Math.Round(res,3);
        }
    }
}
