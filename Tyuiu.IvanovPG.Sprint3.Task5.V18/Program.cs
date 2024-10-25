
using Tyuiu.IvanovPG.Sprint3.Task5.V18.Lib;

namespace Tyuiu.IvanovPG.Sprint3.Task5.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                   *");
            Console.WriteLine("**************************************************************************************");

            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 11;

            Console.WriteLine("переменная х = " + x);
            Console.WriteLine("начало 1" + startValue1);
            Console.WriteLine("конец 1" + stopValue1);
            Console.WriteLine("начало 2" + startValue2);
            Console.WriteLine("конец 2" + stopValue2);

            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                         *");
            Console.WriteLine("**************************************************************************************");

            Console.WriteLine("Сумма рада = " + ds.GetSumSumSeries( x,  startValue1,  startValue2,  stopValue1,  stopValue2));

            Console.ReadKey();

        }
    }
}