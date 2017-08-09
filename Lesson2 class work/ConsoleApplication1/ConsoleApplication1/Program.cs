using System;
namespace ConsoleLineStr
{
    class Program
    {
        static void Main()
        {
            // Косольное приложение №1.Пример №5
            double x = 0.61, a = 16.5, b = 3.4; // Переменные типа double 
            double s = 0, g = 0;

            Console.WriteLine("a={0}", a.ToString()); // Вывод g
            Console.WriteLine("b={0}", b.ToString()); // Вывод g
            Console.WriteLine("x={0}", x.ToString()); // Вывод g
            Console.WriteLine();

            s = Math.Pow (x,3) * Math.Pow(Math.Tan(Math.Pow((x+b),2)),2); // Вычисляем a 
            s += a / Math.Sqrt(x + b);
            g = (b * x * x - a) / (Math.Pow(Math.E, a*x) - 1); // Вычисляем g 

            Console.WriteLine("Результаты");
            Console.WriteLine();
            Console.WriteLine("s={0}", s.ToString()); // Вывод s 
            Console.WriteLine("g={0}", g.ToString()); // Вывод g 
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey(); // Пауза 
        }
    }
}
