using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KilikaevRV.Sprint5.Task1.V12.Lib
{
    public class DataService : ISprint5Task1V12
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "OutPutFileTask1.txt");

            using (StreamWriter writer = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                for (int x = startValue; x <= stopValue; x++)
                {
                    double value = CalculateFunction(x);
                    writer.WriteLine($"{value:F2}");
                }
            }

            return path;
        }

        public double CalculateFunction(int x)
        {
            double denominator = Math.Sin(x) - 2;

            // Проверка деления на ноль
            if (Math.Abs(denominator) < 0.0001)
            {
                return 0;
            }

            double numerator = 5 * x + 2.5;
            double result = numerator / denominator + 2;

            return Math.Round(result, 2);
        }
    }
}