using System;

namespace _2LabTask_second
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, q = 0;
            bool ok;

            do
            {
                Console.WriteLine("Введите целое число");
                ok = int.TryParse(Console.ReadLine(), out a);
                if (!ok)
                {
                    Console.WriteLine("Введено не целое число!");
                }
                else
                {
                    if (a % 2 == 0) q++;
                }
            } while (!ok || a != 0);

            Console.WriteLine($"Количество четных элементов = {q - 1}");
        }
    }
}
