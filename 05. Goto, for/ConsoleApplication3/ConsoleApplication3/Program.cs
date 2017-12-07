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
            // Задание номер 5.2
            double t = 1; 
            double s = 0;
            for (int a = 1; a <= 5; a++)
                for (int c = 1; c <= 10; c++)
                {
                    s += Math.Log10(a + c);
                    t *= s;
                }
            Console.WriteLine("{0}", t);
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }
    }
}
