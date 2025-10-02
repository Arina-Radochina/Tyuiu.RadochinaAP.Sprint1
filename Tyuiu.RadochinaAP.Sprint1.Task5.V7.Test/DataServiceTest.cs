using System;
using Tyuiu.RadochinaAP.Sprint1.Task5.V7.Lib;
namespace Tyuiu.RadochinaAP.Sprint1.Task5.V7.Test
{
    [TestClass]
        public class DataSeviceTest
        {
        [TestMethod]
        public void TestMethod1()
        {
            double f = 90;
            DataService ds = new DataService();

            double res = ds.AngleToHoursMinutes(f);
            int h = Convert.ToInt32(res);
            Assert.AreEqual(3, h);
        }
    }
}
