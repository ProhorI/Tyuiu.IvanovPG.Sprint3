namespace Tyuiu.IvanovPG.Sprint3.Task0.V11.Lib;

using tyuiu.cources.programming.interfaces.Sprint3;

{
    public class DataService : ISprint3Task0V11
{
    public double GetSumSeries(int value, int startValue, int stopValue)
    {
        double sumSeries = 0;
        int i;
        for (i = startValue; i <= stopValue; i++)
        {
            sumSeries = sumSeries + Math.Pow((1 / Math.Pow(value, i)), 2);
        }
        return Math.Round(sumSeries, 3);
    }
}

//Math.Pow((1 / Math.Pow(n, k)), 2)
//sumSeries = sumSeries + ((1 / Math.Sin(i)) + value);
//Math.Pow( (1 / Math.Pow(value, k)), 2)