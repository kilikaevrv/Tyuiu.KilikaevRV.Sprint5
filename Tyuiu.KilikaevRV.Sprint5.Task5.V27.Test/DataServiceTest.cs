using Tyuiu.KilikaevRV.Sprint5.Task5.V27.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

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

            File.WriteAllText(path, "-6 6 20 15.33 -0.67 11 4.06 -1.61 -9.48 -6 -4.93 -3.61 8 -1 17 19 19.92 8 -5 -3.35");

            Assert.AreEqual(7.5, ds.LoadFromDataFile(path));
        }
    }
}