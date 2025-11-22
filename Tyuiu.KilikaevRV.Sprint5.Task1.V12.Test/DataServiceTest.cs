using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KilikaevRV.Sprint5.Task1.V12.Lib;
using System;

namespace Tyuiu.KilikaevRV.Sprint5.Task1.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateFunction()
        {
            DataService ds = new DataService();

            // Проверяем значения для каждого x от -5 до 5
            Assert.AreEqual(23.61, ds.CalculateFunction(-5));
            Assert.AreEqual(16.08, ds.CalculateFunction(-4));
            Assert.AreEqual(7.84, ds.CalculateFunction(-3));
            Assert.AreEqual(4.58, ds.CalculateFunction(-2));
            Assert.AreEqual(2.88, ds.CalculateFunction(-1));
            Assert.AreEqual(0.75, ds.CalculateFunction(0));
            Assert.AreEqual(-4.47, ds.CalculateFunction(1));
            Assert.AreEqual(-9.46, ds.CalculateFunction(2));
            Assert.AreEqual(-7.41, ds.CalculateFunction(3));
            Assert.AreEqual(-6.16, ds.CalculateFunction(4));
            Assert.AreEqual(-7.29, ds.CalculateFunction(5));
        }

        [TestMethod]
        public void ValidSaveToFile()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(-5, 5);

            Assert.IsTrue(System.IO.File.Exists(path));
        }
    }
}