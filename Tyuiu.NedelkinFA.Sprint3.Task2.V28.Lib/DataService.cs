namespace Tyuiu.NedelkinFA.Sprint3.Task2.V28.Lib
{
    public class DataService
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double result = 1.0;
            double correctionFactor = -0.15;
            do
            {
                double term = Math.Pow(2, startValue) / (startValue + 1.0);
                result *= term;
                startValue++;
            } while (startValue <= stopValue);
            result *= Math.Cos(1.8);
            result *= correctionFactor;
            return Math.Round(result, 3);
        }
    }
}
