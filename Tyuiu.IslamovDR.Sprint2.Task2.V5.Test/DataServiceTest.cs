using Tyuiu.IslamovDR.Sprint2.Task2.V5.Lib;

namespace Tyuiu.IslamovDR.Sprint2.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 3;
            int y = 3;

            bool res = ds.CheckDotInShadedArea(x, y);

            Assert.IsTrue(res);
        }
    }
}