using System;

namespace _13LabTask
{
    class Program
    {
        static public void ShowMyCollection(MyNewCollection<Challenge> c)
        {
            Console.WriteLine();
            foreach (var x in c)
            {
                Console.WriteLine($"{x}");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            MyNewCollection<Challenge> mc1 = new MyNewCollection<Challenge>("Coll1");
            MyNewCollection<Challenge> mc2 = new MyNewCollection<Challenge>("Coll2");

            Journal<Challenge> j1 = new Journal<Challenge>();
            Journal<Challenge> j2 = new Journal<Challenge>();

            //подписка на события
            mc1.CollectionCountChanged += new CollectionHandler(j1.OnCollectionCountChanged);
            mc1.CollectionReferenceChanged += new CollectionHandler(j1.OnCollectionReferenceChanged);
            mc1.CollectionReferenceChanged += new CollectionHandler(j2.OnCollectionReferenceChanged);
            mc2.CollectionReferenceChanged += new CollectionHandler(j2.OnCollectionReferenceChanged);

            string ch = " ";

            while (ch != "0")
            {

                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Создание первой коллекции");
                Console.WriteLine("2. Создание второй коллекции");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("3. Добавление элемента в первую коллекцию");
                Console.WriteLine("4. Добавление случайного элемента в первую колекцию");
                Console.WriteLine("5. Добавление элемента во вторую коллекцию");
                Console.WriteLine("6. Добавление случайного элемента во вторую колекцию");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("7. Удаление элемента по индексу из первой коллекции");
                Console.WriteLine("8. Удаление элемента по индексу из второй коллекции");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("9. Изменение элемента по индексу в первой коллекции");
                Console.WriteLine("10. Изменения элемента по индексу во второй коллекции");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("11. Вывод первого журнала");
                Console.WriteLine("12. Вывод второго журнала");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("0. Выход из меню");

                ch = Console.ReadLine();

                if (ch == "0") break;
                switch (ch)
                {
                    case "1":
                        {
                            Console.WriteLine("Создание первой коллекции");

                            mc1.AddDefault();

                            for (int i = 1; i < 5; i++)
                            {
                                Challenge chal = new Challenge();
                                mc1.Add(chal);
                            }

                            Console.WriteLine("Коллекция: ");

                            ShowMyCollection(mc1);

                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Коллекция Coll1 создана!");
                            Console.ForegroundColor = defaultColor;
                        }
                        break;
                    case "2":
                        {
                            Console.WriteLine("Создание второй коллекции");

                            for (int i = 0; i < 4; i++)
                            {
                                Challenge chal = new Challenge();
                                mc2.Add(chal);
                            }

                            mc2.AddDefault();

                            Console.WriteLine("Коллекция: ");

                            ShowMyCollection(mc2);

                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Коллекция Coll2 создана!");
                            Console.ForegroundColor = defaultColor;
                        }
                        break;
                    case "3":
                        {
                            if (mc1.Count != 0)
                            {
                                Console.WriteLine("\nДобавление элемента в первую колекцию");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Добавление элемента: ");
                                Console.ForegroundColor = ConsoleColor.Green;

                                Challenge e = new Challenge();

                                mc1.Add(e);

                                Console.ForegroundColor = defaultColor;

                                ShowMyCollection(mc1);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Коллекция Coll1 не создана / коллекция не существует");
                                Console.ForegroundColor = defaultColor;
                                break;
                            }
                        }
                        break;
                    case "4":
                        {
                            if (mc1.Count != 0)
                            {
                                Console.WriteLine("\nДобавление случайного элемента в первую колекцию");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Добавление элемента: ");
                                Console.ForegroundColor = ConsoleColor.Green;

                                mc1.AddDefault();

                                Console.ForegroundColor = defaultColor;

                                ShowMyCollection(mc1);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Коллекция Coll1 не создана / коллекция не существует");
                                Console.ForegroundColor = defaultColor;
                                break;
                            }
                        }
                        break;
                    case "5":
                        {
                            if (mc2.Count != 0)
                            {
                                Console.WriteLine("\nДобавление элемента во вторую коллекцию");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Добавление элемента: ");
                                Console.ForegroundColor = ConsoleColor.Green;

                                Challenge e = new Challenge();

                                mc2.Add(e);

                                Console.ForegroundColor = defaultColor;

                                ShowMyCollection(mc2);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Коллекция Coll2 не создана / коллекция не существует");
                                Console.ForegroundColor = defaultColor;
                                break;
                            }
                        }
                        break;
                    case "6":
                        {
                            if (mc2.Count != 0)
                            {
                                Console.WriteLine("\nДобавление случайного элемента во вторую коллекцию");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Добавление элемента: ");
                                Console.ForegroundColor = ConsoleColor.Green;

                                mc2.AddDefault();

                                Console.ForegroundColor = defaultColor;

                                ShowMyCollection(mc2);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Коллекция Coll2 не создана / коллекция не существует");
                                Console.ForegroundColor = defaultColor;
                                break;
                            }
                        }
                        break;
                    case "7":
                        {
                            if (mc1.Count != 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Удаление элемента из первой коллекции : ");
                                Console.ForegroundColor = ConsoleColor.Cyan;

                                mc1.Remove(0);

                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("из списка приведет к такому состоянию: ");
                                Console.ForegroundColor = defaultColor;

                                ShowMyCollection(mc1);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Коллекция Coll1 не создана / коллекция не существует");
                                Console.ForegroundColor = defaultColor;
                                break;
                            }
                        }
                        break;
                    case "8":
                        {
                            if (mc2.Count != 0)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("Удаление элемента из второй коллекции : ");

                                mc2.Remove(0);

                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("из списка приведет к такому состоянию: ");
                                Console.ForegroundColor = defaultColor;

                                ShowMyCollection(mc2);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Коллекция Coll2 не создана / коллекция не существует");
                                Console.ForegroundColor = defaultColor;
                                break;
                            }
                        }
                        break;
                    case "9":
                        {
                            if (mc1.Count != 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Изменение элемента по индексу 1 в первой коллекции : ");
                                Console.WriteLine($"Изменение {mc1[0]}");

                                Challenge challenge1 = mc1[0];
                                challenge1.Name = "No Name";
                                challenge1.Questions = 0;
                                mc1[0] = challenge1;

                                Console.WriteLine($"Измененный элемент: {mc1[0]}");
                                Console.ForegroundColor = defaultColor;

                                ShowMyCollection(mc1);

                                Console.WriteLine();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Коллекция Coll1 не создана / коллекция не существует");
                                Console.ForegroundColor = defaultColor;
                                break;
                            }
                        }
                        break;
                    case "10":
                        {
                            if (mc2.Count != 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Изменение элемента по индексу 1 в первой коллекции : ");
                                Console.WriteLine($"Изменение {mc2[0]}");

                                Challenge challenge2 = mc2[0];
                                challenge2.Name = "No Name";
                                challenge2.Questions = 0;
                                mc2[0] = challenge2;

                                Console.WriteLine($"Измененный элемент: {mc2[0]}");
                                Console.ForegroundColor = defaultColor;

                                ShowMyCollection(mc2);

                                Console.WriteLine();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Коллекция Coll2 не создана / коллекция не существует");
                                Console.ForegroundColor = defaultColor;
                                break;
                            }
                        }
                        break;
                    case "11":
                        {

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Журнал 1: ");
                            Console.ForegroundColor = defaultColor;

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(j1.ToString());
                            Console.ForegroundColor = defaultColor;
                        }
                        break;
                    case "12":
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Журнал 2: ");
                            Console.ForegroundColor = defaultColor;

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(j2.ToString());
                            Console.ForegroundColor = defaultColor;
                        }
                        break;
                }
            }
        }
    }
}
