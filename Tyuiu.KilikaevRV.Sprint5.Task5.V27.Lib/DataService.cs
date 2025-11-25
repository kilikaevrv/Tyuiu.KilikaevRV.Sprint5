using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KilikaevRV.Sprint5.Task5.V27.Lib
{
    public class DataService : ISprint5Task5V27
    {
        public double LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            var numbers = lines.Where(line => int.TryParse(line, out int n) && n % 5 == 0)
                              .Select(int.Parse).ToList();

            return numbers.Count > 0 ? Math.Round(numbers.Average(), 3) : 0;
        }
    }
}