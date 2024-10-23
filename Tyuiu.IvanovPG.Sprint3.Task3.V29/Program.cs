using Tyuiu.IvanovPG.Sprint3.Task3.V29.Lib;

namespace Tyuiu.IvanovPG.Sprint3.Task3.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("###########################################################################");
            Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
            Console.WriteLine("###########################################################################");

            string value = "chgr vhhtg hnht";
            char item = 'h';

            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Удаляемый символ = " + item);

            Console.WriteLine("###########################################################################");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");

            Console.WriteLine("Преобразованная строка = " + ds.DeleteCharInString(value, item));
            Console.ReadKey();

        }
    }
}