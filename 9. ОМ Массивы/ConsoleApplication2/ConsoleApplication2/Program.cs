using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Задание: Создать массив из случайных целых чисел на 18 элементов и выполнить следующее:
 * 1. Вычислить среднее арифметическое элементов с минимальным и максимальным значениями.
 * 2. Вывести на экран индекс этих элементов.
 * 3. Вычислить среднее арифметическое элементов, значение которых больше, чем значение последнего элемента массива.
 * 4. Упорядочить по убыванию первую половину массива.
*/
 
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ARRAY_MAX = 18;
            int[] MyArray = new int[ARRAY_MAX];
            Random rnd = new Random();
            int min = 101, max = -101, min_i = -1, max_i = -1, n_summ_sr = 0, swap = 0;
            double summ_sr = 0;

            Console.WriteLine("Создаем массив случайных чисел от -100 до 100: ");
            Console.WriteLine("№    Значение:");
            Console.WriteLine("---+----------");
            for (int i = 0; i < ARRAY_MAX; i++) {
                
                MyArray[i] = rnd.Next(-100,100);
                
                Console.WriteLine("{0, 2}  {1, 3} ", i, MyArray[i]);
                
                if (MyArray[i] < min)
                {
                    min = MyArray[i];
                    min_i = i;
                }
                if (MyArray[i] > max)
                {
                    max = MyArray[i];
                    max_i = i;
                }
                if (MyArray[i] > MyArray[ARRAY_MAX-1])
                {
                    summ_sr += MyArray[i];
                    n_summ_sr++;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Среднее арифметическое минимального и максимального элементов: {0}", Convert.ToString((double)(min + max) / 2));
            Console.WriteLine("Индексы минимального и максимального элементов соответственно: {0} и {1}", min_i, max_i);
            if (n_summ_sr > 0)
            {
                Console.WriteLine("Среднее арифметическое элементов, значение которых больше чем последний элемент массива: {0}", Convert.ToString(summ_sr/n_summ_sr));
            }
            else 
                Console.WriteLine("Среднее арифметическое элементов, значение которых больше чем последний элемент массива вычислить не возможно, т.к. последний элемент больше всех остальных. Попробуйте запустить программу, уверен - вам повезет))");

            Console.WriteLine();
            Console.WriteLine("Упорядочить по убыванию первую половину массива: ");
            Console.WriteLine("№    Значение:");
            Console.WriteLine("---+----------");
            for (int i = ARRAY_MAX/2; i >= 0; i--)
            {
                for (int j = i; j >= 0; j--)
                {
                    if (MyArray[i] > MyArray[j])
                    {
                        swap = MyArray[i];
                        MyArray[i] = MyArray[j];
                        MyArray[j] = swap;
                    }
                }
            }
             for (int i = 0; i < ARRAY_MAX; i++)       Console.WriteLine("{0, 2}  {1, 3} ", i, MyArray[i]);
            Console.WriteLine("Нажмите любую клавишу чтобы закрыть консоль.");
            Console.ReadKey();
        
        }
    }
}
