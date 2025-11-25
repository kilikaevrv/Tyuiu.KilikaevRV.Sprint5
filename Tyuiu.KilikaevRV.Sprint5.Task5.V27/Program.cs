using System;
using System.IO;
using Tyuiu.KilikaevRV.Sprint5.Task5.V27.Lib;

namespace Tyuiu.KilikaevRV.Sprint5.Task5.V27
{
    class Program
    {
        static void Main()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V27.txt";
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            // Отладка
            Console.WriteLine($"Путь: {path}");
            Console.WriteLine($"Файл существует: {File.Exists(path)}");

            if (File.Exists(path))
            {
                string content = File.ReadAllText(path);
                Console.WriteLine($"Содержимое файла:\n{content}");
            }

            double result = ds.LoadFromDataFile(path);
            Console.WriteLine($"Среднее = {result}");
            Console.ReadKey();
        }
    }
}