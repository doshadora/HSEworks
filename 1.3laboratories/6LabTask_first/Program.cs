using System;

namespace _6LabTask_first
{
    class Program
    {
        static void MenuAction()
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Создать массив.");
            Console.WriteLine("2. Удалить из массива столбец.");
            Console.WriteLine("3. Выход.");
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
                Console.WriteLine(" ");
                if (strings <= 0)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Количество строк должно быть больше нуля.");
                    Console.WriteLine(" ");
                }
            } while (strings <= 0);
        }
        static void NumberOfColumns(ref int columns)
        {
            do
            {
                Console.Write("Введите количество столбцов массива: ");
                columns = InsertInt();
                Console.WriteLine(" ");
                if (columns <= 0)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Количество столбцов должно быть больше нуля.");
                    Console.WriteLine(" ");
                }
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
                    Console.WriteLine(" ");
                }
            } while (ok == false);
            return num;
        }
        static void PrintArray(int[,] matr, int strings, int columns)
        {
            if (columns == 0)
            {
                Console.WriteLine("Массив стал пустым");
            }
            else
            {
                int i, j;
                for (i = 0; i < strings; i++)
                {
                    for (j = 0; j < columns; j++)
                    {
                        Console.Write($"{matr[i, j],4}");
                    }
                    Console.WriteLine();
                }
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
                    vs[i, j] = rnd.Next(-100, 100);
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
        static void FindMinimalElem(int[,] matr, int strings, int columns, ref int minElem, ref int theColumn)
        {
            for (int j = 0; j < columns; j++)
            {
                for (int i = 0; i < strings; i++)
                {
                    if (matr[i, j] < minElem)
                    {
                        minElem = matr[i, j];
                        theColumn = j;
                    }
                }
            }
            Console.WriteLine("Минимальный элемент массива = {0} \nСтолбец для удаления = {1}", minElem, theColumn + 1);
            Console.WriteLine(" ");
        }
        static void DeleteColumn(ref int[,] matr, int strings, ref int columns, int theColumn)
        {
            if (theColumn == 0 && columns == 1)
            {
                columns = 0;
                matr = null;
                Console.WriteLine("Массив стал пустым.");
                Console.WriteLine(" ");
                return;
            }

            int t;
            int[,] vs = new int[strings, columns - 1];

            if (theColumn +1 == columns)
            {
                columns -= 1;
                for (int i = 0; i < strings; i++)
                {
                    for (int j = t = 0; j < columns; j++, t++)
                    {
                        vs[i, t] = matr[i, j];
                    }
                }
                matr = vs;
                Console.WriteLine("Измененный массив:");
                PrintArray(matr, strings, columns);
                Console.WriteLine(" ");
                return;
            }

            for (int i = 0; i < strings; i++)
            {
                for (int j = t = 0; j < columns; j++, t++)
                {
                    if (j != theColumn)
                    {
                        vs[i, t] = matr[i, j];
                    }
                    else
                    {

                        j++;
                    }
                    vs[i, t] = matr[i, j];
                }
            }
            columns -= 1;
            matr = vs;
            Console.WriteLine("Измененный массив:");
            PrintArray(matr, strings, columns);
            Console.WriteLine(" ");
        }
        static void Main(string[] args)
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
                    case 2: // удаление столбца
                        {
                            if (matr == null || matr.Length == 0)
                            {
                                Console.WriteLine("Массив пустой");
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine("Исходный массив:");
                                PrintArray(matr, strings, columns);
                                Console.WriteLine(" ");
                                int minElem = matr[0, 0], theColumn = 0;
                                FindMinimalElem(matr, strings, columns, ref minElem, ref theColumn);
                                DeleteColumn(ref matr, strings, ref columns, theColumn);
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
        }
    }
}
