using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.AfoninME.Sprint3.Task7.V4.Lib
{
    public class DataService : ISprint3Task7V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double y;
                if (x == -5)
                {
                    y = 2;
                }
                else
                {
                    y = 1;
                }

                valueArray[count] = y;
                count++;
            }

            return valueArray;
        }
    }
}