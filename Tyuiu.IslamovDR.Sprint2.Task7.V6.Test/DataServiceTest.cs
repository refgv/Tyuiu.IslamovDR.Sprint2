using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.IslamovDR.Sprint2.Task7.V6.Lib;

namespace Tyuiu.IslamovDR.Sprint2.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 1.0;

            bool res = ds.CheckDotInShadedArea(x, y);

            Assert.IsTrue(res);
        }
    }
}