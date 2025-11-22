using System;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KilikaevRV.Sprint5.Task0.V5.Lib
{
    public class DataService : ISprint5Task0V5
    {
        public string SaveToFileTextData(int x)
        {
            // Вычисляем значение функции y = ln((x + 1)/(x + 2))
            double numerator = x + 1.0;
            double denominator = x + 2.0;
            double fraction = numerator / denominator;
            double y = Math.Log(fraction);

            // Округляем до трёх знаков после запятой
            double roundedY = Math.Round(y, 3);

            // Форматируем с фиксированным количеством знаков
            return roundedY.ToString("F3");
        }
    }
}