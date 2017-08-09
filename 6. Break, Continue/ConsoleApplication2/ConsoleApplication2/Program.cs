using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        // 8.5 continue
        // программа ищет и выводит нечетные числа в диапазоне от 99 до 1
        static void Main(string[] args)
        {
            for (int i = 99; i > 0; i--)
            {
                if (i % 2 == 0) continue;
                Console.WriteLine("{0} - нечетное число",  i);
                
            }
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadLine();
        }
    }
}
