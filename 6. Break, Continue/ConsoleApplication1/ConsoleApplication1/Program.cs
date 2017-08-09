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
            // 8.4 Команда Break
            // Программа ищет простые числа в диапазоне от n до 1, и выводит их в списке. 
            // Находя же сложные числа выводит их и делитель.
            int n = 37;
            int i = n;
            int k = n - 1;
            Boolean flag = false;

            while (i > 1)
            {
                k = i - 1;
                while (k > 1)
                {
                    //Console.WriteLine("{0} % {1} = {2}", i, k, i % k);
                    if (i % k == 0)
                    {
                        //Console.WriteLine("!!! {0} % {1} = {2}", i, k, i % k);
                        flag = true;
                        break;
                    }
                    k--;
                }
                if (flag)
                {
                    Console.WriteLine("Число {0, 3} не простое, и делится на {1, 3}", i, k);
                    flag = false;
                    //break;
                }
                else
                    Console.WriteLine("Число {0, 3} простое", i);
                i--;
            }

            Console.ReadLine();
        }
    }
}
