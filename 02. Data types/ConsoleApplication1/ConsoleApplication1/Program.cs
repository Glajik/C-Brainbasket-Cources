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
            Console.WriteLine("Convert int to other types");
            int i = 190;
            Int16 i1 = (Int16) i;
            Int32 i2 = i;
            Int64 i3 = (Int64)i;
            byte i4 = (Byte)i;
            sbyte i5 = (sbyte) i;
            Console.WriteLine("Types  {0,8}{1,8}{2,8}{3,8}{4,8}{5,8}", "int", "Int16", "Int32", "Int64", "byte", "sbyte");
            Console.WriteLine("Values {0,8}{1,8}{2,8}{3,8}{4,8}{5,8}", i, i1, i2, i3, i4, i5);
            Console.WriteLine("Bytes  {0,8}{1,8}{2,8}{3,8}{4,8}{5,8}", sizeof(int), sizeof(Int16), sizeof(Int32), sizeof(Int64), sizeof(byte), sizeof(sbyte));
            Console.WriteLine();
            double d = i;
            Single s = i;
            Console.WriteLine("Types  {0,8}{1,8}{2,8}", "int", "double", "single");
            Console.WriteLine("Values {0,8}{1,8}{2,8}", i, d, s);
            Console.WriteLine("Bytes  {0,8}{1,8}{2,8}", sizeof(int), sizeof(double), sizeof(Single));
            Console.WriteLine ();
            Console.WriteLine("Press any key");
            Console.ReadKey();


        }
    }
}
