using Tyuiu.IvanovPG.Sprint3.Task1.V28.Lib;

namespace Tyuiu.IvanovPG.Sprint3.Task1.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                   *");
            Console.WriteLine("**************************************************************************************");

            double value = 0.5;
            int startValue = 1;
            int stopValue = 18;

            Console.WriteLine("переменная х = " + value);
            Console.WriteLine("старт шага" + startValue);
            Console.WriteLine("конец шага" + stopValue);

            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                         *");
            Console.WriteLine("**************************************************************************************");

            Console.WriteLine("Сумма рада = " + ds.GetSumSeries(value, startValue, stopValue));

            Console.ReadKey();

        }
    }
}