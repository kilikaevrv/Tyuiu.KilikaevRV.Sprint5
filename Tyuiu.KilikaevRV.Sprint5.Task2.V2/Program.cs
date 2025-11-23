using Tyutu.KilikaevRV.Sprint5.Task2.V2.Lib;

Console.WriteLine("Введите массив 3x3:");
int[,] matrix = new int[3, 3];

for (int i = 0; i < 3; i++)
{
    string[] values = Console.ReadLine().Split(' ');
    for (int j = 0; j < 3; j++)
        matrix[i, j] = int.Parse(values[j]);
}

DataService ds = new DataService();
string path = ds.SaveToFileTextData(matrix);

Console.WriteLine("\nРезультат:");
Console.WriteLine(File.ReadAllText(path));
Console.WriteLine($"Файл: {path}");