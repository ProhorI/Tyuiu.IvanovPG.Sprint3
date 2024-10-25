

using Tyuiu.IvanovPG.Sprint3.Task6.V26.Lib;

namespace Tyuiu.IvanovPG.Sprint3.Task6.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                   *");
            Console.WriteLine("**************************************************************************************");


            int startValue = 15;
            int stopValue = 22;

            Console.WriteLine("начало " + startValue);
            Console.WriteLine("конец " + stopValue);


            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                         *");
            Console.WriteLine("**************************************************************************************");

            Console.WriteLine("количетсов делителей на отрезке ровно = " + ds.GetSumTheDivisors(startValue, stopValue));

            Console.ReadKey();

        }
    }
}