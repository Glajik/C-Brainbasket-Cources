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
            // Вариант № 9.
            // Определить сумму элементов массива кратных 3
            // Количество элементов массива - 50
            
            const int ARRAY_MAX = 50;
            int[] MyArray = new int[ARRAY_MAX];
            Random rnd = new Random();
            int summ = 0;

            Console.WriteLine("No: Value:");
            Console.WriteLine("----------");
            for (int i = 0; i < ARRAY_MAX; i++) {
                MyArray[i] = rnd.Next(0,100);
                Console.WriteLine("{0:00}: {1:000}", i, MyArray[i]);
                if ( ((int)(MyArray[i]/3))*3 == MyArray[i]) 
                    summ += MyArray[i];

            }
            Console.WriteLine("Сумма элементов массива, кратных трём - {0}", summ);
            Console.WriteLine("Нажмите любую клавишу чтобы закрыть консоль.");
            Console.ReadKey();
        }
    }
}
