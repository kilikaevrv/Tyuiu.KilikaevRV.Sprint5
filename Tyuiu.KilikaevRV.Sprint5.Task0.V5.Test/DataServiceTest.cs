using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KilikaevRV.Sprint5.Task0.V5.Lib;

namespace Tyuiu.KilikaevRV.Sprint5.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            int x = 3;

            string result = ds.SaveToFileTextData(x);

            // Проверяем строковое представление
            Assert.AreEqual("-0.223", result);

            // Дополнительная проверка с допуском для чисел
            double expectedValue = -0.223;
            double actualValue = double.Parse(result);
            Assert.AreEqual(expectedValue, actualValue, 0.001);
        }
    }
}