
using Tyuiu.IvanovPG.Sprint3.Task5.V18.Lib;

namespace Tyuiu.IvanovPG.Sprint3.Task5.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetSumSumSeries()
        {

            DataService ds = new DataService();
            int x = 5;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 11;

            double res = ds.GetSumSumSeries(x,startValue1, startValue2, stopValue1, stopValue2);

            double wait = 25.861;

            Assert.AreEqual(wait,res);

        }
    }
}