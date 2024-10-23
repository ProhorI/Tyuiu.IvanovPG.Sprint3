using Tyuiu.IvanovPG.Sprint3.Task2.V1.Lib;

namespace Tyuiu.IvanovPG.Sprint3.Task2.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                   *");
            Console.WriteLine("**************************************************************************************");

            int startValue = 1;
            int stopValue = 10;

            //Console.WriteLine("переменная х = " + value);
            Console.WriteLine("старт шага" + startValue);
            Console.WriteLine("конец шага" + stopValue);

            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                         *");
            Console.WriteLine("**************************************************************************************");

            Console.WriteLine("Сумма рада = " + ds.GetSumSeries(startValue, stopValue));

            Console.ReadKey();

        }
    }
}