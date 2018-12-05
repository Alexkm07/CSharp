using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задача 1
            step1();
            #endregion
            #region Задача 2
            step2();
            #endregion
            #region задача 2.2
            step22();
            #endregion
        }

        private static void step22()
        {
            int[] arr = StaticClass.ReadFromFile("c:\\test\\222.txt");
            if (arr != null)
            {
                for (int k = 0; k < arr.Length; k++)
                {
                    Console.WriteLine(arr[k]);
                }
            }
            Console.ReadLine();

        }

        private static void step2()
        {
            int[] arr = generateArr(10, -10000, 10000);
            int kolpar = StaticClass.Search(arr);
            Console.WriteLine($"через статический класс. В искомом массиве обнаружено {kolpar} пар подходящих элементов.");
            Console.ReadLine();
        }

        private static void step1()
        {
            SuperArray myArray = new SuperArray(10, -10000, 10000);
            int dig = myArray.Search();
            Console.WriteLine($"В искомом массиве обнаружено {dig} пар подходящих элементов.");
            Console.ReadLine();
        }

        private static int[] generateArr(int n, int min, int max)
        {
            Random rnd = new Random();
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(min, max);
            }
            return a;
        }
    }
}
