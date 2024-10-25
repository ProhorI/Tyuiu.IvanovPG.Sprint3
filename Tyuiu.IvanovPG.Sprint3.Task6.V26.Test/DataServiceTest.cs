
using Tyuiu.IvanovPG.Sprint3.Task6.V26.Lib;

namespace Tyuiu.IvanovPG.Sprint3.Task6.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 15;
            int stopValue = 22;

            double res = ds.GetSumTheDivisors(startValue, stopValue);

            double wait = 33;
        }
    }
}