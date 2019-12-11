using System;

namespace Pract2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 15, b = 2, k = 10;
            double a = 1;
            double e = 0.0001;
            double h, x, Y, u, r, SN, SE, d;

            h = (b - a) / k;



            for (x = a; x <= b; x += h)
            {


                u = x;
                d = x;
                r = 1;

                SE = x + 1;
                SN = x + 1;

                Y = Math.Exp(x);

                for (int i = 2; i <= n; i++)
                {
                    u *= x / i;

                    SN += u;
                }

                do
                {
                    d *= x / r;

                    r++;

                    SE += d;

                } while (Math.Abs(d) < e);

                Console.WriteLine($"X = {x}, SN = {SN}, SE = {SE}, Y = {Y}");



            }

        }
    }
}

