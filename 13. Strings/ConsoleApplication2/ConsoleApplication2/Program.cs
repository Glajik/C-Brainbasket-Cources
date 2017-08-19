using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        /* Learning join strings */
        static void Main(string[] args)
        {
            string LastName;
            char OneChar;
            LastName = "Jhonson";
            OneChar = '&';
            Console.WriteLine(LastName + " " + OneChar + " " + LastName);
            Console.WriteLine();
            Console.WriteLine("Press Any Key");
            Console.ReadKey();
        }
    }
}
