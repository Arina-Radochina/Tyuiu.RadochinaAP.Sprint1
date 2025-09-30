using Tyuiu.RadochinaAP.Sprint1.Task1.V14.Lib;

namespace Tyuiu.RadochinaAP.Sprint1.Task1.V14.Test
{
    public class DataServiceTest
    {
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 259;
            var res = ds.ConvertKelvinToCelsius(x);
            Assert.AreEqual(-14, res);
        }
    }
}