using Tyuiu.IvanovPG.Sprint3.Task2.V1.Lib;

namespace Tyuiu.IvanovPG.Sprint3.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            //double value = 0.5;
            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetSumSeries(startValue, stopValue);

            double wait = 0.353;

            Assert.AreEqual(wait, res);
        }
    }
}