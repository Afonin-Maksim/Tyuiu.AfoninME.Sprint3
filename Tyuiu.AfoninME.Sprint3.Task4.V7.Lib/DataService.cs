using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AfoninME.Sprint3.Task4.V7.Lib
{
    public class DataService : ISprint3Task4V7
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    break;
                }
                else
                {
                    res = res * (x / Math.Cos(x) + 1.5);
                }
            }
            return Math.Round(res, 3);
        }
    }
}