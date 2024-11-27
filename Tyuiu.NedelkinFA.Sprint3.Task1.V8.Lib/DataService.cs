using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NedelkinFA.Sprint3.Task1.V8.Lib
{
    public class DataService : ISprint3Task1V8
    {
        public string GetMultiplySeries(double value, int startValue, int stopValue)
        {
            throw new NotImplementedException();
        }

        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double multSeries = 1;
            while (startValue <= stopValue)
            {
                double denominator = Math.Cos(startValue) + Math.Pow(value, startValue);
                if (denominator == 0) throw new DivideByZeroException("Знаменатель стал равен нулю!");
                multSeries *= Math.Pow((1 / denominator), startValue);
                startValue++;
            }
            return Math.Round(multSeries, 3);
        }
    }
}
