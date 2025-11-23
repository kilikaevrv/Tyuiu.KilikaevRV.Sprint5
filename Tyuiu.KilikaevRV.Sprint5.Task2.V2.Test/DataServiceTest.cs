using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyutu.KilikaevRV.Sprint5.Task2.V2.Lib;

namespace Tyutu.KilikaevRV.Sprint5.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTests
    {
        [TestMethod]
        public void SaveToFileTextDataValid()
        {
            int[,] matrix = {
                { -7, 7, 5 },
                { 4, 2, -7 },
                { 2, 6, -4 }
            };

            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(matrix);

            string result = File.ReadAllText(path);
            string expected = "0;1;1\r\n1;1;0\r\n1;1;0";

            Assert.AreEqual(expected, result);
        }
    }
}