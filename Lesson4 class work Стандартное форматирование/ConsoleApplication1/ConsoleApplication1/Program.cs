using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Стандартное форматирование

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = -12.345678956789;
            int i = 123456789;
            Console.Write("Число с плавающей точкой  ");
            Console.WriteLine(d);
            Console.WriteLine();
            Console.Write("G формат - общий          ");
            Console.WriteLine("{0,8:G}", d);
            Console.Write("F формат - с фикс. точкой ");
            Console.WriteLine("{0,8:F}", d);
            Console.Write("N формат - числовой       ");
            Console.WriteLine("{0,8:N}", d);
            Console.Write("E формат - научный        ");
            Console.WriteLine("{0,8:E}", d);
            Console.Write("C формат - денежный       ");
            Console.WriteLine("{0,8:C}", d);
            Console.Write("P формат - процентный     ");
            Console.WriteLine("{0,8:P}", d);
            Console.WriteLine();
            Console.Write("Число целое               ");
            Console.WriteLine(i);
            Console.WriteLine();
            Console.Write("D формат - десятичный     ");
            Console.WriteLine("{0,8:D}", i);
            Console.Write("С формат - денежный       ");
            Console.WriteLine("{0,8:C}", i);
            Console.Write("P формат - процентный     ");
            Console.WriteLine("{0,8:P}", i);
            Console.Write("X формат - 16-ричный      ");
            Console.WriteLine("{0,8:X}", i);
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
