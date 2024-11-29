using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NedelkinFA.Sprint3.Task7.V7.Lib
{
    public class DataService : ISprint3Task7V7
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double y;
                if (x + 2 == 0) 
                {
                    y = 0.0;
                }
                else
                {
                    double term2 = Math.Cos(x) / (x + 2);
                    y = Math.Cos(x) + term2 - 3 * x;
                }

                if (x == -1)
                {
                    y = 0.0;
                }

                valueArray[count] = Math.Round(y, 2);
                count++;
            }
            return valueArray;
        }


    }
}
