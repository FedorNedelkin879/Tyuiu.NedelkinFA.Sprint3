using Tyuiu.NedelkinFA.Sprint3.Task3.V17.Lib;

DataService ds = new DataService();
string value = "*vn98n! b,";
Console.WriteLine("Исходная строка: " + value);
Console.WriteLine("Число: " + ds.ConvertStringToInt(value));
Console.ReadKey();
