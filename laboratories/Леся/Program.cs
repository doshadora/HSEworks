using System;

namespace Леся
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                const double
                a = 1,
                b = 2,
                e = 0.0001;
                const int n = 15;
                double x, y, SN, SE, SE_last;
                for (x = a; x <= b; x += (b - a) / 10) 
                {

                    y = Math.Pow(Math.E, x);

                    SN = 1;
                    int fact = 1;
                    for (int i = 1; i <= n; i++)
                    {
                        SN += (Math.Pow(x, i)) / (fact *= i);

                    }
                    fact = 1;
                    SE = 1;
                    int k = 1;
                    do
                    {
                        SE_last = SE;
                        SE += (Math.Pow(x, k)) / (fact *= k);
                        k++;

                    } while (SE - SE_last >= e);
                    Console.WriteLine($"X = {x} SN = {SN} SE = {SE} Y = {y}");
                }
                Console.ReadKey();
            }
        }
    }
}