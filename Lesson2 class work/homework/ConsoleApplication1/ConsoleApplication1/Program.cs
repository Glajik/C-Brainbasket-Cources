using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // задача №1.2

            
            double x = 0.33, y = 0.02;
            double s = 0, w = 0;

            Console.WriteLine("Дано:");
            Console.WriteLine("x = {0}", x.ToString());
            Console.WriteLine("y = {0}", y.ToString());
            Console.WriteLine();
            s =  1 + x;
            s += Math.Pow(x, 2) / (1*2);
            s += Math.Pow(x, 3) / (1 * 2 * 3);
            s += Math.Pow(x, 4) / (1 * 2 * 3 * 4);

            w = x * (Math.Sin(x) + Math.Cos(y));
            Console.WriteLine("s = {0} w = {1}", s.ToString(), w.ToString());
            
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey(); // Пауза 
        }
    }
}
