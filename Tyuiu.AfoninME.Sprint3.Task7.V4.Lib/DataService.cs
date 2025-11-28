using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AfoninME.Sprint3.Task7.V4.Lib
{
    public class DataService : ISprint3Task7V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] result = new double[len];

            int index = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Cos(x) + x;

                if (denominator == 0)
                {
                    result[index] = 0;
                }
                else
                {
                    double fx = (2 * x + 6) / denominator - 3;
                    result[index] = Math.Round(fx, 2);
                }

                index++;
            }

            return result;
        }
    }
}