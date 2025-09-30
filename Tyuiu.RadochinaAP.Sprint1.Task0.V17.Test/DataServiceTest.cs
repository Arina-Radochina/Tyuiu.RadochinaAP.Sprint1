using Tyuiu.RadochinaAP.Sprint1.Task0.V17.Lib;
namespace Tyuiu.RadochinaAP.Sprint1.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(5, res);
        }
    }
}
