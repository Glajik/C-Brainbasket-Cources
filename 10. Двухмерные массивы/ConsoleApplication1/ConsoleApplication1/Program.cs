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
            int LengthR = -1, LengthC = -1;
            bool valid = false;
            Console.WriteLine("Введите количество строк матрицы:");
            do
            {
                string s = Console.ReadLine();
                if (s.Length > 0 && s.Length < 2)
                {
                    char[] c = s.ToCharArray(0, 1);
                    if (c[0] >= '2' && c[0] <= '9')
                    {
                        Console.WriteLine("ok");
                        int a = Convert.ToInt32(s);
                        Console.WriteLine(a);
                        valid = true;
                        LengthR = a;
                    }
                }
                if (!valid) Console.WriteLine("Повторите еще раз, это должно быть число от 2 до 10.");
            }
            while (!valid);

            valid = false;

            Console.WriteLine("Введите количество столбцов матрицы:");
            do 
            {
                string s = Console.ReadLine();
                if (s.Length > 0 && s.Length < 2)
                {
                    char[] c = s.ToCharArray(0, 1);
                    if (c[0] >= '2' && c[0] <= '9')
                    {
                        Console.WriteLine("ok");
                        int a = Convert.ToInt32(s);
                        valid = true;
                        LengthC = a;
                    }
                }
                if (!valid) Console.WriteLine("Повторите еще раз, это должно быть число от 2 до 10.");
            }
            while (!valid);
        }
    }
}
