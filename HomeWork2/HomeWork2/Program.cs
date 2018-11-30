using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задание 1 минимальное из 3 цифр
            job1();
            #endregion

            #region Задание 2 посдчет количества цифр
            job2();
            #endregion

            #region Задание 3 считаем количества положительных нечетных цифр
            job3();
            #endregion

            #region Задание 4 проверяем пароль
            job4();
            #endregion

            #region Задание 5 индекс массы тела
            job5();
            #endregion

            #region Задание 6 - ищем хорошие числа
            job6();
            #endregion
        }

        private static void job6()
        {
            Int32 number, max;
            Console.WriteLine("Начали подсчет чисел...");
            max = 1000000000;
            //решение из методички
            number = ReturnSummNumb(max);
            Console.WriteLine("Всего хороших чисел: " + number);

            #region Задание 6* - для опытов через строки, но на порядок медленее
            //number = ReturnNumber(max);
            //Console.WriteLine("Всего хороших чисел: " + number);
            //number = ReturnNumber(max);
            #endregion

            #region Задание 6** - для опытов через массив быстрее чем в методичке но не на много примерно на 10%
            number = ReturnNumber2Metod(max);
            Console.WriteLine("Всего хороших чисел: " + number);
            Console.ReadLine();
            #endregion
        }

        private static void job5()
        {
            double heitgh, weigth;
            Console.WriteLine("Введите рост в метрах");
            heitgh = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вес");
            weigth = Convert.ToDouble(Console.ReadLine());

            WriteImt(heitgh, weigth);
        }

        private static void job4()
        {
            string trueLogin = "root";
            string truePass = "GeekBrains";

            int i = 0;

            while (i < 3)
            {
                bool result = ReturnLogPassCheck(trueLogin, truePass);
                if (result)
                {
                    break;
                }
                i++;
            }
            if (i >= 3)
            {
                Console.WriteLine("Исчерпаны попытки ввода, вы {0} раз(а) ввели не правильные данные...", i);
                Console.ReadLine();
            }
        }

        private static void job3()
        {
            double summ;
            Console.WriteLine("введите число для посдчета суммы, пока не введете 0 будем продожать");
            summ = ReturnSumm();
            Console.WriteLine("Сумма нечетных чисел, которые больше 0 = {0}", summ);
            Console.ReadLine();
        }

        private static void job2()
        {
            string str_number;
            Console.WriteLine("Введите число для подсчета количества цифр");
            str_number = Console.ReadLine();

            Int32 number;
            number = ReturnNumberOfDigits(str_number);
            Console.WriteLine("{0} - количество в числе цифр", number);
            Console.ReadLine();
        }

        private static void job1()
        {
            double minVar, x1, x2, x3;
            Console.WriteLine("Сейчас будем искать минимальное значение, введите что будем сравнивать");
            Console.WriteLine("Введите 1 значение");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите 2 значение");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите 3 значение");

            x3 = Convert.ToDouble(Console.ReadLine());
            minVar = ReturnMinVar(x1, x2, x3);
            Console.WriteLine("{0} - минимальное значение из введенного!", minVar);
            Console.ReadLine();
        }

        private static int ReturnSummNumb(int max)
        {
            int i = 1, s, sum = 0, sumdigit;
            DateTime dateStart = DateTime.Now;
            sumdigit = 0;
            while (i <= max)
            {
                s = i;
                sum = 0;
                while (s > 0 )
                {
                    sum = sum + s % 10;
                    s = s / 10;
                }
                if (i % sum == 0)
                {
                    sumdigit++;
                }
                i++;
            }
            DateTime dateFinish = DateTime.Now;
            Console.WriteLine("Выполнение подсчета заняло:" + (dateFinish - dateStart).ToString("mm\\:ss\\:fff"));
            return sumdigit;
        }

        private static int ReturnNumber2Metod(int max)
        {

            int[]  arr = new int[Convert.ToString(max).Length];
            Int32 i = 1, maxl = Convert.ToString(max).Length, sumdigit =0;
            DateTime dateStart = DateTime.Now;
            while (i <= max)
            {
                int s = 0,ind = 0, sum = 0;
                
                while (s<= ind && ind <= (maxl-1))
                {
                    arr[s] = arr[s] + 1;
                    
                    if (arr[s] > 9)
                    {
                        arr[s] = 0;
                        ind++;
                    }
                    s++;
                }
                sum = arr.Sum();
                if (i % sum == 0)
                {
                    sumdigit++;
                }
                i++;

            }
            DateTime dateFinish = DateTime.Now;
            Console.WriteLine("Выполнение подсчета через массивы заняло:" + (dateFinish - dateStart).ToString("mm\\:ss\\:fff"));
            return sumdigit;

        }

        private static int ReturnNumber(int max)
        {
            string num;
            int i = 1, s, sum = 0, str, sumdigit;
            DateTime dateStart = DateTime.Now;
            sumdigit = 0;
            while (i <= max)
            {
                num = Convert.ToString(i);
                s = 0;
                sum = 0;
                while (s <= num.Length-1)
                {
                    str = num[s];
                    sum = sum + Convert.ToInt16(Convert.ToString(num[s]));
                    s++;
                }
                if (i % sum == 0)
                {
                    sumdigit++;
                }
                i++;
            }
            DateTime dateFinish = DateTime.Now ;
            Console.WriteLine("Выполнение подсчета через строки заняло:" + (dateFinish - dateStart).ToString("mm\\:ss\\:fff"));
            return sumdigit;
        }

        private static void WriteImt(double heitgh, double weigth)
        {
            Double imt = weigth / (heitgh * heitgh);
            if (imt <= 16.0)
            {
                Console.WriteLine("Ваш ИМТ  = {0:f2} - Выраженный дефицит массы", imt);
            }
            else if (imt > 16.0 && imt <= 18.5)
            {
                Console.WriteLine("Ваш ИМТ  = {0:f2} - Недостаточная (дефицит) масса тела", imt);
            }
            else if (imt > 18.5 && imt <= 24.99)
            {
                Console.WriteLine("Ваш ИМТ  = {0:f2} - Норма", imt);
            }
            else if (imt >= 25 && imt <= 30)
            {
                Console.WriteLine("Ваш ИМТ  = {0:f2} - Избыточная масса тела (предожирение)", imt);
            }
            else if (imt > 30 && imt <= 35)
            {
                Console.WriteLine("Ваш ИМТ  = {0:f2} - Ожирение", imt);
            }
            else if (imt > 35 && imt < 40)
            {
                Console.WriteLine("Ваш ИМТ  = {0:f2} - Ожирение резкое", imt);
            }
            else if (imt >=40)
            {
                Console.WriteLine("Ваш ИМТ  = {0:f2} - Очень резкое ожирение", imt);
            }

            if (imt >= 25)
            {
                double fatweight = weigth - 24.99 * (heitgh * heitgh);
                Console.WriteLine("Вам надо скинуть {0:f1}кг, они лишнии", fatweight);
            }
            else
            {
                Console.WriteLine("А вы молодец, нет лишнего веса");
            }
            Console.ReadLine();
        }

        private static bool ReturnLogPassCheck(string login, string pass)
        {
            Console.WriteLine("Введите логин");
            string inLogin = Console.ReadLine();
            Console.WriteLine("Введите пароль");
            string inPass = Console.ReadLine();
            if ((login.ToLower() != inLogin.ToLower())  || (pass != inPass))
            {
                Console.WriteLine("Пароль или логин не совпали...");
                Console.ReadLine();
                return false;
            }
            Console.WriteLine("Успешно...");
            Console.ReadLine();
            return true;
        }

        private static double ReturnSumm()
        {
            double summ =0;
            while (true)
            {
                Console.WriteLine("Введите число");
                double number = Convert.ToDouble(Console.ReadLine());
                if (number > 0.00 && (number % 2) != 0)
                {
                    summ = summ + number;
                }
                if (number == 0.0)
                {
                    break;
                }
            }
            return summ;
        }

        //чистим строку от точек и зяпятых, конвертим в число и потом опять в строку, что бы не было букв и пробелов
        //если получилось сконвертить возвращаем длину строки
        //можно обернуть в поиск эксепшенов
        private static Int32 ReturnNumberOfDigits(string str_number)
        {
            str_number = str_number.Replace(",","").Replace(".", "");
            str_number = Convert.ToString(Convert.ToInt64(str_number));
            return str_number.Length;
        }

        private static double ReturnMinVar(double x1, double x2, double x3)
        {
             if (x1 < x2 && x1 < x3)
            {
                return x1;
            }  
             else if (x2 < x3 && x2 < x1)
            {
                return x2;
            }

            return x3;
        }
    }
}
