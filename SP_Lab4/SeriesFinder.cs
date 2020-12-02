using System;
using System.Globalization;
using System.IO;

namespace SP_Lab4
{
    public static class SeriesFinder
    {
        internal static void CreateAndFill(string path)
        {
            var random = new Random();
            var array = new int[random.Next(30)];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10);
            }

            StreamWriter sw = new StreamWriter(path);

            for (int i = 0; i < array.Length; i++)
            {
                sw.Write(array[i].ToString());
                if(i < array.Length-1)
                    sw.Write(";");
            }
            
            sw.Dispose();

        }

        internal static int GetCountOfSeries(string pathIn, string pathOut)
        {
            int result = 0;
            int last = 0;
            StreamReader sr = new StreamReader(pathIn);
            var items = sr.ReadLine();
            sr.Dispose();
            var itemsSplited = items.Split(';');
            if (int.TryParse(itemsSplited[0], out last))
            {
                last = int.Parse(itemsSplited[0]);
                result = 1;
            }
            else
            {
                return 0;
            }

            for (int i = 1; i < itemsSplited.Length; i++)
            {
                int current = int.Parse(itemsSplited[i]);
                if (current != last)
                {
                    last = current;
                    result++;
                }
            }
            
            StreamWriter sw = new StreamWriter(pathOut);
            sw.Write(result);
            sw.Dispose();
            return result;
        } 
    }
}