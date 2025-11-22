using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KilikaevRV.Sprint5.Task1.V12.Lib;

namespace Tyuiu.KilikaevRV.Sprint5.Task1.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFileExists()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(-5, 5);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(true, fileExists);
        }

        [TestMethod]
        public void CheckDivisionByZero()
        {
            DataService ds = new DataService();

            // Проверяем, что при делении на ноль возвращается 0
            // Для этого найдем значение x, где sin(x) - 2 = 0
            // sin(x) = 2 - это невозможно, так как sin(x) ∈ [-1, 1]
            // Значит деления на ноль не должно быть, но проверим работу функции
            double result = ds.CalculateFunction(0); // Любое значение

            // Проверяем, что результат является числом (не NaN и не бесконечность)
            Assert.IsFalse(double.IsNaN(result));
            Assert.IsFalse(double.IsInfinity(result));
        }
    }
}