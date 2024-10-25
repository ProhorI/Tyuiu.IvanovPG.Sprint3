﻿
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.IvanovPG.Sprint3.Task6.V26.Lib
{
    public class DataService : ISprint3Task6V26
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x = 0;
            int sum = 0;
            for (x = startValue; x < stopValue; x++) 
            {
                for (int d = 1; d <= x; d++) 
                {
                    if (x % d == 0) 
                    {
                        sum++;
                    }
                }
            }
            return sum;
        }
    }
}
