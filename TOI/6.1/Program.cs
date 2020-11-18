using System;

namespace _6._1
{
    class Program
    {
        static int InsertInt()
        {
            int num;
            bool ok;

            do
            {
                ok = int.TryParse(Console.ReadLine(), out num);
                if (!ok)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Неверный ввод! Введите заново.");
                }
            } while (ok == false);
            return num;
        }

        static void PrintArray(int n, int[] m)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(m[i] + " ");
            }
            Console.WriteLine();
        }

        static void FillArrayHand(int n, ref int[] m)
        {
            int[] vs = new int[n];
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("a[{0}] = ", i + 1);
                    vs[i] = InsertInt();
                }
            }
            m = vs;
        }

        static void Sort(ref int t, ref int r, int num, int[] m)
        {
            for (int i = 0; i < 4; i++)
            {
                t = m[i];
                num = i;

                for (int j = i + 1; j < 5; j++)
                {
                    if (m[j] > t)
                    {
                        t = m[j];
                        num = j;
                    }
                }

                r = m[i];
                m[i] = t;
                m[num] = r;
            }
        }

        static void Main(string[] args)
        {
            int n = 5;
            int t = 0, r = 0, num = 0;
            int[] m = new int[n];

            Console.WriteLine("Введите элементы одномерного массива:");
            FillArrayHand(n, ref m);
            Console.WriteLine("");
            Console.WriteLine("Исходный массив:");
            PrintArray(n, m);
            Sort(ref t, ref r, num, m);
            Console.WriteLine("");
            Console.WriteLine("Отсортированный массив:");
            PrintArray(n, m);
        }
    }
}
