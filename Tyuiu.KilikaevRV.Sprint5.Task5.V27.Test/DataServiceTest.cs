using Tyuiu.KilikaevRV.Sprint5.Task5.V27.Lib;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.KilikaevRV.Sprint5.Task5.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask5V27.txt";

            File.WriteAllLines(path, new[] { "10", "15", "25", "30", "7", "20" });
            double result = ds.LoadFromDataFile(path);
            double wait = 20.0; // (10+15+25+30+20)/5 = 20

            Assert.AreEqual(wait, result);
        }
    }
}