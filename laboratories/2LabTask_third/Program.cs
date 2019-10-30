using System;

namespace _2LabTask_third
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double x, a, s = 0;
            bool ok;

            do
            {
                Console.WriteLine("Введите количество слагаемых");
                ok = int.TryParse(Console.ReadLine(), out n);
                if (!ok)
                    Console.WriteLine("Количество слагаемых должно быть целым числом!");
                else
                {
                    if (n <= 0)
                        Console.WriteLine("Количество слагаемых не может быть отрицательным");
                }
            } while (!ok);
            do
            {
                Console.WriteLine("Введите вещественное число");
                ok = double.TryParse(Console.ReadLine(), out x);
                if (!ok)
                    Console.WriteLine("Error!");
            } while (!ok);
            for (int i = 1; i <= n; i++)
            {
                double temp = Math.Pow(x, i);
                a = Math.Sin(temp);
                s += a;
            }

            Console.WriteLine($"S = {s}");
        }
    }
}
