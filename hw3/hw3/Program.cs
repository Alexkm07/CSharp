using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    struct Complex
    {
        public double im;
        public double re;
        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        public Complex Multi(Complex x)
        {
            Complex​ y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public String ToString()
        {
            return re + " " + im + "i";
        }


    }

    class Program
    {
        static void Main(string[] args)
        {

            para_1a();
            para_1b();
            para_21();
            para_22();
        }

        private static void para_22()
        {
            int  x= 0;
            bool flag = true;
            int  sum = 0;

            do
            {
                try
                {
                    x = returnintx();
                }
                catch
                {
                    Console.WriteLine("Ввели не корретный данные....");
                    break;
                }

                if (x % 2 == 0)
                {
                    sum = sum + x;
                }
            }
            while (flag);
            Console.WriteLine($"сумма положительных чисел: {sum}");
            Console.ReadLine();
        }

        private static int returnintx()
        {
            string s;
            Console.WriteLine("Введите число:");
            s = Console.ReadLine();
            return int.Parse(s);
        }

        private static void para_21()
        {
            int x;
            string s;
            bool flag;
            int sum = 0; 
            
            do
            {
                Console.WriteLine("Введите число:");
                s = Console.ReadLine();
                flag = int.TryParse(s, out x);
                if (x%2==0)
                {
                    sum = sum + x;
                }
            }
            while (flag);
            Console.WriteLine($"сумма положительных чисел: {sum}");
            Console.ReadLine();
        }

        private static void para_1b()
        {
            CComplex x1 = new CComplex(5, 5);
            CComplex x2 = new CComplex(10, 10);
            x2.Plus(x1);
            Console.WriteLine("Результат сложения объектов");
            Console.WriteLine(x2.ToString());
            x2.Im = 10;
            x2.Re = 10;
            x2.Multi(x1);
            Console.WriteLine("Результат умножения объектов");
            Console.WriteLine(x2.ToString());
            Console.ReadLine();
        }

        private static void para_1a()
        {
            Complex complex1;
            complex1.re = 5;
            complex1.im = 5;

            Complex complex2;
            complex2.re = 7;
            complex2.im = 7;

            Complex result = complex2.Minus(complex1);
            Console.WriteLine(result.ToString());
            Console.ReadLine();

        }
    }
}
