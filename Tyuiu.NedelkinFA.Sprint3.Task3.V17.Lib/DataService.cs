using tyuiu.cources.programming.interfaces.Sprint3;
using System;

namespace Tyuiu.NedelkinFA.Sprint3.Task3.V17.Lib
{
    public class DataService : ISprint3Task3V17
    {
        public int ConvertStringToInt(string value)
        {
            string digitsOnly = "";
            foreach (char chr in value)
            {
                if (char.IsDigit(chr))
                {
                    digitsOnly += chr;
                }
            }

            return string.IsNullOrEmpty(digitsOnly) ? 0 : int.Parse(digitsOnly);
        }
    }
}
