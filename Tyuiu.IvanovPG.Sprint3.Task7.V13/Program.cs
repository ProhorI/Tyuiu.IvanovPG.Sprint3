﻿

using Tyuiu.IvanovPG.Sprint3.Task7.V13.Lib;

namespace Tyuiu.IvanovPG.Sprint3.Task7.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: ИВАНОВ.П.Г | ИСТНБ-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: ИВАНОВ.П.Г | ИСТНБ-24-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая выводит таблицу значений функции            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение начала отрезка");
            int startValue;
            startValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение конца отрезка");
            int stopValue;
            stopValue = Convert.ToInt32(Console.ReadLine());

            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+-----------+-----------+");
            Console.WriteLine("|     X     |    f(x)   |");
            Console.WriteLine("+-----------+-----------+");

            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}      |  {1,7:f2}  |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+-----------+-----------+");
            Console.ReadKey();
        }
    }
}
