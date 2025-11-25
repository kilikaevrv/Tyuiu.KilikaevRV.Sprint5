using tyuiu.cources.programming.interfaces.Sprint5;
using System;
using System.IO;

namespace Tyuiu.KilikaevRV.Sprint5.Task6.V13.Lib
{
    public class DataService : ISprint5Task6V13
    {
        public int LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            int count = 0;

            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i] == 'c' && text[i + 1] == 'c')
                    count++;
            }

            return count;
        }
    }
}