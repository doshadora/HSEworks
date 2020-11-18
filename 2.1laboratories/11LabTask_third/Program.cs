using System;

namespace _11LabTask_third
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCollections ts = new TestCollections(1000);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Тестирование на время поиска: ");
            Console.ResetColor();

            ts.FindFirst();
            Console.WriteLine();
            ts.FindMiddle();
            Console.WriteLine();
            ts.FindLast();
            Console.WriteLine();
            ts.NotFound();
            Console.WriteLine();

            Test test = new Test("Геометрия", 30, 100);
            Challenge chal = test.GetBase();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Add Геометрия");
            Console.ResetColor();

            ts.AddQueue(test);
            Console.WriteLine();
            ts.AddDictionary(chal, test);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Delete");
            Console.ResetColor();

            ts.DequeueQueue();
            Console.WriteLine();
            ts.DequeueDictionary(chal, test);
        }
    }
}
