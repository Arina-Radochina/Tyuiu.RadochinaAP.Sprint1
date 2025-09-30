using Tyuiu.RadochinaAP.Sprint1.Task3.V16.Lib;

namespace Tyuiu.RadochinaAP.Sprint1.Task3.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = -12.345;
            double x2 = -3.210;
            double wait = 15.555;
            var res = ds.CoeffOfQuadraticEquation(x1, x2);
            Assert.AreEqual(wait, res);

        }
    }
}
