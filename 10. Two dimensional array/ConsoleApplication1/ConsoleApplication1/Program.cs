using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        // Обработка матрицы. Задание 10. Вычислить среднее арифметическое матрицы

        static void Main(string[] args)
        {
            int LengthR = -1, LengthC = -1;
            bool valid = false;
            Console.WriteLine("Введите количество строк матрицы:");
            do
            {
                string s = Console.ReadLine();
                if (s.Length > 0 && s.Length < 2)
                {
                    char[] c = s.ToCharArray(0, 1);
                    if (c[0] >= '2' && c[0] <= '9')
                    {
                        Console.WriteLine("ok");
                        int a = Convert.ToInt32(s);
                        Console.WriteLine(a);
                        valid = true;
                        LengthR = a;
                    }
                }
                if (!valid) Console.WriteLine("Повторите еще раз, это должно быть число от 2 до 10.");
            }
            while (!valid);

            valid = false;

            Console.WriteLine("Введите количество столбцов матрицы:");
            do 
            {
                string s = Console.ReadLine();
                if (s.Length > 0 && s.Length < 2)
                {
                    char[] c = s.ToCharArray(0, 1);
                    if (c[0] >= '2' && c[0] <= '9')
                    {
                        Console.WriteLine("ok");
                        int a = Convert.ToInt32(s);
                        valid = true;
                        LengthC = a;
                    }
                }
                if (!valid) Console.WriteLine("Повторите еще раз, это должно быть число от 2 до 10.");
            }
            while (!valid);

            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("Вывод матрицы, заполненной случайными числами:");
            Console.WriteLine();

            int[,] Matrix = new int[LengthR,LengthC];

            Random rnd = new Random();

            int summ = 0;
            int num = 0;
            double SrArifm = 0.0;

            for (int indexR = 0; indexR < LengthR; indexR++)
            {
                for (int indexC = 0; indexC < LengthC; indexC++)
                {
                    Matrix[indexR, indexC] = rnd.Next(1, 10);
                    Console.Write("{0: 0 }", Matrix[indexR, indexC]);

                    num++;
                    summ+=Matrix[indexR, indexC];
                }
                Console.WriteLine(); 
                Console.WriteLine();
            };
            Console.WriteLine();

            SrArifm = (double)summ / num;

            Console.WriteLine("Среднее арифметическое матрицы: {0,3}", SrArifm);

            Console.WriteLine("Нажмите любую клавишу, чтобы закрыть окно.");
            Console.ReadKey();
        }
    }
}
