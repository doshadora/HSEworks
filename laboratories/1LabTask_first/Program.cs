using System;

namespace _1LabTask_first
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, k;
            bool ok;

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

            if (n == 1)
                Console.WriteLine("Error!");
            else
            {
                k = m++ / --n;
                Console.WriteLine($"m++/--n={k},m={m},n={n}");
            }
        }
    }
}
