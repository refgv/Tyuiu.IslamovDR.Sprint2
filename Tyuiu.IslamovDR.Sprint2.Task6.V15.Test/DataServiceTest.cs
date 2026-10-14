using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.IslamovDR.Sprint2.Task6.V15.Lib;

namespace Tyuiu.IslamovDR.Sprint2.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayOfWeek()
        {
            DataService ds = new DataService();

            Assert.AreEqual("понедельник", ds.FindDayName(1));
            Assert.AreEqual("вторник", ds.FindDayName(2));
            Assert.AreEqual("воскресенье", ds.FindDayName(7));
            Assert.AreEqual("понедельник", ds.FindDayName(8));
        }
    }
}