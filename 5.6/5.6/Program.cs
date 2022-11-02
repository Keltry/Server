using System;

namespace _5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.6
            //Имеется 2 события, время происхождения которых задано тройкой целых чисел,
            //например: 11 часов, 12 минут, 46 секунд.
            //Определить (и вывести) время того события, которое произошло раньше.


            TimeSpan a = (11, 14, 46);
            TimeSpan b = (10, 45, 10);
            TimeSpan c = (11, 12, 46);
            if (c > a)
                Console.WriteLine("Это событие произошло позже : " + a);
            else if (c > b)
                Console.WriteLine("Это событие прошло раньше : " + b);

        }
    }
}
