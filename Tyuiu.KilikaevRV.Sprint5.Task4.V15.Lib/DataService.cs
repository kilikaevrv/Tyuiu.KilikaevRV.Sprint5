using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.KilikaevRV.Sprint5.Task4.V15.Lib
{
    public class DataService : ISprint5Task4V15
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            double x = double.Parse(text, CultureInfo.InvariantCulture);

            double y = Math.Sin(x) + (x * x / 2);
            return Math.Round(y, 3);
        }
    }
}