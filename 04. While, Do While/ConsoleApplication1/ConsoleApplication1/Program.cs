using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Циклы Do While
// Пример № 7
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, e = 0.0005, q = 0, s = 0, x = 1.5, n = 0;

            // Урок 7.1 - Ex.No.8 - while {}
            n = 0;
            s = 0;
            a = 1 / x;
            while (Math.Abs(a) > 0.0001)
            {
                a = Math.Pow(-1, n) * (1 / (2 * n + 1));
                s += a*4;
                //Console.WriteLine("n: {0,3} | a: {1,0:0.00000}", n, a);
                n++;

            }
            Console.WriteLine();
            Console.WriteLine("Результат:");
            Console.WriteLine();
            Console.WriteLine("Сумма s = {0,20} | {1, 20}", s, Math.PI);
            Console.WriteLine("Число членов ряда n = {0,5}", n);


            // Урок 7.2 - Ex.No.8 - do {} while
            n = 0;
            s = 0;
            a = 1 / x;
            do
            {
                a = Math.Pow(-1, n) * (1 / (2 * n + 1));
                s += a * 4;
                //Console.WriteLine("n: {0,3} | a: {1,0:0.00000}", n, a);
                n++;

            } 
            while (Math.Abs(a) > 0.0001);
            
            Console.WriteLine();
            Console.WriteLine("Результат:");
            Console.WriteLine();
            Console.WriteLine("Сумма s = {0,20} | {1, 20}", s, Math.PI);
            Console.WriteLine("Число членов ряда n = {0,5}", n);


            Console.ReadKey();
        }
    }
}
