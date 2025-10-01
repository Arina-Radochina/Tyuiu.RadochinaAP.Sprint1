namespace Tyuiu.RadochinaAP.Sprint1.Task5.V7.Lib
{
    public class DataService : ISprint1Task5V7
    {
        public double AngleToHoursMinutes(double f)
        {
            int h = (f / 30);
            return h;
            
        }
    }
}
   