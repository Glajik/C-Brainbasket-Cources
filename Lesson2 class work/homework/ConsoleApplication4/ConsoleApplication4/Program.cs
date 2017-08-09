using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример №2.4
            double a = 1.65, b = 1.1;
            double y = 0;
            double x = 0;

            Console.WriteLine("Дано:");
            Console.WriteLine("a = {0}", a.ToString());
            Console.WriteLine("b = {0}", b.ToString());
            Console.WriteLine();

            Console.WriteLine(" Таблица у(х):");

            for (x = 0.5; x <= 2; x += 0.25)
            {
                if (x < 1.4)
                    y = Math.PI * x * x - 7 / x * x;
                else if (x == 1.4)
                    y = a * Math.Pow(x, 3) + 7 * Math.Sqrt(x * x - 1);
                else 
                    y = (a + b * x) / Math.Sqrt(x * x + 1);

                Console.WriteLine("y({0}) = {1}", x.ToString(), y.ToString());
            }

            Console.WriteLine("Нажмите любую клавишу, чтобы завершить программу.");
            Console.ReadKey();
        }
    }
}
