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

            // Создаем тестовый файл если его нет
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(@"C:\DataSprints\");
                string testContent = "Hello     world!    This    is    a    test    with    multiple    spaces.";
                File.WriteAllText(path, testContent);
            }

            DataService ds = new DataService();
            string tempFile = ds.LoadDataAndSave(path);

            // Проверяем что файл создан
            Assert.IsTrue(File.Exists(tempFile));

            // Читаем результат
            string result = File.ReadAllText(tempFile);
            string expected = "Hello world! This is a test with multiple spaces.";

            // Проверяем что множественные пробелы удалены
            Assert.AreEqual(expected, result);

            // Очистка
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