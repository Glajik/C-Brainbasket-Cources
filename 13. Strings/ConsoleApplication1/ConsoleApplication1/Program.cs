using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        /* Learn comparing strings */
        static void Main(string[] args)
        {
            string allAnimals = "Leo, Cat, Dog, Monkey, Snake";
            string homePets = "Cat, Dog";
            Console.WriteLine("Compared strings:");
            Console.WriteLine("allAnimals = {0} and homePets = {1}", allAnimals, homePets);
            Console.WriteLine();
            int v1 = homePets.CompareTo(allAnimals);
            Console.WriteLine("Compare homePets with AllAnimals. Result: " + v1.ToString());
            int v2 = homePets.CompareTo(homePets);
            Console.WriteLine("Compare homePets with homePets. Result: " + v2.ToString());
            int v3 = allAnimals.CompareTo(homePets);
            Console.WriteLine("Compare AllAnimals with homePets. Result: " + v3.ToString());
            int v4 = allAnimals.CompareTo("test string");
            Console.WriteLine("Compare AllAnimals with 'test string'. Result: " + v4.ToString());
            Console.WriteLine();
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
