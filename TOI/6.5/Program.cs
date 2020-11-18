using System;

namespace _6._5
{
    class Program
    {
        static int Fact(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Fact(x - 1);
            }
        }

        static void Main(string[] args)
        {
            double eps, x, x1, x2, y, se, se1, se2, an, an1, an2;
            eps = 0.00005;
            x = 0.1; x1 = 0.3; x2 = 0.5;
            an = 1; an1 = 1; an2 = 1;
            se = 1; se1 = 1; se2 = 1;

            int n = 1;

            while (an > eps)
            {
                an = Math.Pow(-1, n) * Math.Pow(x, 2 * n) / Fact(2 * n);
                se += an;
                y = Math.Cos(x / 3);
                Console.WriteLine($"X = {x} Y = {y:0.000} SE = {se:0.000}");

                an1 = Math.Pow(-1, n) * Math.Pow(x1, 2 * n) / Fact(2 * n);
                se1 += an1;
                y = Math.Cos(x1 / 3);
                Console.WriteLine($"X = {x1} Y = {y:0.000} SE = {se1:0.000}");

                an2 = Math.Pow(-1, n) * Math.Pow(x2, 2 * n) / Fact(2 * n);
                se2 += an2;
                y = Math.Cos(x2 / 3);
                Console.WriteLine($"X = {x2} Y = {y:0.000} SE = {se2:0.000}");
                n++;
            }
        }
    }
}
