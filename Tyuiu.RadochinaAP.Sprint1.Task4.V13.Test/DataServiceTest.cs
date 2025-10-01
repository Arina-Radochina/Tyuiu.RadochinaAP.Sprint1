using Tyuiu.RadochinaAP.Sprint1.Task4.V13.Lib;

namespace Tyuiu.RadochinaAP.Sprint1.Task4.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = 2;
            var result = ds.Calculate(x, y);
            Assert.AreEqual(0.005, result);

        }
    }
}
