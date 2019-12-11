using System;

namespace _4LabTask
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
                    Console.WriteLine("Неверный ввод! Введите заново.");
                }
            } while (ok == false);
            return num;
        }
        static void FillArrayRnd(int[] a)
        {
            Random rnd = new Random { };
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(-100, 100);
            }
        }
        static void FillArrayHand(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = InsertInt();
                if (a == null)
                {
                    Console.WriteLine("Массив пустой");
                }
            }
        }
        static void PrintArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
        static int[] DeleteElem(int[] a)
        {
            int i = 0, j = 0, k = 0, size = a.Length;
            for (; i < size; i++)
            {
                if (a[i] % 2 != 0)
                {
                    k++;
                }
            }
            int[] b = new int[k];
            for (i = 0; i < size; i++)
            {
                if (a[i] % 2 != 0)
                {
                    b[j] = a[i];
                    j++;
                }
            }
            a = b;
            return a;
        }
        static int[] AddElem(int[] a, int k)
        {
            Random rnd = new Random();
            int[] b = new int[a.Length + k];

            for (int i = 0; i < k; i++)
            {
                b[i] = rnd.Next(-100, 100);

            }
            for (int i = k, j = 0; i < b.Length; i++, j++)
            {
                b[i] = a[j];
            }
            return b;
        }
        static void TransferElem(int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 != 0)
                {
                    int temp = a[i];
                    for (int j = i; j < a.Length - 1; j++)
                    {
                        a[j] = a[j + 1];
                    }
                    a[a.Length - 1] = temp;
                    n--;
                    i--;
                }
            }
        }
        static void Sort(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int position = i;
                int temp = a[i];
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] < temp)
                    {
                        position = j;
                        temp = a[j];
                    }
                }
                a[position] = a[i];
                a[i] = temp;
            }
        }
        static void FirstCountElem(int[] a)
        {
            int index = -1;
            int compare = 0;
            for (int i = 0; i < a.Length; i++)
            {
                compare++;

                if (a[i] % 2 == 0)
                {
                    index = i;
                    break;
                }
            }
            if (index != -1)
            {
                Console.WriteLine(a[index]);
                Console.WriteLine("Количество сравнений = " + compare);
            }
            else
            {
                Console.WriteLine("Нет чётных чисел");
            }
        }
        static int BinarSearch(int[] a)
        {
            {
                int left = 0, right = a.Length - 1, middle, count = 0;
                Console.Write("Введите число для поиска: ");
                int numberToFind = Convert.ToInt32(Console.ReadLine());

                do
                {
                    middle = (left + right) / 2;
                    if (a[middle] < numberToFind) left = middle + 1;
                    else right = middle;
                    count++;
                } while (left != right);

                Console.WriteLine("Поиск элемента выполнен");
                if (numberToFind == a[left])
                    Console.WriteLine("Элемент {0} находится на позиции {1}, число сравнений: {2},\nмассив отсортирован, выполнен бинарный поиск", numberToFind, left+1, count);
                else Console.WriteLine("Элемент {0} не найден, количество сравнений: {1}, \nмассив отсортирован, выполнен бинарный поиск", numberToFind, count);

                Console.WriteLine("Поиск завершен.");
                return numberToFind;
            }
        }
        static void Menu()
        {
            Console.WriteLine("0. Выход");
            Console.WriteLine("1. Удаление всех чётных элементов");
            Console.WriteLine("2. Добавление элементов");
            Console.WriteLine("3. Перестановка элементов");
            Console.WriteLine("4. Поиск в неотсортированном массиве");
            Console.WriteLine("5. Сортировка");
            Console.WriteLine("6. Бинарный поиск");
            Console.WriteLine(" ");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива: ");
            int n;

            do
            {
                n = InsertInt();
                if (n < 0)
                    Console.WriteLine("Количество элементов должно быть больше нуля.");
            } while (n < 0);

            int[] a = new int[n];

            Console.WriteLine("1. Заполнение вручную");
            Console.WriteLine("2. Заполнение рандомно");
            Console.WriteLine(" ");

            int option;

            do
            {
                option = InsertInt();
                if (option == 1)
                    FillArrayHand(a);
                else
                {
                    if (option == 2)
                    {
                        FillArrayRnd(a);
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Пoвторите ввод.");
                    }
                }
            } while (option != 1 && option != 2);
            
            PrintArray(a);

            do
            {
                Menu();
                option = InsertInt();

                if (option == 0)
                    break;

                switch (option)
                {
                    case 1:
                        {
                            if (a.Length <= 0)
                            {
                                Console.WriteLine("Массив пустой");
                                break;
                            }
                            else
                            {
                                a = DeleteElem(a);
                                if (a.Length <= 0)
                                {
                                    Console.WriteLine("Массив пустой");
                                    break;
                                }
                                else
                                {
                                    PrintArray(a);
                                    break;
                                }
                            }
                        }
                    case 2:
                        {
                            Console.Write("k = ");
                            int k = InsertInt();

                            a = AddElem(a, k);
                            PrintArray(a);
                            break;
                        }
                    case 3:
                        {
                            if (a.Length <= 0)
                            {
                                Console.WriteLine("Массив пустой");
                                break;
                            }
                            else
                            {
                                TransferElem(a);
                                PrintArray(a);
                                break;
                            }

                        }
                    case 4:
                        {
                            if (a.Length <= 0)
                            {
                                Console.WriteLine("Массив пустой");
                                break;
                            }
                            else
                            {
                                FirstCountElem(a);
                                break;
                            }
                        }
                    case 5:
                        {
                            if (a.Length <= 0)
                            {
                                Console.WriteLine("Массив пустой");
                                break;
                            }
                            else
                            {
                                Sort(a);
                                PrintArray(a);
                            }
                            break;
                        }
                    case 6:
                        {
                            Sort(a);
                            Console.WriteLine("Ваш отсортированный массив:");
                            PrintArray(a);
                            BinarSearch(a);
                            break;
                        }
                }
            } while (option < 7);
        }
    }
}


