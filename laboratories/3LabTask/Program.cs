using System;

namespace _3LabTask
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 15;
            double x, y, SN, SE, an = 1, bn = 1;
            const double a = 1, b = 2, k = 10, e = 0.0001;

            for (x = a; x <= b; x += (b - a) / k)
            {
                y = Math.Exp(x);
                an = 1;
                SN = 1;
                for (int i = 1; i <= n; i++)
                {
                    an *= x / i;  
                    SN += an;
                }

                bn = 1;
                SE = 1;
                int m = 1;
                do
                {
                    bn *= x / m;
                    SE += bn;
                    m++;
                } while (Math.Abs(bn) > e);
                var yy = string.Format("{0:0.000}", y);
                var snsn = string.Format("{0:0.000}", SN);
                var sese = string.Format("{0:0.000}", SE);
                Console.WriteLine($"X= {x} Y= {yy} SN={snsn} SE={sese}");
            }
            Console.ReadKey();
        }
    }
}

