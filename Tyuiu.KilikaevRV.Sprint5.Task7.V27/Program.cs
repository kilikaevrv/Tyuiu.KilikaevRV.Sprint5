using System;
using System.IO;
using Tyuiu.KilikaevRV.Sprint5.Task7.V27.Lib;

namespace Tyuiu.KilikaevRV.Sprint5.Task7.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Килияев Р. В. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Килияев Роман Владимирович | АСОиУб-23-3                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл в котором есть набор символьных данных. Удалить все пробелы,   *");
            Console.WriteLine("* идущие подряд больше одного. Полученный результат сохранить в файл.     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine(@"C:\DataSprints\", "InPutDataFileTask7V27.txt");

            // Проверяем существование файла
            if (!File.Exists(path))
            {
                Console.WriteLine($"Файл не найден: {path}");
                Console.WriteLine("Создаем тестовый файл...");

                Directory.CreateDirectory(@"C:\DataSprints\");
                string testContent = "Пример    текста    с    множественными    пробелами.    Проверка    работы.";
                File.WriteAllText(path, testContent);
                Console.WriteLine($"Создан тестовый файл: {path}");
            }

            Console.WriteLine($"Исходный файл: {path}");
            Console.WriteLine("Содержимое исходного файла:");
            string inputContent = File.ReadAllText(path);
            Console.WriteLine(inputContent);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                DataService ds = new DataService();
                string tempFile = ds.LoadDataAndSave(path);

                // Читаем результат из временного файла
                string result = File.ReadAllText(tempFile);

                // Сохраняем в итоговый файл
                string outputPath = Path.Combine(@"C:\DataSprints\", "OutPutDataFileTask7V27.txt");
                File.WriteAllText(outputPath, result);

                Console.WriteLine($"Результат сохранен в файл: {outputPath}");
                Console.WriteLine("Обработанное содержимое:");
                Console.WriteLine(result);

                // Очищаем временный файл
                File.Delete(tempFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}