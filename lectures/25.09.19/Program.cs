using System;

namespace _25._09._19
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, max;
            bool ok;

            do
            {
                Console.WriteLine("Введите первое целое число");
                ok = int.TryParse(Console.ReadLine(), out a);
                if (!ok) Console.WriteLine("Error!");

            } while (!ok);
            do
            {
                Console.WriteLine("Введите второе целое число");
                ok = int.TryParse(Console.ReadLine(), out b);
                if (!ok) Console.WriteLine("Error!");

            } while (!ok);
            do
            {
                Console.WriteLine("Введите третье целое число");
                ok = int.TryParse(Console.ReadLine(), out c);
                if (!ok) Console.WriteLine("Error!");

            } while (!ok);
            if (a > b) max = a;
            else max = b;
            if (max < c) max = c;
            Console.WriteLine($"max={max}");
        }
    }
}