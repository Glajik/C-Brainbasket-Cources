using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        // GLOBAL VARIABLE
        static bool stopThread = false;

        // Secondary Thread
        public static void MyThread()
        {
            Console.WriteLine("MyThread works ");
            // Endless loop
            int seconds = 0;
            for (int i = 0; ; i++)
            {
                // Condition of stop Thread
                if (stopThread) break;

                Console.Write(".");

                Thread.Sleep(1000);

                seconds = i;
            }
            Console.WriteLine("Thread 'MyThread' is stopped on {0} sec.", seconds);
        }
        
        [STAThread]
        static void Main (string[] args)
        {
            // init new secondary thread 'MyThread'
            ThreadStart myThreadDelegate = new ThreadStart(MyThread);
            Thread thr = new Thread(myThreadDelegate);
            Console.WriteLine("Starting thread 'MyThread'");
            stopThread = false;
            thr.Start();
            string str = "";
            do
            {
                Console.WriteLine("Enter 'x', then press [Enter] to exit)");
                str = Console.ReadLine();
                Console.WriteLine("Main Thread: {0}", str);
            }
            while (str != "x");
            stopThread = true;
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}