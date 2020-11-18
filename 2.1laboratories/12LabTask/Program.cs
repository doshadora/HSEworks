using System;

namespace _12LabTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Test test = new Test();
            int size = 8;

            MyCollection<Test> q = new MyCollection<Test>(size);

            for (int i = 0; i < size; i++)
            {
                Test test1 = test.CreateTestRandom(rnd);
                q.Add(test1);
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Коллекция создана: ");
            Console.ResetColor();

            foreach (Challenge chal in q)
            {
                Console.WriteLine(chal.ToString());
            }

            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Добавление элемента: ");
            Console.ResetColor();

            Test test2 = test.CreateTestRandom(rnd);
            q.Add(test2);

            foreach(Challenge chal in q)
            {
                if ((chal as Test).Equals(test))
                    Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine(chal.ToString());
            }

            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Удаление элемента: ");
            Console.ResetColor();

            q.Remove();

            foreach (Challenge chal in q)
            {
                Console.WriteLine(chal.ToString());
            }

            Console.ReadLine();

            int index = 2;
            int index1 = 3;
            int index2 = 6;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Обращение к элементу по индексу: ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(q[index]);
            Console.WriteLine(q[index1]);
            Console.WriteLine(q[index2]);
            Console.ResetColor();

            Console.ReadLine();
        }
    }
}
