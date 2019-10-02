using System;

namespace _1LabTask_second
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            bool ok;
            do
            {
                Console.WriteLine("Введите вещественное число ");
                ok = double.TryParse(Console.ReadLine(), out x);
                if (!ok)
                {
                    Console.WriteLine("Error");
                };
            } while (!ok);
            do
            {
                Console.WriteLine("Введите вещественное число ");
                ok = double.TryParse(Console.ReadLine(), out y);
                if (!ok)
                {
                    Console.WriteLine("Error");
                };
            } while (!ok);
            ok = (x >= 0) & (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1);
            Console.WriteLine($"Результат = {ok}");
        }
    }
}
