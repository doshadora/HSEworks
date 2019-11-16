using System;

namespace _3LabTask
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 15;
            int a1 = 1,  b1 = 1;
            double x, y, SN, SE, SE_last;
            const double a = 1, b = 2, k = 10, e = 0.0001;

            for (x = a; x <= b; x += (b - a) / k)
            {
                y = Math.Pow(Math.E, x);
                SN = a1;
                int factorial = 1;
                for (int i = 1; i <= n; i++)
                {
                    SN += (a1 + x/i) / (factorial *= i);
                }
                
                SE = b1;
                factorial = 1;
                int m = 1;
                do
                {
                    SE_last = SE;
                    SE += (b1 + x/m) / (factorial *= m);
                    m++;
                } while (SE - SE_last >= e);

                Console.WriteLine($"X = {x} SN = {SN} SE = {SE} Y = {y}");
            }
            Console.ReadKey();
        }
    }
}