using System;

namespace _3LabTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 15;
            double a = 1, b = 2, k = 10, e = 0.0001, h, x, y, SN, an, S, SE;

            h = (b - a) / k;
            x = a;
            int factorial = 1;

            while (x <= b)
            {
                for (int i = 1; i < n; i++)
                {
                    factorial *= i;
                }

                y = Math.Pow(e, x);
                S = Math.Pow(x, n) / factorial;
                an = 1;
                SN = S;
                for (int i = 1; i < n; i++)
                {
                    an += y;
                    SN += an;
                }

                an = 1;
                SE = S;
                while (an > e)
                {
                    an *= y;
                    SE += an;
                }

                Console.WriteLine($"X = {x} SN = {SN} SE = {SE} Y = {y}");
                x += h;
            }
        }
    }
}
