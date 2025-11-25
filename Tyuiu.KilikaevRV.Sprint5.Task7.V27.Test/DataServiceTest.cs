using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KilikaevRV.Sprint5.Task7.V27.Lib;

namespace Tyuiu.KilikaevRV.Sprint5.Task7.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadDataAndSave()
        {
            string path = @"C:\DataSprints\InPutDataFileTask7V27.txt";

            // Создаем тестовый файл с пробелами
            Directory.CreateDirectory(@"C:\DataSprints\");
            string testContent = "Это строка с пробелами";
            File.WriteAllText(path, testContent);

            DataService ds = new DataService();
            string tempFile = ds.LoadDataAndSave(path);

            // Проверяем что файл создан
            Assert.IsTrue(File.Exists(tempFile));

            // Читаем результат
            string result = File.ReadAllText(tempFile);
            string expected = "Этострокаспробелами"; // Без пробелов!

            // Проверяем что ВСЕ пробелы удалены
            Assert.AreEqual(expected, result);

            // Очистка
            File.Delete(tempFile);
        }

        [TestMethod]
        public void TestWithMultipleSpaces()
        {
            string path = @"C:\DataSprints\TestFile.txt";

            string testContent = "Много    пробелов     здесь";
            File.WriteAllText(path, testContent);

            DataService ds = new DataService();
            string tempFile = ds.LoadDataAndSave(path);

            string result = File.ReadAllText(tempFile);
            string expected = "Многопробеловздесь";

            Assert.AreEqual(expected, result);

            File.Delete(tempFile);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void InvalidPathTest()
        {
            DataService ds = new DataService();
            ds.LoadDataAndSave(@"C:\Nonexistent\File.txt");
        }
    }
}