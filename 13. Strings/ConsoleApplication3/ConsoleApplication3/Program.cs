using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        /* Learning divide strings */
        static void Main(string[] args)
        {
            // 'string of word for Demo
            string allAnimals = "Snake Leo Cat Bird Monkey Rat";

            // Array for apart words
            string[] WordArray;

            // suggest to User to enter few words
            Console.WriteLine("Enter few words, or simple press Enter for a Demo");
            string userInput = Console.ReadLine();

            // if User lazy and enter nothing - use demo string allAnimals
            if (userInput.Length == 0) userInput = allAnimals;


            Console.WriteLine("Sourse string is '" + userInput + "'");
            Console.WriteLine();

            Console.WriteLine("Divided by words:");

            // Divide incoming string by words with ' ' 
            WordArray = userInput.Split(' ');

            // Print number and words to console
            int i = 0;
            foreach (string word in WordArray)
            {
                Console.WriteLine(i.ToString() + ". " + word);
                i++;
            }

            Console.WriteLine("\n Press any key to exit.");
            Console.ReadKey();
        }
    }
}
