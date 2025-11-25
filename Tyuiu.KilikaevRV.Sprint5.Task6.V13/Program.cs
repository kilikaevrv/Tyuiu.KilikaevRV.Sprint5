using System;
using Tyuiu.KilikaevRV.Sprint5.Task6.V13.Lib;

namespace Tyuiu.KilikaevRV.Sprint5.Task6.V13
{
    class Program
    {
        static void Main()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V13.txt";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Количество удвоенных 'cc' = {ds.LoadFromDataFile(path)}");
            Console.ReadKey();
        }
    }
}