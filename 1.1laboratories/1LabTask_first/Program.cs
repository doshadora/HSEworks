using System;

namespace _1LabTask_first
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, res1;
            bool res2, res3, ok;
            double x, res4;

            do
            {
                Console.WriteLine("Введите первое целое число");
                ok = int.TryParse(Console.ReadLine(), out n);
                if (!ok) Console.WriteLine("Error!");

            } while (!ok);
            do
            {
                Console.WriteLine("Введите второе целое число");
                ok = int.TryParse(Console.ReadLine(), out m);
                if (!ok) Console.WriteLine("Error!");

            } while (!ok);

            res1 = --m - n++;
            Console.WriteLine($"--m-n++={res1},m={m},n={n}");
            res2 = m * m < n++;
            Console.WriteLine($"m*m<n++={res2},m={m},n={n}");
            res3 = n-- > ++m;
            Console.WriteLine($"n-->++m={res3},m={m},n={n}");
            do
            {
                Console.WriteLine("Введите вещественное число");
                ok = double.TryParse(Console.ReadLine(), out x);
                if (!ok)
                {
                    Console.WriteLine("Error");
                }
            } while (!ok);

            res4 = Math.Tan(x) - Math.Pow(5 - x, 4);
            Console.WriteLine($"Math.Tan(x)-Math.Pow((5-x),4)={res4},x={x}");
        }
    }
}
