using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework11
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, sname;
            double  age, heigth, weight, imt, r, x1, y1, x2, y2;
            int z1, z2, z3;


            #region Задание1. Программа Анкета
            #region Ввод данных от пользователя
            HomeWorkClass.Print("****Добро пожаловать, необходимо заполнить немного данных о себе*****");//сделал для простого вывода свой класс по ДЗ
            Console.WriteLine("Введите свое имя:");
            name = Console.ReadLine();

            HomeWorkClass.Print("Введите свою фамилию");
            sname = Console.ReadLine();

            Console.WriteLine("Введите свой возраст");
            age = Convert.ToDouble(Console.ReadLine());

            HomeWorkClass.Print("Введите свой рост в метрах (нужно для посдчета ИМТ)");
            heigth = Convert.ToDouble(Console.ReadLine());

            HomeWorkClass.Print("Введите свой вес");
            weight = Convert.ToDouble(Console.ReadLine());
#endregion
            #region Вывод данных
            HomeWorkClass.Print("И так, что мы значем о вас, имя фамилия: " + name + " " + sname
                + ", ваш возраст: " + age + ", рост: " + heigth + " вес: " + weight + ".");//склеиваем
            Console.WriteLine("И так, что мы значем о вас, имя фамилия: {0} {1}, ваш возраст: {2:F}, рост: {3:F}, вес: {4:F}.",
                name, sname, age, heigth, weight); //форматный вывод
            Console.WriteLine("И так, что мы значем о вас, имя фамилия: {0} {1}, ваш возраст: {2:C}, рост: {3:C}, вес: ${4:F2}.",
                name, sname, age, heigth, weight); /* по методичке должен быть доллар, но игнорирует требование вывести значек доллара, 
            пришлось заствить вывести $ через костыль*/
            HomeWorkClass.Pause();
            #endregion
#endregion
            #region Задание2. Считаем ИМТ.
            imt = weight / (heigth * heigth);
            Console.WriteLine("Ваш имт: {0:F2}", imt);
            HomeWorkClass.Pause();
            #endregion
            #region Задание3. Считаем расстояние.
            HomeWorkClass.Print("Считаем рассnояние");

            HomeWorkClass.Print("Введите значение X1");
            x1 = ReadDouble();

            HomeWorkClass.Print("Введите значение Y1");
            y1 = ReadDouble();

            HomeWorkClass.Print("Введите значение X2");
            x2 = ReadDouble();

            HomeWorkClass.Print("Введите значение Y2");
            y2 = ReadDouble();

            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Расстояние: {0:F2} -считаем в теле программы.", r);

            r = Mathr(x1, y1, x2, y2);
            Console.WriteLine("Расстояние: {0:F2} -считаем через метод.", r);
            HomeWorkClass.Pause();
            #endregion
            #region Задание4. Меняем местами значение переменных;
            #region с использованием 3 переменных
            //сделал для int, для строк текущих знаний не хватает...
            z1 = 5;
            z2 = 18;
            Console.WriteLine("Значения переменных до замены:{0},{1}", z1, z2);

            z3 = z1;
            z1 = z2;
            z2 = z3;
            Console.WriteLine("Значения переменных после замены с 3 переменными :{0},{1}", z1, z2);
            #endregion
            #region с использованием 2 переменных
            // в 1С не надо следить за размером значения переменной, если не хватает то автоматом расшириться, 
            // вопросы только при записи в базу, там так просто не запишешь безразмерные данные, но можно обойти))... 
            z1 = z1 + z2;
            z2 = z1 - z2;
            z1 = z1 - z2;
            Console.WriteLine("Значения переменных после замены с 2 переменными метод 1С:{0},{1}", z1, z2);

            //C# должно хватить памяти честно подсмотрел)
            z1 = z1 ^ z2;
            z2 = z1 ^ z2;
            z1 = z1 ^ z2;
            Console.WriteLine("Значения переменных после замены с 2 переменными метод С#:{0},{1}", z1, z2);
            HomeWorkClass.Pause();
            #endregion
            #endregion
            #region задание5 Выводим ФИО + город разными способами
            HomeWorkClass.Print("Алексей Кошелев, Санкт-Петербург");
            HomeWorkClass.Pause();
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine("Алексей Кошелев, Санкт-Петербург");
            HomeWorkClass.Pause();
            PrintXY("Алексей Кошелев, Санкт - Петербург",16,33);
            HomeWorkClass.Pause();
            #endregion


        }

        private static void PrintXY(string ms, int x, int y)
        {
            Console.SetCursorPosition(x,y);
            Console.WriteLine(ms);
        }

        //утомило печатать))
        private static Double ReadDouble()
        {
           return Convert.ToDouble(Console.ReadLine());
        }

        //метод по расчтету расстояния
        private static double Mathr(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        
    }
}
