using Tyuiu.RadochinaAP.Sprint1.Task1.V26.Lib;

namespace Tyuiu.RadochinaAP.Sprint1.Task1.V26.Test
{
    public class DataServiceTest
    {
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(5, res);
        }
    }
}