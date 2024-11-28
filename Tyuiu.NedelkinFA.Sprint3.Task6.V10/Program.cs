using Tyuiu.NedelkinFA.Sprint3.Task6.V10.Lib;

DataService ds = new DataService();
int startValue = 10;
int stopValue = 15;
Console.WriteLine("nach otr " + startValue);
Console.WriteLine("konec otr " + stopValue);
Console.WriteLine("sum del = " + ds.GetSumTheDivisors(startValue, stopValue));
Console.ReadKey();