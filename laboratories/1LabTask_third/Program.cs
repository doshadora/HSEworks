using System;

namespace _1LabTask_third
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double a = 100, b = 0.001;

                double c = Math.Pow(a - b, 3);
                double d = Math.Pow(a, 3);
                double e = 3 * a * a * b;
                double f = 3 * a * b * b;
                double g = Math.Pow(b, 3);
                double h = c - (d - e);
                double i = f - g;
                double j = h / i;
                Console.WriteLine(j);
            }
            {
                float a = 100, b = 0.001f;

                float c = (float)Math.Pow(a - b, 3);
                float d = (float)Math.Pow(a, 3);
                float e = 3 * a * a * b;
                float f = 3 * a * b * b;
                float g = (float)Math.Pow(b, 3);
                float h = c - (d - e);
                float i = f - g;
                float j = h / i;
                Console.WriteLine(j);
            }
        }
    }
}