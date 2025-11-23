using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KilikaevRV.Sprint5.Task3.V20.Lib;
using System.IO;

namespace Tyuiu.KilikaevRV.Sprint5.Task3.V20.Test
{
    [TestClass]
    public class DataServiceTests
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(3);

            double fileContent;
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                fileContent = reader.ReadDouble();
            }

            double wait = 0.866;
            Assert.AreEqual(wait, fileContent);
        }
    }
}