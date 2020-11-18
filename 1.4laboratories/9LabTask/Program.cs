using System;

namespace _9LabTask
{
    class Program
    {
        public static double maxLength = 0;

        //public static void Compare(double d)
        //{
        //    if (d > 0)
        //    {
        //        if (maxLength <= d) maxLength = d;
        //    }
        //}

        public static void Compare(DiapasonArray arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (maxLength <= arr[i].y - arr[i].x)
                {
                    maxLength = arr[i].y - arr[i].x;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Демонстрационные тесты");
            Console.WriteLine("----------------------");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Переменные не заданы");
            Console.ResetColor();

            Diapason d1 = new Diapason();
            d1.Show();


            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Переменные заданы, число попадает в промежуток");
            Console.ResetColor();

            d1 = new Diapason(3.2, 7.9);
            Diapason.Point(d1, 4.4);
            //maxLength = !d1;
            Console.WriteLine("Длина диапазона равна " + !d1);


            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Переменные заданы, число не попадает в промежуток");
            Console.ResetColor();

            //Compare(!d1);
            Diapason.Point(d1, 9.4);


            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Переменные заданы, промежуток пустой");
            Console.ResetColor();

            d1 = new Diapason(5, 5);
            Diapason.Point(d1, 5);
            d1.Show();
            ////Compare(!d1);


            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Переменные заданы, неверно задан промежуток");
            Console.ResetColor();

            d1 = new Diapason(7.3, 3.2);
            //Compare(!d1);



            Diapason d2 = new Diapason(-10.2, 29.3);
            //Compare(!d2);

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------------");
            Console.WriteLine("Унарные операции");
            Console.WriteLine("----------------");
            Console.ResetColor();

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Добавление единицы к координатам диапазона и вычисление длины");
            Console.ResetColor();

            d2.Show();
            Console.WriteLine("Длина диапазона равна " + !d2);
            Console.WriteLine("");
            d2++;
            d2.Show();
            Console.WriteLine("Длина диапазона равна " + !d2);


            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Количество созданных объектов: " + Diapason.GetCount());
            Console.ResetColor();

            Diapason d3 = new Diapason(10.2, 20.3);
            Diapason d4 = new Diapason(-1.23, 1.2);
            Diapason d5 = new Diapason(4.1, 21.66);

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------");
            Console.WriteLine("Операции приведения типа");
            Console.WriteLine("------------------------");
            Console.ResetColor();

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("int (явная) – результатом является целая часть координаты х");
            Console.ResetColor();

            Console.WriteLine("Координата Х = " + d2.x);
            Console.WriteLine("Приведение к целому значению = " + (int)d2);


            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("double (неявная) – результатом является координата y");
            Console.ResetColor();

            Console.WriteLine("Координата Y = " + d3.y);
            Console.WriteLine("Приведение к вещественному значению = " + (double)d3);


            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------");
            Console.WriteLine("Бинарные операции");
            Console.WriteLine("-----------------");
            Console.ResetColor();

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Увеличение координат на целое число d = 15");
            Console.ResetColor();

            d4.Show();
            Diapason d6 = d4 + 15;
            d6.Show();
            //Compare(!d4);
            //Compare(!d6);


            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Результат равен true, если целое число попадает \nв заданный диапазон и false – в противном случае");
            Console.ResetColor();

            d5.Show();
            //Compare(!d5);

            if (5 < d5)
            {
                Console.WriteLine($"Число 5 принадлежит диапазону [{d5.x};{d5.y}] ");
            }
            else
            {
                Console.WriteLine($"Число 5 не принадлежит диапазону [{d5.x};{d5.y}] ");
            }

            if (-3 < d5)
            {
                Console.WriteLine($"Число -3 принадлежит диапазону [{d5.x};{d5.y}] ");
            }
            else
            {
                Console.WriteLine($"Число -3 не принадлежит диапазону [{d5.x};{d5.y}] ");
            }


            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Создание массива объектов класса Diapason");
            Console.WriteLine("-----------------------------------------");
            Console.ResetColor();

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Создание конструктором без параметров");
            Console.ResetColor();

            DiapasonArray dArr = new DiapasonArray();
            dArr.Show();


            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Создание вручную");
            Console.ResetColor();

            DiapasonArray dArr1 = new DiapasonArray("10,5;12,3", "1,7;3,2");
            dArr1.Show();


            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Создание с помощью ДСЧ");
            Console.ResetColor();

            DiapasonArray dArr2 = new DiapasonArray(3);
            dArr2.Show();


            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Доступ к объектам массива");
            Console.ResetColor();

            Diapason d33 = dArr2[1];
            Console.WriteLine($"Объект массива под номером 2 : Диапазон [{d33.x};{d33.y}]");


            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Поиск наибольшего диапазона");
            Console.ResetColor();

            Compare(dArr2);

            Console.WriteLine("Наибольшая длина диапазона равна " + maxLength);
        }
    }
}
