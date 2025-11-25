using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.KilikaevRV.Sprint5.Task6.V13.Lib
{
    public class DataService : ISprint5Task6V13
    {
        public int LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            int count = 0;
            int i = 0;

            while (i < text.Length - 1)
            {
                if (text[i] == 'с' && text[i + 1] == 'с') // Русские буквы 'с'
                {
                    count++;
                    i += 2;
                }
                else
                {
                    i++;
                }
            }

            return count;
        }
    }
}