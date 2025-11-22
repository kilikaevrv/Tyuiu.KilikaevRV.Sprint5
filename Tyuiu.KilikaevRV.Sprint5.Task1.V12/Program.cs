using System;
using System.IO;
using Tyuiu.KilikaevRV.Sprint5.Task1.V12.Lib;

namespace Tyuiu.KilikaevRV.Sprint5.Task1.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Килияев Р. В. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Килияев Роман Владимирович | АСОиУб-23-3                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция: F(x) = (5x + 2.5)/(sin(x) - 2) + 2                       *");
            Console.WriteLine("* Произвести табулирование f(x) на диапазоне [-5; 5] с шагом 1.          *");
            Console.WriteLine("* При делении на ноль вернуть значение 0.                                *");
            Console.WriteLine("* Результат сохранить в текстовый файл OutPutFileTask1.txt               *");
            Console.WriteLine("* и вывести на консоль в таблицу. Округлить до двух знаков после запятой.*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Начало диапазона: {startValue}");
            Console.WriteLine($"Конец диапазона: {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл: " + path);
            Console.WriteLine("Создан!");

            Console.WriteLine("\nСодержимое файла:");
            string[] fileContent = File.ReadAllLines(path);
            foreach (string line in fileContent)
            {
                Console.WriteLine(line);
            }

            Console.ReadKey();
        }
    }
}