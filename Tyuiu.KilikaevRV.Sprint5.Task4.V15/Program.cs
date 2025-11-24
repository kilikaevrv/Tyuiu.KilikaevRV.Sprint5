using System;
using Tyuiu.KilikaevRV.Sprint5.Task4.V15.Lib;

namespace Tyuiu.KilikaevRV.Sprint5.Task4.V15
{
    class Program
    {
        static void Main()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask4V15.txt";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            double result = ds.LoadFromDataFile(path);
            Console.WriteLine($"y = {result}");
            Console.ReadKey();
        }
    }
}