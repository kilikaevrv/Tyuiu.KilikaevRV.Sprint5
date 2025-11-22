using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KilikaevRV.Sprint5.Task1.V12.Lib;

    public class DataService : ISprint5Task1V12
    {
        public double CalculateFunction(int v)
        {
            throw new NotImplementedException();
        }

        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("╔══════════════════════════════╗");
                writer.WriteLine("║     Табулирование функции    ║");
                writer.WriteLine("╠═══════╦══════════════════════╣");
                writer.WriteLine("║   x   ║         f(x)         ║");
                writer.WriteLine("╠═══════╬══════════════════════╣");

                for (int x = startValue; x <= stopValue; x++)
                {
                    double value = CalculateFunction(x);
                    writer.WriteLine($"║ {x,5} ║ {value,20:F2} ║");
                }

                writer.WriteLine("╚═══════╩══════════════════════╝");
            }

            return path;
        }

    }