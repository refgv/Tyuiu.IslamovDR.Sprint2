using Tyuiu.IslamovDR.Sprint2.Task0.V8.Lib;

namespace Tyuiu.IslamovDR.Sprint2.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 185;
            int y = 251;
            bool[] wait = new bool[6] { true, false, true, false, true, false };

            bool[] res = ds.GetCompareOperations(x, y);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}