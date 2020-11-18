using System;

namespace _6._2
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

        static void Sort(int[] m)
        {
            int t;

            for (int i = 1; i < 5; i++)
            {
                t = m[i];
                int j = i;

                while (j > 0 && t > m[j - 1])
                {
                    m[j] = m[j - 1];
                    j--;
                }
                m[j] = t;
            }
        }

        static void Main(string[] args)
        {
            int n = 5;
            int[] m = new int[n];

            Console.WriteLine("Введите элементы одномерного массива:");
            FillArrayHand(n, ref m);
            Console.WriteLine("");
            Console.WriteLine("Исходный массив:");
            PrintArray(n, m);
            Sort(m);
            Console.WriteLine("");
            Console.WriteLine("Отсортированный массив:");
            PrintArray(n, m);
        }
    }
}
