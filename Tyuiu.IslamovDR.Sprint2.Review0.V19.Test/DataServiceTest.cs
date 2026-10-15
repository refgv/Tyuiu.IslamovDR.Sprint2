using Tyuiu.IslamovDR.Sprint2.Review0.V19.Lib;

namespace Tyuiu.IslamovDR.Sprint2.Review0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 0;

            bool res = ds.CheckDotInShadedArea(x, y);

            Assert.IsTrue(res);
        }
    }
}