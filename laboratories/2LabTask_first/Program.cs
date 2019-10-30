using System;

namespace _2LabTask_first
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, n;
            double s = 0;
            bool ok;

            do
            {
                Console.WriteLine("Введите количество чисел ");
                ok = int.TryParse(Console.ReadLine(), out n);
                if (!ok)
                {
                    Console.WriteLine("Число не является целым!");
                }
                else
                {
                    if (n <= 0)
                    {
                        Console.WriteLine("Количество чисел не может быть отрицательным!");
                        ok = false;
                    }
                }

            } while (!ok);

            for (int i = 1; i <= n; i++)
            {
                do
                {
                    Console.WriteLine("Введите целое число");
                    ok = int.TryParse(Console.ReadLine(), out a);
                    if (!ok) Console.WriteLine("Число не является целым!!");
                } while (!ok);

                if (i % 2 != 0)
                    s += a;
            }
            Console.WriteLine($"Сумма элементов с нечетными номерами = {s}");
        }
    }
}
