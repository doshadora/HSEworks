using System;

namespace _9LabTask
{
    public class Diapason
    {
        public double X;
        public double Y;
        public static int count = 0;

        public double x
        {
            get { return X; }
            set { X = value; }
        }

        public double y
        {
            get { return Y; }
            set
            {
                if (value < x)
                {
                    Console.WriteLine($"Конец диапазона ({value}) меньше начала ({x})!");
                    return;
                }
                else
                {
                    Y = value;
                }
            }
        }

        public bool Point(double a)
        {
            if (a > x && a < y)
            {
                Console.WriteLine($" число {a} принадлежит диапазону [{x};{y}]");
                return true;
            }
            else
            {
                Console.WriteLine($" число {a} не принадлежит диапазону [{x};{y}]");
                return false;
            }
        }

        public static bool Point(Diapason d, double point)
        {
            if (point > d.x && point < d.y)
            {
                Console.WriteLine($"Число {point} принадлежит диапазону [{d.x};{d.y}]");
                return true;
            }
            else
            {
                Console.WriteLine($"Число {point} не принадлежит диапазону [{d.x};{d.y}]");
                return false;
            }
        }

        public static int GetCount()
        {
            return count;
        }

        public Diapason()
        {
            x = 0;
            y = 0;
            count++;
        }

        public Diapason(double X, double Y)
        {
            x = X;
            y = Y;
            count++;
        }

        public void Show()
        {
            if (x == y)
            {
                Console.WriteLine("Промежуток пустой");
            }
            else
            {
                Console.WriteLine($"Диапазон: от {x} до {y}");
            }
        }

        public static double operator !(Diapason d1) // вычисление длины диапазона
        {
            double m;
            m = d1.y - d1.x;
            return m;
        }

        public static Diapason operator ++(Diapason t1) // добавление единицы к границам диапазона
        {
            t1.x++;
            t1.y++;
            return t1;
        }

        public static explicit operator int(Diapason d) // явная операция
        {
            int xx = (int)d.x;
            return xx;
        }

        public static implicit operator double(Diapason d) // неявная операция
        {
            double yy = (double)d.y;
            return yy;
        }

        public static Diapason operator +(Diapason d1, int d)
        {
            Diapason d2 = new Diapason();

            d2.x = d1.x + d;
            d2.y = d1.y + d;
            return d2;
        }

        public static bool operator <(int k, Diapason d1)
        {
            if (k >= d1.x && k <= d1.y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(int k, Diapason d1)
        {
            bool ok = true;
            return ok;
        }
    }
}

