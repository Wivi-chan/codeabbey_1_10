using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeabbey_1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Задача 1\nSum A+B=?");
            //Z1();
            //Console.Write("Задача 2\nПосчитать сумму заданного массива");
            //Z2();
            //Console.Write("Задача 3\nПосчитать сумму заданных рядов чисел ");
            //Z3();
            //Console.Write("Задача 4\nВывести наибольшее число из заданных рядов ");
            //Z4();
            //Console.Write("Задача 5\nВывести наименьшее число из заданных рядов ");
            //Z5();
            //Console.Write("Задача 6\nВывести наименьшее число из заданных рядов ");
            //Z6();
            //Console.Write("Задача 7\nИз Фаренгейтов в Цельсия");
            //Z7();
            //Console.Write("Задача 8\nАрифметическая прогрессия");
            //Z8();
            Console.Write("Задача 10\nЛинейная функция. ");
            Z10();

            Console.ReadLine();

        }
        public static void Z1()
        {
            Console.WriteLine("Write One number");
            int OneNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Write Two number");
            int TwoNumber = int.Parse(Console.ReadLine());
            int SummZ1 = OneNumber + TwoNumber;
            if (OneNumber >= 0 && TwoNumber >= 0)
            {
                Console.WriteLine("{0}+{1}={2}", OneNumber, TwoNumber, SummZ1);
            }
            else if (OneNumber < 0)
            {
                Console.WriteLine("({0})+{1}={2}", OneNumber, TwoNumber, SummZ1);
            }
            else if (TwoNumber < 0)
            {
                Console.WriteLine("{0}+({1})={2}", OneNumber, TwoNumber, SummZ1);
            }

        }
        public static void Z2()
        {
            int temp = 0;
            int SummElMass = 0;
            Console.WriteLine("Введите количество элементов массива:");
            int N = int.Parse(Console.ReadLine());
            int[] Mass = new int[N];
            Console.WriteLine("Введите элементы данного массива: ");
            for (int i = 0; i < Mass.Length; i++)
            {
                Mass[i] = int.Parse(Console.ReadLine());
                //Console.Write(" " + el);
            }
            Console.WriteLine("Введеный массив: ");
            for (int el = 0; el < Mass.Length; el++)
            {
                Console.Write(" " + Mass[el]);
                SummElMass += Mass[el];

            }
            Console.WriteLine("\nCумма массива = " + SummElMass);
        }
        public static void Z3()
        {
            double SummPar = 0; int e = 0;
            Console.WriteLine("Задайте количество рядов двух чисел");
            int N = int.Parse(Console.ReadLine());
            double[,] Mass = new double[N, 2];
            Console.WriteLine("Введите пары чисел, которые желайте сложить:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.SetCursorPosition((j * 4) + 1, i + 4);
                    Mass[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            Console.Clear();
            Console.WriteLine("Введеный пары: ");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.WriteLine("{0} {1}", Mass[i, j], Mass[i, j + 1]);
                }
            }
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Сумма введеных пар: ");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    SummPar = Mass[i, j] + Mass[i, j + 1];
                    e = i + 1;
                    Console.WriteLine("{0}. {1}", e, SummPar);

                }
            }
            Console.ReadLine();

        }
        public static void Z4()
        {
            Console.WriteLine("\nВведите количество рядов: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество цифр: ");
            int NNumber = int.Parse(Console.ReadLine());
            int[,] Mass = new int[N, NNumber];
            int temp = Mass[0, 0];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < NNumber; j++)
                {
                    Console.SetCursorPosition((j * 2) + 2, i + 6);
                    Mass[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.ReadLine();
            Console.Clear();
            //Console.WriteLine("Введеные ряды чисел: "); Продумать. 
            //for (int i=0; i<N;i++)
            //{
            //    for(int j=0; j < NNumber - 1; j++)
            //    {
            //        Console.WriteLine("{0} {1}",Mass[i,j],Mass[i,j+1]);
            //    }
            //}
            //Console.ReadKey();
            //Console.Clear();
            Console.WriteLine("Максимальное число в каждом из рядов");
            int e = 1;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < NNumber; j++)
                {
                    if (temp < Mass[i, j])
                    {
                        temp = Mass[i, j];
                    }
                }
                Console.WriteLine("{0}.{1}", e + i, temp);
            }
        }
        public static void Z5()
        {
            Console.WriteLine("\nВведите количество рядов: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество цифр: ");
            int NNumber = int.Parse(Console.ReadLine());
            int[,] Mass = new int[N, NNumber];
            int temp = Mass[0, 0];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < NNumber; j++)
                {
                    Console.SetCursorPosition((j * 2) + 2, i + 6);
                    Mass[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.ReadLine();
            Console.Clear();
            //Console.WriteLine("Введеные ряды чисел: "); Продумать. 
            //for (int i=0; i<N;i++)
            //{
            //    for(int j=0; j < NNumber - 1; j++)
            //    {
            //        Console.WriteLine("{0} {1}",Mass[i,j],Mass[i,j+1]);
            //    }
            //}
            //Console.ReadKey();
            //Console.Clear();
            Console.WriteLine("Минимальное число в каждом из рядов");
            int e = 1;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < NNumber; j++)
                {
                    if (temp > Mass[i, j])
                    {
                        temp = Mass[i, j];
                    }
                }
                Console.WriteLine("{0}.{1}", e + i, temp);
            }
        }
        public static void Z6()
        {
            Console.WriteLine("\nВведите количество рядов: ");
            int N = int.Parse(Console.ReadLine());
            int[,] Mass = new int[N, 2];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.SetCursorPosition((j * 2) + 2, i + 4);
                    Mass[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.ReadLine();
            Console.Clear();
            double chasnoe=0; double temp = 0; int e = 1;
            Console.WriteLine("Разделим пары введеных чисел и округлим до целого");
            for (int i = 0; i < N; i++) 
            {
                for (int j = 0; j < 1; j++)
                {
                    temp = Mass[i, j] / Mass[i, j];
                    chasnoe = Math.Round(temp);
                }
            Console.WriteLine("{0}.{1}",e+i,chasnoe);
            }

        }
        public static void Z7()
        {
            Console.WriteLine("\nВведите количество значений по Фаренгейту, которые нужно преобразовать");
            int N = int.Parse(Console.ReadLine());
            int[] Mass = new int[N];
            Console.WriteLine("Введите значения по Фаренгейту");
            for (int i = 0; i < N; i++)
            {
                Mass[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}.{1}", i + 1, Mass[i]);
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Все введенные значения");
            foreach (int el in Mass)
            {
                Console.WriteLine(el + "");
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Переведенные в Цельсия округленные до целого значения");
            double temp, Farengeit;
            for (int i = 0; i < N; i++)
            {
                temp = (Mass[i] - 32) * 5 / 9;
                Farengeit = Math.Round(temp);
                Console.WriteLine("{0}.{1}", i + 1, Farengeit);
            }
        }
        public static void Z8()
        {
            //на 31.10.19
        }
        public static void Z9()
        {
            Console.WriteLine("\nВведите количество предполагаемых треугольников");
            int N = int.Parse(Console.ReadLine());
            double[,] Mass = new double[N, 3];
            Console.WriteLine("Введите длины сторон предполагаемого треугольника:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition((j * 2) + 2, i + 6);
                    Mass[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Треугольники, которые существуют:");
            for (int i = 0; i < N; i++)
            {
                for(int j = 0; j == 0; j++)
                {
                    if (Mass[i,j]+Mass[i,j+1]>Mass[i,j+2]&& Mass[i, j] + Mass[i, j + 2] >Mass[i, j + 1]&& Mass[i, j + 2] + Mass[i, j + 1] >Mass[i, j] )
                    {
                        Console.WriteLine("{0}-Такой треугольник существует",i+1);
                    }
                    else
                    {
                        Console.WriteLine("{0}-Такого треугольника нет",i+1);
                    }
                }
            }
        }
        public static void Z10()
        {
            Console.WriteLine("Введите количество линейных функций на нахождение а и b");
            int N = int.Parse(Console.ReadLine());
            double[,] Mass = new double[N, 4];
            Console.WriteLine("Введите точки:");
            for (int i=0; i<N;i++)
            {
                for(int j=0;j<4;j++)
                {
                    Console.SetCursorPosition((j * 2) + 2, i + 6);
                    Mass[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            Console.ReadLine();
            Console.Clear();
            double b=0,a=0;
            Console.WriteLine("Нахождение а и b по заданным координатам");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j == 0; j++)
                {
                //    b = Mass[i, j + 1] - Mass[i, j];
                //    a = (Mass[i, j + 1] - b) / Mass[i, j];
                // Сделать 31.10.19
                }
                Console.WriteLine("({0},{1})",a,b);
            }
        }
    }
}
