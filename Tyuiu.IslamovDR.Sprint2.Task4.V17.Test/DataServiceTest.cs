using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.IslamovDR.Sprint2.Task4.V17.Lib;

namespace Tyuiu.IslamovDR.Sprint2.Task4.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateCondition1()
        {
            DataService ds = new DataService();
            double x = 30;
            double y = 4;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(1297.921, res);
        }

        [TestMethod]
        public void ValidCalculateCondition2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 4;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(4.12, res);
        }
    }
}