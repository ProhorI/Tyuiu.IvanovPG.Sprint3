using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.IvanovPG.Sprint3.Task3.V29.Lib
{
    public class DataService : ISprint3Task3V29
    {
        public string DeleteCharInString(string value, char item)
        {
            string delString = "";

            foreach (char h in value)
            {
                if (h == item) continue;
                else delString += h;
            }
            return delString;
        }
    }
}
//public double GetSumSeries(int startValue, int stopValue)
//{
//    double sumSeries = 0;
//    do
//    {
//        sumSeries = sumSeries + (Math.Sin(startValue) * (Math.Pow((0.5), 2)));
//        startValue++;
//    } while (startValue <= stopValue);
//    return Math.Round(sumSeries, 3);
//}