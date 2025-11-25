using System;
using System.IO;
using Tyuiu.KilikaevRV.Sprint5.Task6.V13.Lib;

namespace Tyuiu.KilikaevRV.Sprint5.Task6.V13
{
    class Program
    {
        static void Main()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V13.txt";
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
                Console.WriteLine($"Содержимое файла: '{content}'");
                Console.WriteLine($"Длина текста: {content.Length}");

                int result = ds.LoadFromDataFile(path);
                Console.WriteLine($"Количество удвоенных 'cc' = {result}");
            }
            else
            {
                Console.WriteLine("Файл не найден! Создайте файл вручную.");
            }

            Console.ReadKey();
        }
    }
}