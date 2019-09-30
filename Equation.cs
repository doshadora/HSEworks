using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doshadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C; // коэффициенты
            double D; // дискриминант
            double x; // корень
            bool ok = false; // проверка ввода чисел

            Console.WriteLine("Введите значение коэффициента А: ");
            do
            {
                string buf = Console.ReadLine();
                ok = Double.TryParse(buf, out A);
                if (!ok) Console.WriteLine("Ошибка! Введите вещественное значение А");

            } while (!ok);

            Console.WriteLine("Введите значение коэффициента B");
            do
            {
                string buf = Console.ReadLine();
                ok = Double.TryParse(buf, out B);
                if (!ok) Console.WriteLine("Ошибка! Введите вещественное значение B");

            } while (!ok);

            Console.WriteLine("Введите значение коэффициента C");
            do
            {
                string buf = Console.ReadLine();
                ok = Double.TryParse(buf, out C);
                if (!ok) Console.WriteLine("Ошибка! Введите вещественное значение C");

            } while (!ok);

            if (A == 0)
            {
                if (B == 0)
                {
                    if (C == 0)
                    {
                        Console.WriteLine("Х - любое число");
                    }
                    else
                    {
                        Console.WriteLine("Нет решений");
                    }

                }
                else
                {
                    x = -C / B;
                    Console.WriteLine("Корень уравнения равен: "+x);
                }

            }
            else
            {
                Math.Sqrt(x);
            }

            Console.ReadLine();
        }
    }
}
