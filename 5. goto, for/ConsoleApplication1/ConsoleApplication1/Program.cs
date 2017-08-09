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
            int i = 0;
            
            Metka:
            Console.WriteLine("{0}", i);
            i++;
            if (i < 9) goto Metka;
            Console.ReadKey();
        }
    }
}
