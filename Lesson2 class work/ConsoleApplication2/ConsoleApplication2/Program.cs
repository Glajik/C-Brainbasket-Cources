using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Консольное приложение №2. Пример №3

            double a = 2.8, b = -0.3, c = 4;
            double x = 0, y = 0;

            Console.WriteLine("Дано:");
            Console.WriteLine("a = {0}", a.ToString());
            Console.WriteLine("b = {0}", b.ToString());
            Console.WriteLine("c = {0}", c.ToString());
            Console.WriteLine();

            Console.WriteLine(" Таблица y(x):"); // Заголовок

            for (x = 1; x <= 2; x += 0.25)
            {
                if (x < 1.2)
                {
                    y = a * Math.Pow(x, 2) + b * x + c;
                }
                else if (x == 1.2)
                {
                    y = a / x + Math.Sqrt(Math.Pow(x, 2) - 1);
                }
                else
                {
                    y = (a + b * x) / Math.Sqrt(Math.Pow(x, 2) + 1);
                }
                Console.WriteLine("x = {0} y = {1}", x.ToString(), y.ToString());
            }


            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey(); // Пауза 
        }
    }
}
