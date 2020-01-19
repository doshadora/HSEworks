using System;

namespace _5LabTask
{
    class Program
    {
        static void MenuType()
        {
            Console.WriteLine("1. Работа с одномерными массивами.");
            Console.WriteLine("2. Работа с двумерными массивами.");
            Console.WriteLine("3. Работа с рваными массивами.");
            Console.WriteLine("4. Выход");
            Console.WriteLine(" ");
        }
        static void MenuAction()
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Создать массив.");
            Console.WriteLine("2. Действие с массивом.");
            Console.WriteLine("3. Назад.");
            Console.WriteLine(" ");
        }
        static void MenuHowToType()
        {
            Console.WriteLine("Выберите способ заполнения:");
            Console.WriteLine("1. Заполнение вручную.");
            Console.WriteLine("2. Заполнение при помощи ДСЧ.");
            Console.WriteLine("3. Назад.");
            Console.WriteLine(" ");
        }
        static void NumberOfStrings(ref int strings)
        {
            do
            {
                Console.Write("Введите количество строк массива: ");
                strings = InsertInt();
                if (strings <= 0)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Количество строк должно быть больше нуля.");
                }
            } while (strings <= 0);
        }
        static void NumberOfColumns(ref int columns)
        {
            do
            {
                Console.Write("Введите количество столбцов массива: ");
                columns = InsertInt();
                if (columns <= 0)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Количество столбцов должно быть больше нуля.");
                }
                Console.WriteLine(" ");
            } while (columns <= 0);
        }
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

        //-------------------- функции для одномерного массива ---------------------------

        static void PrintArray(int n, int[] mas)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
        }
        static void FillArrayRnd(int n, ref int[] mas)
        {
            int[] vs = new int[n];
            Random rnd = new Random { };
            for (int i = 0; i < n; i++)
            {
                vs[i] = rnd.Next(1, 100);
            }
            mas = vs;
        }
        static void FillArrayHand(int n, ref int[] mas)
        {
            int[] vs = new int[n];
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("a[{0}] = ", i + 1);
                    vs[i] = InsertInt();
                }
            }
            mas = vs;
        }
        static void ChooseArrayFilling(int n, ref int[] mas)
        {
            int method;
            do
            {
                Console.WriteLine(" ");
                Console.WriteLine("Формирование одномерного массива.");
                Console.WriteLine(" ");
                MenuHowToType();
                method = InsertInt();
                switch (method)
                {
                    case 1:
                        {
                            FillArrayHand(n, ref mas);
                            PrintArray(n, mas);
                            break;
                        }
                    case 2:
                        {
                            FillArrayRnd(n, ref mas);
                            PrintArray(n, mas);
                            break;
                        }
                    case 3: break;
                    default:
                        Console.WriteLine("Нет такого пункта меню");
                        Console.WriteLine(" ");
                        break;
                }
            } while (method != 3);
        }
        static int[] DeleteElem(ref int[] mas, int n)
        {
            int index, i = 0;
            do
            {
                do
                {
                    Console.Write("Введите номер элемента для удаления: ");
                    index = InsertInt();
                    if (index <= 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Ошибка! Номер должен быть больше нуля.");
                        Console.WriteLine(" ");
                    }
                } while (index <= 0);
                if (index > n)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Элемент с выбранным номером невозможно удалить");
                    Console.WriteLine(" ");
                }
                else
                {
                    int j = 0;
                    int[] temp = new int[n - 1];
                    for (; i < n; i++)
                    {
                        if (index - 1 != i)
                        {
                            temp[j] = mas[i];
                            j++;
                        }
                    }
                    mas = temp;
                }
                if (mas == null || mas.Length == 0)
                {
                    Console.WriteLine("Массив пустой");
                }
            } while (index > n);
            return mas;
        }

        //-------------------- функции для двумерного массива ---------------------------

        static void PrintArray(int[,] matr, int strings, int columns)
        {
            int i, j;
            for (i = 0; i < strings; i++)
            {
                for (j = 0; j < columns; j++)
                {
                    Console.Write(matr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void FillArrayRnd(ref int[,] matr, int strings, int columns)
        {
            Random rnd = new Random { };
            int[,] vs = new int[strings, columns];
            int i, j;
            for (i = 0; i < strings; i++)
            {
                for (j = 0; j < columns; j++)
                {
                    vs[i, j] = rnd.Next(1, 10);
                }
            }
            matr = vs;
        }
        static void FillArrayHand(ref int[,] matr, int strings, int columns)
        {
            int[,] vs = new int[strings, columns];
            int i, j;
            for (i = 0; i < strings; i++)
            {
                for (j = 0; j < columns; j++)
                {
                    Console.Write("a[{0},{1}] = ", i + 1, j + 1);
                    vs[i, j] = InsertInt();
                }
                Console.WriteLine();
            }
            Console.WriteLine(" ");
            matr = vs;
        }
        static void ChooseArrayFilling(ref int[,] matr, int strings, int columns)
        {
            int method;
            do
            {
                MenuHowToType();
                method = InsertInt();
                switch (method)
                {
                    case 1:
                        {
                            FillArrayHand(ref matr, strings, columns);
                            PrintArray(matr, strings, columns);
                            Console.WriteLine(" ");
                            break;
                        }
                    case 2:
                        {
                            FillArrayRnd(ref matr, strings, columns);
                            PrintArray(matr, strings, columns);
                            Console.WriteLine(" ");
                            break;
                        }
                    case 3: break;
                    default:
                        Console.WriteLine("Нет такого пункта меню");
                        Console.WriteLine(" ");
                        break;
                }
            } while (method != 3);
        }
        static void AddString(ref int[,] matr, int strings, int columns)
        {
            if (matr == null || matr.Length == 0)
            {
                Console.WriteLine("Массив пустой");
                Console.WriteLine("");
                return;
            }
            int[,] temp = new int[strings + 1, columns];

            Random rnd = new Random { };

            int t;
            for (t = 0; t < 1; t++)
            {
                for (int j = 0; j < columns; j++)
                {
                    temp[t, j] = rnd.Next(1, 10);
                }
            }
            for (int i = 0; i < strings; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    temp[t, j] = matr[i, j];
                }
                t++;
            }
            matr = temp;
        }

        //-------------------- функции для рваного массива ---------------------------

        static void PrintArray(int[][] jagMas)
        {
            if (jagMas == null)
            {
                Console.WriteLine(" ");
            }
            else
            {
                for (int i = 0; i < jagMas.Length; i++)
                {
                    for (int j = 0; j < jagMas[i].Length; j++)
                    {
                        Console.Write(jagMas[i][j] + "  ");
                    }
                    Console.WriteLine();
                }
            }
        }
        static void FillArrayRnd(ref int[][] jagMas, ref int strings, ref int columns)
        {
            Random rnd = new Random { };

            NumberOfStrings(ref strings);
            int[][] vs = new int[strings][];
            int i, j;
            for (i = 0; i < strings; i++)
            {
                NumberOfColumns(ref columns);
                vs[i] = new int[columns];
                for (j = 0; j < columns; j++)
                {
                    vs[i][j] = rnd.Next(0, 10);
                }
            }
            jagMas = vs;
        }
        static void FillArrayHand(ref int[][] jagMas, ref int strings, ref int columns)
        {
            NumberOfStrings(ref strings);

            int[][] vs = new int[strings][];

            int i, j;
            for (i = 0; i < strings; i++)
            {
                NumberOfColumns(ref columns);
                vs[i] = new int[columns];
                for (j = 0; j < columns; j++)
                {
                    Console.Write("a[{0},{1}] = ", i + 1, j + 1);
                    vs[i][j] = InsertInt();
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");

            jagMas = vs;
        }
        static void ChooseArrayFilling(ref int[][] jagMas, ref int strings, ref int columns)
        {
            int method;
            do
            {
                MenuHowToType();
                method = InsertInt();
                switch (method)
                {
                    case 1:
                        {
                            FillArrayHand(ref jagMas, ref strings, ref columns);
                            PrintArray(jagMas);
                            break;
                        }
                    case 2:
                        {
                            FillArrayRnd(ref jagMas, ref strings, ref columns);
                            PrintArray(jagMas);
                            break;
                        }
                    case 3: break;
                    default:
                        Console.WriteLine("Нет такого пункта меню");
                        Console.WriteLine(" ");
                        break;
                }
            } while (method != 3);
        }
        static void DeleteStrings(ref int[][] jagMas, ref int strings)
        {
            int k, n;
            do
            {
                do
                {
                    Console.WriteLine(" ");
                    Console.Write("Введите количество строк для удаления: ");
                    k = InsertInt();
                    if (k > strings)
                    {
                        Console.WriteLine("Слишком много выбранных строк! Повторите ввод!!!");
                    }
                    if (k <= 0)
                    {
                        Console.WriteLine("Количество строк для удаления должно быть больше 0!");
                    }
                } while (k > strings || k <= 0);

                do
                {
                    Console.WriteLine(" ");
                    Console.Write("Введите номер строки, с которой удалятся выбранные строки: ");
                    n = InsertInt();
                    if (n <= 0)
                    {
                        Console.WriteLine("Номер строки должен быть больше 0.");
                    }
                } while (n <= 0);

                if (n + k - 1 > strings)
                {
                    Console.WriteLine("Ошибка! Повторите ввод.");
                }
            } while (n + k - 1 > strings);

            if (k == strings && n == 1)
            {
                strings = 0;
                jagMas = null;
                Console.WriteLine(" ");
                Console.WriteLine("Массив стал пустым.");
                return;
            }

            int p = 0, j;
            int[][] temp = new int[strings - k][];
            for (int i = 0; i < n - 1; i++)
            {
                temp[p] = new int[jagMas[i].Length];
                for (j = 0; j < jagMas[i].Length; j++)
                {
                    temp[p][j] = jagMas[i][j];
                }
                p++;
            }

            for (int i = k + n - 1; i < strings; i++)
            {
                temp[p] = new int[jagMas[i].Length];
                for (j = 0; j < jagMas[i].Length; j++)
                {
                    temp[p][j] = jagMas[i][j];
                }
                p++;
            }
            strings -= k;
            jagMas = temp;
        }
        static void Main(string[] args)
        {
            int option;
            do
            {
                MenuType();
                option = InsertInt();

                if (option == 4)
                    break;

                switch (option) // выбор вида массива
                {
                    case 1: // одномерный массив
                        {

                            int n = 0;
                            int[] mas = new int[n];
                            int action = 0;
                            while (action != 3)
                            {
                                MenuAction();
                                action = InsertInt();

                                switch (action)
                                {
                                    case 1: // создание массива
                                        {
                                            do
                                            {
                                                Console.Write("Введите количество элементов массива: ");
                                                n = InsertInt();
                                                if (n <= 0)
                                                {
                                                    Console.WriteLine(" ");
                                                    Console.WriteLine("Количество элементов должно быть больше нуля.");
                                                    Console.WriteLine(" ");
                                                }
                                            } while (n <= 0);

                                            ChooseArrayFilling(n, ref mas);
                                            break;
                                        }
                                    case 2: // удаление элемента
                                        {
                                            if (mas == null || mas.Length == 0)
                                            {
                                                Console.WriteLine("Массив пустой");
                                                Console.WriteLine("");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Удаление элемента с заданным номером.");
                                                Console.WriteLine(" ");
                                                PrintArray(n, mas);
                                                mas = DeleteElem(ref mas, n);
                                                n -= 1;
                                                Console.WriteLine(" ");
                                                PrintArray(n, mas);
                                                Console.WriteLine(" ");
                                                Console.WriteLine("Удаление элемента с заданным номером выполнено.");
                                                Console.WriteLine(" ");
                                            }
                                            break;
                                        }
                                    case 3: break;
                                    default:
                                        Console.WriteLine("Нет такого пункта меню");
                                        Console.WriteLine(" ");
                                        break;
                                }
                            }
                            break;
                        }
                    case 2: // двумерный массив
                        {
                            int strings = 0, columns = 0;
                            int[,] matr = new int[strings, columns];
                            int action = 0;
                            while (action != 3)
                            {
                                MenuAction();
                                action = InsertInt();

                                switch (action)
                                {
                                    case 1: // cоздание массива
                                        {
                                            NumberOfStrings(ref strings);
                                            NumberOfColumns(ref columns);
                                            ChooseArrayFilling(ref matr, strings, columns);
                                            break;
                                        }
                                    case 2: // добавление строки в начало массива
                                        {
                                            if (matr == null || matr.Length == 0)
                                            {
                                                Console.WriteLine("Массив пустой");
                                                Console.WriteLine("");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Добавление новой строки в начало массива");
                                                Console.WriteLine(" ");
                                                AddString(ref matr, strings, columns);
                                                strings += 1;
                                                PrintArray(matr, strings, columns);
                                                Console.WriteLine(" ");
                                                Console.WriteLine("Добавление новой строки в начало массива выполнено.");
                                                Console.WriteLine(" ");
                                            }
                                            break;
                                        }
                                    case 3: break;
                                    default:
                                        Console.WriteLine("Нет такого пункта меню");
                                        Console.WriteLine(" ");
                                        break;
                                }
                            }
                            break;
                        }
                    case 3: // рваный массив
                        {
                            int strings = 0, columns = 0;
                            int[][] jagMas = new int[strings][];
                            int action = 0;
                            while (action != 3)
                            {
                                MenuAction();
                                action = InsertInt();

                                switch (action)
                                {
                                    case 1: // создание массива
                                        {
                                            ChooseArrayFilling(ref jagMas, ref strings, ref columns);
                                            Console.WriteLine(" ");
                                            break;
                                        }
                                    case 2: // удаление К строк, начиная с номера N
                                        {
                                            if (jagMas == null || jagMas.Length == 0)
                                            {
                                                Console.WriteLine("Массив пустой");
                                                Console.WriteLine("");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Удаление К строк, начиная с номера N");
                                                Console.WriteLine(" ");
                                                PrintArray(jagMas);
                                                DeleteStrings(ref jagMas, ref strings);
                                                PrintArray(jagMas);
                                                Console.WriteLine(" ");
                                                Console.WriteLine("Действие выполнено.");
                                                Console.WriteLine(" ");
                                            }
                                            break;
                                        }
                                    case 3: break;
                                    default:
                                        Console.WriteLine("Нет такого пункта меню");
                                        Console.WriteLine(" ");
                                        break;
                                }
                            }
                            break;
                        }
                    case 4: break;
                    default:
                        Console.WriteLine("Нет такого пункта меню");
                        Console.WriteLine(" ");
                        break;
                }
            } while (option != 4);
        }
    }
}