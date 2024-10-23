using Tyuiu.IvanovPG.Sprint3.Task0.V11.Lib;

namespace Tyuiu.IvanovPG.Sprint3.Task0.V.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            double wait = 0.042;

            Assert.AreEqual(wait, res);
        }
    }
}