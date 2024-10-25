
using Tyuiu.IvanovPG.Sprint3.Task4.V25.Lib;

namespace Tyuiu.IvanovPG.Sprint3.Task4.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                   *");
            Console.WriteLine("**************************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            //Console.WriteLine("переменная х = " + value);
            Console.WriteLine("начало" + startValue);
            Console.WriteLine("конец" + stopValue);

            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                         *");
            Console.WriteLine("**************************************************************************************");

            Console.WriteLine("Сумма рада = " + ds.Calculate(startValue, stopValue));

            Console.ReadKey();

        }
    }
}