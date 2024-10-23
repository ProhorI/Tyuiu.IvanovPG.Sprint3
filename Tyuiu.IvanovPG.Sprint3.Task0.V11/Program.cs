using Tyuiu.IvanovPG.Sprint3.Task0.V11.Lib;

namespace Tyuiu.IvanovPG.Sprint3.Task0.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                   *");
            Console.WriteLine("**************************************************************************************");

            int value = 5;
            int startValue = 1;
            int stopValue = 10;

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