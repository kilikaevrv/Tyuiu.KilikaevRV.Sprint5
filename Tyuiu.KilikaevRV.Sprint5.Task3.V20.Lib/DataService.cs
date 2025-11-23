using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KilikaevRV.Sprint5.Task3.V20.Lib
{
    public class DataService : ISprint5Task3V20
    {
        public string SaveToFileTextData(int x)
        {
            double y = x / Math.Sqrt(x * x + x);
            double result = Math.Round(y, 3);

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write(result);
            }

            return path;
        }
    }
}