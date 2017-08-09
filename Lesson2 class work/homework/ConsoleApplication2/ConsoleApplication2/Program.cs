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
            // задача №1.9


            double a = 10.2, x = 2.2, b = 9.2, c = 0.5;
            double f = 0, z = 0;

            Console.WriteLine("Дано:");
            Console.WriteLine("a = {0}", a.ToString());
            Console.WriteLine("x = {0}", x.ToString());
            Console.WriteLine("b = {0}", b.ToString());
            Console.WriteLine("c = {0}", c.ToString());
            Console.WriteLine();
            f = Math.Log(a + x * x);
            f += Math.Sin(Math.Pow((x / b), 2));
            z = Math.Pow (Math.E, (-c*x));
            double z1 = x + Math.Sqrt(x + a);
            double z2 = x - Math.Log(Math.Abs(x - b));
            z *= z1 / z2;

            
            Console.WriteLine("f = {0} z = {1}", f.ToString(), z.ToString());

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey(); // Пауза
        }
    }
}
