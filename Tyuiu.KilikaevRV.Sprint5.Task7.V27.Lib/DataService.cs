using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KilkaevRV.Sprint5.Task7.V27.Lib
{
    public class DataService : ISprint5Task7V27
    {
        public string LoadDataAndSave(string path)
        {
            string tempFile = Path.GetTempFileName();

            try
            {
                // Читаем все содержимое файла
                string content = File.ReadAllText(path);

                // Удаляем ВСЕ пробелы
                string result = RemoveAllSpaces(content);

                // Сохраняем результат во временный файл
                File.WriteAllText(tempFile, result, Encoding.UTF8);

                return tempFile;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при обработке файла: {ex.Message}");
            }
        }

        private string RemoveAllSpaces(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            // Удаляем все пробелы
            return input.Replace(" ", "");
        }
    }
}