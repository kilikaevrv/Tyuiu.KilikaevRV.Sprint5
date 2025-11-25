using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KilikaevRV.Sprint5.Task7.V27.Lib
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

                // Удаляем множественные пробелы, оставляя только одиночные
                string result = RemoveExtraSpaces(content);

                // Сохраняем результат во временный файл
                File.WriteAllText(tempFile, result, Encoding.UTF8);

                return tempFile;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при обработке файла: {ex.Message}");
            }
        }

        private string RemoveExtraSpaces(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            StringBuilder result = new StringBuilder();
            bool previousWasSpace = false;

            foreach (char c in input)
            {
                if (c == ' ')
                {
                    if (!previousWasSpace)
                    {
                        result.Append(c);
                        previousWasSpace = true;
                    }
                }
                else
                {
                    result.Append(c);
                    previousWasSpace = false;
                }
            }

            return result.ToString();
        }
    }
}