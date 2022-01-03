using System;

namespace Min_number
{
    class Program
    {
        static void Main()
        {
            int a, b, c, min = 0;
            Console.WriteLine("Введите три целых числа: ");
            Console.WriteLine("Первое: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Второе: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Третье: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (b > a && a < c)
            {
                min = a;
            }
            if (a > b && b < c)
            {
                min = b;
            }
            if (a > c && c < b)
            {
                min = c;
            };
            Console.WriteLine("Наименьшее число {0}", min);
            Console.ReadLine();
        }
    }
}
