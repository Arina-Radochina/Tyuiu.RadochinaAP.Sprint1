using Tyuiu.RadochinaAP.Sprint1.Task7.V21.Lib;

namespace Tyuiu.RadochinaAP.Sprint1.Task7.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 6;
            double wait = -106.347;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}
