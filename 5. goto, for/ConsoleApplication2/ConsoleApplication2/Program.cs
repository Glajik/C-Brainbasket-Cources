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
            // Задание номер 4
            double z = 0, a = 2.8, c = 1.8;
            for (int k = 1; k <= 11; k++) z += Math.Cos(a * k) + Math.Sin(c);
            Console.WriteLine("{0}", z);
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }
    }
}
