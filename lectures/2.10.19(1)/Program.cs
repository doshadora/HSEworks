using System;

namespace _2._10._19_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, n;
            double s = 0, sar;
            bool ok;

            do
            {
                Console.WriteLine("Введите количество чисел ");
                ok = int.TryParse(Console.ReadLine(), out n);
                if (!ok)
                {
                    Console.WriteLine("Error!");
                }
                else
                {
                    if (n <= 0)
                    {
                        Console.WriteLine("Error");
                        ok = false;
                    }
                }

            } while (!ok);

            for (int i = 1; i <= n; i++)
            {
                do
                {
                    Console.WriteLine("Введите число");
                    ok = int.TryParse(Console.ReadLine(), out a);
                    if (!ok) Console.WriteLine("Error!");
                } while (!ok);

                s += a;

            }

            sar = s / n;

            Console.WriteLine($"Среднее арифметическое = {sar}");
        }
    }
}
