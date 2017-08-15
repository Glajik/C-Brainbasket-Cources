using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
     /* Обработка матрицы. Задание 24. В матрице целых чисел размером 7х4 определить
      * наименьший элемент из числа положительных и наибольший из числа отрицательных
      * и поменять их местами
      */


        static void Main(string[] args)
        {
            int LengthR = 4, LengthC = 7;
            int min_indexR = 0;
            int min_indexC = 0;
            int min_value = 100;
            int max_indexR = 0;
            int max_indexC = 0;
            int max_value = -100;
 
            Console.WriteLine();
            Console.WriteLine("Вывод матрицы 7x4:");
            Console.WriteLine();

            int[,] Matrix = new int[LengthR,LengthC];

            Random rnd = new Random();

            for (int indexR = 0; indexR < LengthR; indexR++)
            {
                for (int indexC = 0; indexC < LengthC; indexC++)
                {
                    Matrix[indexR, indexC] = rnd.Next(-99, 99);
                    Console.Write("{0,3:0}  ", Matrix[indexR, indexC]);
                    
                    // find minimal value from positive elements
                    if (Matrix[indexR, indexC] > 0 &&
                        Matrix[indexR, indexC] < min_value)
                    {
                        min_indexR = indexR;
                        min_indexC = indexC;
                        min_value = Matrix[indexR, indexC];
                    }

                    // find max value from negative elements
                    if (Matrix[indexR, indexC] < 0 &&
                        Matrix[indexR, indexC] > max_value)
                    {
                        max_indexR = indexR;
                        max_indexC = indexC;
                        max_value = Matrix[indexR, indexC];
                    }
                }
                Console.WriteLine("\n\n"); 
            };
            Console.WriteLine();
            Console.WriteLine("Минимальный элемент из положительных с индексом RC[{0},{1}] = {2}", min_indexR+1, min_indexC+1, Matrix[min_indexR, min_indexC]);
            Console.WriteLine("Максимальный элемент из отрицательных с индексом RC [{0},{1}] = {2}", max_indexR+1, max_indexC+1, Matrix[max_indexR, max_indexC]);
            Console.WriteLine();
            Console.WriteLine("Меняем местами эти элементы и выводим матрицу еще раз:");
            Console.WriteLine();

            // swap finded elements
            int swap = Matrix[min_indexR, min_indexC];
            Matrix[min_indexR, min_indexC] = Matrix[max_indexR, max_indexC];
            Matrix[max_indexR, max_indexC] = swap;

            // print matrix 
            for (int indexR = 0; indexR < LengthR; indexR++, Console.WriteLine("\n\n"))
                for (int indexC = 0; indexC < LengthC; indexC++)
                    Console.Write("{0,3:0}  ", Matrix[indexR, indexC]);

            Console.WriteLine("Нажмите любую клавишу, чтобы закрыть окно.");
            Console.ReadKey();
        }
  
    }
}
