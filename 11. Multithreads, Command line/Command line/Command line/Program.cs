using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Works with command line arguments and calcelate factorial of typed value
 * e.g. "command_line -f 5"
 * or outputs help with args. "command_line /?"
 */
namespace command_line
{
    class Program
    {
        static void help ()
        {
            Console.WriteLine("command_line -f [value] - calculate Factorial of value");
            Console.WriteLine("command_line /? - help");
        }

        static void Factorial(string b) 
        {
            double n = 1;
            double d = 0;
            for (double i = 0; i < Convert.ToDouble(b); i++) 
                {
                d++;
                n*=d;
                }
            Console.WriteLine("Factorial {0} = {1}", b, n);
        }
        
                
        static void Main(string[] args)
        {
            if (args.Length != 0)
                switch (args[0])
                {
                    case "-f":
                        Factorial(args[1]);
                        break;
                    case "/?":
                        help();
                        break;
                    default:
                        Console.WriteLine("Invalid arguments, try enter 'command_line /?'");
                        break;
                }
            else
            {
                Console.WriteLine("Do nothing, try enter 'command_line /?'");
            }
        }
       
    }
}
