using System;

namespace _10LabTask
{
    class Program
    {
        static Random rnd = new Random();
        static bool ok = false;

        static public int InputInt()
        {
            int num;
            bool ok;

            do
            {
                ok = int.TryParse(Console.ReadLine(), out num);
                if (!ok)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный ввод! Введите заново.");
                    Console.ResetColor();
                }
            } while (ok == false);
            return num;
        }

        static public void PrintArray(Challenge[] arr, int size)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Элементы массива: ");
            Console.ResetColor();

            for (int i = 0; i < size; i++)
            {
                arr[i].Show();
            }
        }

        static public void PrintElem(Challenge[] arr, int size)
        {
            int num = 0;
            Console.Write("Введите номер элемента для просмотра: ");
            do
            {
                num = InputInt();

                if (num > size)
                {
                    Console.WriteLine("Неверно введен номер элемента! Повторите ввод!");
                }
            } while (num > size);

            Console.WriteLine("Элемент {0}: ", num);
            arr[num - 1].Show();
        }

        static void CreateObj(ref Challenge[] arr, out int size)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Создание массива");
            Console.ResetColor();
            Console.Write("Введите количество элементов в массиве: ");

            size = InputInt();
            arr = new Challenge[size];

            for (int i = 0; i < size; i++)
            {
                int randChoice = rnd.Next(1, 25);

                if (randChoice <= 10)
                {
                    Test t = new Test();
                    Challenge m = t;
                    m.Name = "тест";
                    arr[i] = m;
                }

                if (randChoice > 10 && randChoice <= 20)
                {
                    Exam e = new Exam();
                    Challenge m = e;
                    m.Name = "экзамен";
                    arr[i] = m;
                }

                if (randChoice > 20)
                {
                    FinalExam e = new FinalExam("Теоретические основы информатики", 100, "да", 1);
                    Challenge m = e;
                    m.Name = "экзамен";
                    arr[i] = m;
                }
            }

            ok = true;
        }

        static void MenuPrintMas()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("Печать массива");
            Console.ResetColor();
            Console.Write(@"1. Вывести массив.
2. Вывести элемент массива.
3. Назад.

Выберите действие: ");
        }

        static void Part1(ref Challenge[] arr, int size)
        {
            int reaction = 0;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Часть 1");
            Console.ResetColor();

            if (ok == true)
            {
                do
                {
                    MenuPrintMas();
                    reaction = InputInt();

                    switch (reaction)
                    {
                        case 1: PrintArray(arr, size); break;
                        case 2: PrintElem(arr, size); break;
                        case 3: break;
                    }

                } while (reaction != 3);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Массив не создан!");
                Console.ResetColor();
            }
        }

        static public void StudentList(ref int listSize, ref Students[] array)
        {
            listSize = rnd.Next(5, 12);
            array = new Students[listSize];

            for (int i = 0; i < listSize; i++)
            {
                Students s = new Students(Students.lastNames[rnd.Next(0, 9)], Students.names[rnd.Next(0, 7)]);
                array[i] = s;
            }

            foreach (Students s in array)
                s.Show();
        }

        static void MenuPart2()
        {
            Console.WriteLine();
            Console.WriteLine(@"Запросы:
1. Имена всех студентов указанного курса.
2. Количество студентов на указанном курсе.
3. Средний балл за сессию заданного студента.
4. Назад.
");
        }

        static void Part2(ref Students[] array)
        {
            int reaction = 0;
            int listSize = 0;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Часть 2");
            Console.ResetColor();

            if (ok == true)
            {
                do
                {
                    MenuPart2();
                    reaction = InputInt();

                    switch (reaction)
                    {
                        case 1: StudentList(ref listSize, ref array); break;
                        case 2:
                            {
                                Console.WriteLine("Количество студентов на данном курсе: " + listSize);
                                break;
                            }
                        case 3: break;
                        case 4: break;
                    }

                } while (reaction != 3);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Массив не создан!");
                Console.ResetColor();
            }
        }

        static void Menu()
        {
            Console.WriteLine();
            Console.Write(@"Выберите действие:
1. Создать массив.
2. Напечатать массив. (1 часть).
3. Работа с запросами. (2 часть).
4. Абстрактные классы и интерфейсы. (3 часть).
5. Выход.

Выберите действие: ");
        }

        static void Main(string[] args)
        {
            Challenge[] arr = null;
            Students[] array = null;
            int size = 0;
            int reaction = 0;

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("НАСЛЕДОВАНИЕ И ВИРТУАЛЬНЫЕ ФУНКЦИИ");
            Console.ResetColor();

            do
            {
                Menu();
                reaction = InputInt();

                switch (reaction)
                {
                    case 1:
                        {
                            CreateObj(ref arr, out size);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Массив создан!");
                            Console.ResetColor();
                            break;
                        }
                    case 2: { Part1(ref arr, size); break; }
                    case 3: { Part2(ref array); break; }
                    //case 4: { Part3(ref arr, size); break; }
                    case 5: break;
                }
            } while (reaction != 5);
        }
    }
}
