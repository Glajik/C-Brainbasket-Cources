using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример №2.10

            double a = 0.9;
            double x = 0, y = 0;

            Console.WriteLine("Дано:");
            Console.WriteLine("a = {0}", a.ToString());
            Console.WriteLine();

            Console.WriteLine(" Таблица y(x):"); // Заголовок

            for (x = 0.5; x <= 2; x += 0.5)
            {
                if (x > 1)
                {
                    y = a * Math.Log (x) + Math.Sqrt (Math.Abs (x));
                }
                else if (x <= 1)
                {
                    y = 2 * a * Math.Cos (x) + 3*x*x;
                }
                Console.WriteLine("x = {0} y = {1}", x.ToString(), y.ToString());
            }


            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey(); // Пауза 
        }
    }
}
