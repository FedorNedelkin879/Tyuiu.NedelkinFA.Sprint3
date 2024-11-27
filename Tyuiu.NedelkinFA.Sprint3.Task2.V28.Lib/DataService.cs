using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NedelkinFA.Sprint3.Task2.V28.Lib
{
    public class DataService : ISprint3Task2V28
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double product = 1.0; 
            do
            {
                double term = Math.Pow(2, startValue) / (startValue + 1.0);
                product *= term; 
                startValue++;
            } while (startValue <= stopValue);

            product *= Math.Cos(1.8);

            return Math.Round(product, 3);
        }
    }
}
