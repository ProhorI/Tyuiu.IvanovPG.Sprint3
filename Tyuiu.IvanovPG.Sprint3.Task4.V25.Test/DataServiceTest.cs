
using Tyuiu.IvanovPG.Sprint3.Task4.V25.Lib;

namespace Tyuiu.IvanovPG.Sprint3.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            double wait = -0.724;

            Assert.AreEqual(wait, res);

        }
    }
}