using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace hw4
{
    static class  StaticClass
    {
        public static int Search(int[] arr)
        {
            int n = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if ((arr[i] % 3 == 0) && (arr[i + 1] % 3 != 0))
                {
                    n++;
                }
                if ((arr[i] % 3 != 0) && (arr[i + 1] % 3 == 0))
                {
                    n++;
                }            
            }
            return n;
        }

        public static int[] ReadFromFile(string patch)
        {
            int[] arr;
            if (File.Exists(patch))
            {
                string[] ss = File.ReadAllLines(patch);
                arr = new int[ss.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(ss[i]);
                }
                return arr;
            }
            else
            {
                Console.WriteLine("Не нашел файл...");
                return null;
            }
        }
    }
}

