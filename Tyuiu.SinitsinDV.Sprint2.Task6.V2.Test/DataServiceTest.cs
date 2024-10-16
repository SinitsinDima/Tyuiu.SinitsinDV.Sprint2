using Tyuiu.SinitsinDV.Sprint2.Task6.V2.Lib;
namespace Tyuiu.SinitsinDV.Sprint2.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 3;
            var wait = "Весна";
            string res = ds.FindMonthSeason(value);
            Assert.AreEqual(wait, res);
        }
    }
}