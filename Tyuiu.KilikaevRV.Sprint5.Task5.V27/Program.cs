using System;
using Tyuiu.KilikaevRV.Sprint5.Task5.V27.Lib;

namespace Tyuiu.KilikaevRV.Sprint5.Task5.V27
{
    class Program
    {
        static void Main()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask5V27.txt";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Среднее = {ds.LoadFromDataFile(path)}");
            Console.ReadKey();
        }
    }
}