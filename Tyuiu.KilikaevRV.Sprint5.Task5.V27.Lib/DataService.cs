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
            string content = File.ReadAllText(path);
            var numbers = content.Split(' ')
                .Where(item => double.TryParse(item, out double n))
                .Select(item => double.Parse(item))
                .Where(n => n % 5 == 0);

            return numbers.Any() ? Math.Round(numbers.Average(), 3) : 0;
        }
    }
}