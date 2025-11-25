using Tyuiu.KilikaevRV.Sprint5.Task6.V13.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Tyuiu.KilikaevRV.Sprint5.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V13.txt";

            File.WriteAllText(path, "acccb ccdd cc cc");
            int result = ds.LoadFromDataFile(path);
            int wait = 5; // "acc c b  cc dd  cc   cc" - 5 удвоенных "cc"

            Assert.AreEqual(wait, result);
        }
    }
}