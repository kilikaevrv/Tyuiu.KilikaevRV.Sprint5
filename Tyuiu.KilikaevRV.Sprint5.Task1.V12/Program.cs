using System;
using Tyuiu.KilikaevRV.Sprint5.Task1.V12.Lib;

namespace Tyuiu.KilikaevRV.Sprint5.Task1.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Килияев Р. В. | АСОиУб-23-3                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция: F(x) = (5x + 2.5)/(sin(x) - 2) + 2                       *");
            Console.WriteLine("* Произвести табулирование f(x) на диапазоне [-5; 5] с шагом 1.          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"startValue = {startValue}");
            Console.WriteLine($"stopValue = {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");

            // Вывод результатов на консоль
            Console.WriteLine("\n+----------+----------+");
            Console.WriteLine("|    x     |   f(x)   |");
            Console.WriteLine("+----------+----------+");

            for (int x = startValue; x <= stopValue; x++)
            {
                double value = ds.CalculateFunction(x);
                Console.WriteLine($"| {x,5}    | {value,8:F2} |");
            }
            Console.WriteLine("+----------+----------+");

            Console.ReadKey();
        }
    }
}