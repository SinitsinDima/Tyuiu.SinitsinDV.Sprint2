using Tyuiu.SinitsinDV.Sprint2.Task3.V1.Lib;
namespace Tyuiu.SinitsinDV.Sprint2.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds1 = new DataService();
            double x = 5;
            double res = ds1.Calculate(x);
            double wait = 88.697;
            Assert.AreEqual(wait, res);
        }


        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds2 = new DataService();
            double x = 2;
            double res = ds2.Calculate(x);
            double wait = 9.5;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds3 = new DataService();
            double x = 1;
            double res = ds3.Calculate(x);
            double wait = 10;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds4 = new DataService();
            double x = -6;
            double res = ds4.Calculate(x);
            double wait = -65.995;
            Assert.AreEqual(wait, res);
        }
    }
}