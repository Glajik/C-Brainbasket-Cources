using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// 3.3 Нестандартное форматирование

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = -12345.678956789;
            Console.Write("Число с плавающей точкой ");
            Console.WriteLine(d);
            Console.WriteLine();
            Console.Write("формат с символами Е+0       ");
            Console.WriteLine("{0:00E+000}", d);
            Console.Write("формат с символами Е-0       ");
            Console.WriteLine("{0:00E-000}", d);
            Console.Write("формат с символом #          ");
            Console.WriteLine("{0:###}", d);
            Console.Write("формат с символом точка      ");
            Console.WriteLine("{0:###.000}", d);
            Console.Write("формат с символом запятая    ");
            Console.WriteLine("{0:###,000}", d);
            Console.Write("формат с символом %          ");
            Console.WriteLine("{0:###.000%}", d);
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();


        }
    }
}
