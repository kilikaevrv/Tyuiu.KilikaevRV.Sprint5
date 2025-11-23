using Tyuiu.KilikaevRV.Sprint5.Task3.V20.Lib;
using System.IO;

DataService ds = new DataService();
int x = 3;

string path = ds.SaveToFileTextData(x);

double result;
using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
{
    result = reader.ReadDouble();
}

Console.WriteLine($"x = {x}");
Console.WriteLine($"y(x) = {result:F3}");
Console.WriteLine($"Файл: {path}");