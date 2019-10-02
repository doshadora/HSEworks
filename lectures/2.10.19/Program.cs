using System;

namespace _2._10._19
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1000, b = 0.0001;

            double c = Math.Pow(a - b, 3);
            double d = Math.Pow(a, 2);
            double e = 2 * a * b;
            double f = b * b;
            double g = c - (d + e);
            double h = g / f;
            Console.WriteLine(h);

        }
    }
}