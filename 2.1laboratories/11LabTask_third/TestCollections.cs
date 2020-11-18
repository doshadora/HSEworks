using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _11LabTask_third
{
    class TestCollections
    {
        public Queue<Test> c1 = new Queue<Test>();
        public Queue<string> c2 = new Queue<string>();
        public Dictionary<Challenge, Test> c3 = new Dictionary<Challenge, Test>();
        public Dictionary<string, Test> c4 = new Dictionary<string, Test>();

        public Test firstObject, middleObject, lastObject, notFound;

        void InitCollections(int size)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < size; i++)
            {
                try
                {
                    Test test = new Test();
                    Challenge chal = test.GetBase();

                    c1.Enqueue(test);
                    c2.Enqueue(test.ToString());
                    c3.Add(chal, test);
                    c4.Add(chal.ToString(), test);

                    if (i == 0) firstObject = (Test)test.Clone();
                    if (i == size / 2) middleObject = (Test)test.Clone();
                    if (i == size - 1) lastObject = (Test)test.Clone();
                }
                catch (Exception)
                {
                    i--;
                }

                notFound = new Test("notfound", 0, 0);
            }
        }

        void PrintQueueOfChallenge(Queue<Test> collection)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Печать коллекции Queue<Challenge>: ");
            Console.ResetColor();

            foreach (Test test in collection)
                Console.WriteLine(test);

            Console.WriteLine();
        }

        void PrintQueueOfString(Queue<string> collection)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Печать коллекции Queue<string>: ");
            Console.ResetColor();

            foreach (string test in collection)
                Console.WriteLine(test);

            Console.WriteLine();
        }

        void PrintDictionaryOfChallenge(Dictionary<Challenge, Test> dict)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Печать коллекции Dictionary<Challenge, Test>: ");
            Console.ResetColor();

            ICollection<Challenge> keys = dict.Keys;

            foreach (Challenge chal in keys)
                Console.WriteLine($"{chal.ToString()} | {dict[chal].ToString()}");

            Console.WriteLine();
        }

        void PrintDictionaryOfString(Dictionary<string, Test> dict)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Печать коллекции Dictionary<string, Test>: ");
            Console.ResetColor();

            ICollection<string> keys = dict.Keys;

            foreach (string chal in keys)
                Console.WriteLine($"{chal.ToString()} | {dict[chal].ToString()}");

            Console.WriteLine();
        }

        public TestCollections(int size)
        {
            InitCollections(size);

            PrintQueueOfChallenge(c1);
            PrintQueueOfString(c2);
            PrintDictionaryOfChallenge(c3);
            PrintDictionaryOfString(c4);
        }

        public void FindFirst()
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();
            bool ok = c1.Contains(firstObject);
            sw.Stop();

            if (ok) Console.WriteLine($"В коллекции Queue<Test> первый элемент найден за {sw.ElapsedTicks}");
            else Console.WriteLine($"В коллекции Queue<Test> первый элемент не найден");

            sw.Restart();
            ok = c2.Contains(firstObject.ToString());
            sw.Stop();

            if (ok) Console.WriteLine($"В коллекции Queue<string> первый элемент найден за {sw.ElapsedTicks}");
            else Console.WriteLine($"В коллекции Queue<string> первый элемент не найден");

            sw.Restart();
            ok = c3.ContainsKey(firstObject);
            sw.Stop();

            if (ok) Console.WriteLine($"В коллекции Dictionary<Challenge, Test> первый элемент найден за {sw.ElapsedTicks}");
            else Console.WriteLine($"В коллекции Dictionary<Challenge, Test> первый элемент не найден");

            sw.Restart();
            ok = c4.ContainsValue(firstObject);
            sw.Stop();

            if (ok) Console.WriteLine($"В коллекции Dictionary<string, Test> первый элемент найден за {sw.ElapsedTicks}");
            else Console.WriteLine($"В коллекции Dictionary<string, Test> первый элемент не найден");
        }

        public void FindMiddle()
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();
            bool ok = c1.Contains(middleObject);
            sw.Stop();

            if (ok) Console.WriteLine($"В коллекции Queue<Test> срений элемент найден за {sw.ElapsedTicks}");
            else Console.WriteLine($"В коллекции Queue<Test> средний элемент не найден");

            sw.Restart();
            ok = c2.Contains(middleObject.ToString());
            sw.Stop();

            if (ok) Console.WriteLine($"В коллекции Queue<string> средний элемент найден за {sw.ElapsedTicks}");
            else Console.WriteLine($"В коллекции Queue<string> средний элемент не найден");

            sw.Restart();
            ok = c3.ContainsKey(middleObject);
            sw.Stop();

            if (ok) Console.WriteLine($"В коллекции Dictionary<Challenge, Test> средний элемент найден за {sw.ElapsedTicks}");
            else Console.WriteLine($"В коллекции Dictionary<Challenge, Test> средний элемент не найден");

            sw.Restart();
            ok = c4.ContainsValue(middleObject);
            sw.Stop();

            if (ok) Console.WriteLine($"В коллекции Dictionary<string, Test> средний элемент найден за {sw.ElapsedTicks}");
            else Console.WriteLine($"В коллекции Dictionary<string, Test> средний элемент не найден");
        }

        public void FindLast()
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();
            bool ok = c1.Contains(lastObject);
            sw.Stop();

            if (ok) Console.WriteLine($"В коллекции Queue<Test> последний элемент найден за {sw.ElapsedTicks}");
            else Console.WriteLine($"В коллекции Queue<Test> последний элемент не найден");

            sw.Restart();
            ok = c2.Contains(lastObject.ToString());
            sw.Stop();

            if (ok) Console.WriteLine($"В коллекции Queue<string> последний элемент найден за {sw.ElapsedTicks}");
            else Console.WriteLine($"В коллекции Queue<string> последний элемент не найден");

            sw.Restart();
            ok = c3.ContainsKey(lastObject);
            sw.Stop();

            if (ok) Console.WriteLine($"В коллекции Dictionary<Challenge, Test> последний элемент найден за {sw.ElapsedTicks}");
            else Console.WriteLine($"В коллекции Dictionary<Challenge, Test> последний элемент не найден");

            sw.Restart();
            ok = c4.ContainsValue(lastObject);
            sw.Stop();

            if (ok) Console.WriteLine($"В коллекции Dictionary<string, Test> последний элемент найден за {sw.ElapsedTicks}");
            else Console.WriteLine($"В коллекции Dictionary<string, Test> последний элемент не найден");
        }

        public void NotFound()
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();
            bool ok = c1.Contains(notFound);
            sw.Stop();

            if (!ok) Console.WriteLine($"В коллекции Queue<Test> элемент, не входящий в коллекцию, найден за {sw.ElapsedTicks}");
            else Console.WriteLine($"В коллекции Queue<Test> элемент, не входящий в коллекцию, не найден");

            sw.Restart();
            ok = c2.Contains(notFound.ToString());
            sw.Stop();

            if (!ok) Console.WriteLine($"В коллекции Queue<string> элемент, не входящий в коллекцию, найден за {sw.ElapsedTicks}");
            else Console.WriteLine($"В коллекции Queue<string> элемент, не входящий в коллекцию, не найден");

            sw.Restart();
            ok = c3.ContainsKey(notFound);
            sw.Stop();

            if (!ok) Console.WriteLine($"В коллекции Dictionary<Challenge, Test> элемент, не входящий в коллекцию, найден за {sw.ElapsedTicks}");
            else Console.WriteLine($"В коллекции Dictionary<Challenge, Test> элемент, не входящий в коллекцию, не найден");

            sw.Restart();
            ok = c4.ContainsValue(notFound);
            sw.Stop();

            if (!ok) Console.WriteLine($"В коллекции Dictionary<string, Test> элемент, не входящий в коллекцию, найден за {sw.ElapsedTicks}");
            else Console.WriteLine($"В коллекции Dictionary<string, Test> элемент, не входящий в коллекцию, не найден");
        }


        public void AddQueue(Test obj)
        {
            c1.Enqueue(obj);
            c2.Enqueue(obj.ToString());

            PrintQueueOfString(c2);
            PrintQueueOfChallenge(c1);
        }

        public void AddDictionary(Challenge chal, Test test)
        {
            c3.Add(chal, test);
            PrintDictionaryOfChallenge(c3);

            c4.Add(chal.ToString(), test);
            PrintDictionaryOfString(c4);
        }

        public void DequeueDictionary(Challenge chal, Test test)
        {
            c3.Remove(test);
            c4.Remove(chal.ToString(), out test);

            PrintDictionaryOfString(c4);
            PrintDictionaryOfChallenge(c3);
        }

        public void DequeueQueue()
        {
            c1.Dequeue();
            c2.Dequeue();

            PrintQueueOfString(c2);
            PrintQueueOfChallenge(c1);
        }
    }
}