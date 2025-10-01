using Tyuiu.RadochinaAP.Sprint1.Task5.V7.Lib;
namespace Tyuiu.RadochinaAP.Sprint1.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double f = 30;
            var result = ds.AngleToHoursMinutes(f);
            Assert.AreEqual(1, result);
        }
    }
}
