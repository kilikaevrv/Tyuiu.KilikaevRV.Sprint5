using Tyuiu.KilikaevRV.Sprint5.Task4.V15.Lib;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.KilikaevRV.Sprint5.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = @"InPutDataFileTask4V15.txt";

            File.WriteAllText(path, "2.0");
            double result = ds.LoadFromDataFile(path);
            double wait = 2.909;

            Assert.AreEqual(wait, result);

            if (File.Exists(path))
                File.Delete(path);
        }
    }
}