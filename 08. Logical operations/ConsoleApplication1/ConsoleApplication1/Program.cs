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
            bool b = true;
            int j = 4; // Размер сдвига
            int i = 0;

            Console.WriteLine("Введите значение для i1: ");
            int i1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение для i2: ");
            int i2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------");
            Console.WriteLine();
            
            // Операция НЕ
            Console.WriteLine ("Not {0} = {1}", b, !b);
            Console.WriteLine();
            
            // Операция ИЛИ
            Console.WriteLine("{0} Or {1} = {2}", i1, i2, i1 | i2);
            Console.WriteLine();
            
            // Операция И
            Console.WriteLine("{0} And {1} = {2}", i1, i2, i1 & i2);
            Console.WriteLine();

            // Операция исключающее ИЛИ
            Console.WriteLine("{0} Xor {1} = {2}", i1, i2, i1 ^ i2);
            Console.WriteLine();

            // Логический сдвиг влево
            i = i1 ^ i2;
            Console.WriteLine("Исходное число {0}", i);
            Console.WriteLine("Логический сдвиг влево на {0} бита {1}", j, i << j);
            Console.WriteLine();


            // Логический сдвиг вправо
            Console.WriteLine("Логический сдвиг вправо на {0} бита {1}", j, i >> j);
            Console.WriteLine();

            Console.WriteLine("Нажмите любую клавишу чтобы закрыть окно.");
            
            Console.ReadKey();
        }
    }
}
