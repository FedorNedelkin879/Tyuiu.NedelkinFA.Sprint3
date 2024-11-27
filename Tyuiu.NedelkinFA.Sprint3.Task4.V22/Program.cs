using Tyuiu.NedelkinFA.Sprint3.Task4.V22.Lib;

DataService ds = new DataService();
int startValue = -5;
int stopValue = 5;
Console.WriteLine("start " + startValue);
Console.WriteLine("stop " + stopValue);
Console.WriteLine("product = " + ds.Calculate(startValue, stopValue));
Console.ReadKey();
