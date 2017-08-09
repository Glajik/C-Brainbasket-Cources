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
            string d1, s, f;
            Console.WriteLine("Введите вашу фамилию");
            f = Console.ReadLine();
            Console.WriteLine("Введите дату рождения дд.мм.гггг");
            d1 = Console.ReadLine();
            DateTime dt1 = Convert.ToDateTime(d1);
            Console.WriteLine();
            Console.WriteLine("Ваша фамилия - " + f);
            Console.WriteLine();
            Console.WriteLine("Вы рождены " + dt1);
            Console.WriteLine();
            DateTime dt2 = DateTime.Now;
            Console.WriteLine("Сегодня " + dt2);
            Console.WriteLine();
            int i = (dt2.Year - dt1.Year) * 365;
            Console.WriteLine("Вы прожили " + i + " дней");
            Console.WriteLine();
            Console.WriteLine("Сколько дней вы еще хотите учиться?");
            s = Console.ReadLine();
            dt2 = dt2.AddDays(Convert.ToInt32(s));
            Console.WriteLine("");
            Console.WriteLine("Вы станете умным " + dt2);
            Console.WriteLine("");
            Console.WriteLine("Это будет " + dt2.DayOfWeek);
            Console.WriteLine();
            Console.WriteLine("День недели на английском, если что ;)");
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу чтобы закрыть окно.");
            Console.ReadKey();


        }
    }
}
