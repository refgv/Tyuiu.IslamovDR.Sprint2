using Tyuiu.IslamovDR.Sprint2.Task3.V14.Lib;

namespace Tyuiu.IslamovDR.Sprint2.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            Assert.AreEqual(-25, res);
        }
    }
}