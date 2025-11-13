using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AfoninME.Sprint3.Task6.V13.Lib
{
    public class DataService : ISprint3Task6V13
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x, sum = 0;
            for (x = startValue; x <= stopValue; x++)
            {
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        if (d > 8)
                        {
                            sum += d;
                        }
                    }
                }
            }
            return sum;
        }
    }
}
