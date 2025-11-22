using System;
using Tyuiu.KilikaevRV.Sprint5.Task0.V5.Lib;

namespace Tyuiu.KilikaevRV.Sprint5.Task0.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Комаров М.А. | АСОиУБ-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                       *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Комаров М.А. | АСОиУБ-23-3                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить   *");
            Console.WriteLine("* в текстовый файл OutPutFileTask0.txt и вывести на консоль.             *");
            Console.WriteLine("* Округлить до трёх знаков после запятой.                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int x = 3;

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string result = ds.SaveToFileTextData(x);
            Console.WriteLine("Результат: " + result);

            Console.WriteLine("Файл: OutPutFileTask0.txt");
            Console.WriteLine("Создан: путь_к_файлу");

            Console.ReadKey();
        }
    }
}