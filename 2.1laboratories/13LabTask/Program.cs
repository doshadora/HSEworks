using System;

namespace _13LabTask
{
    class Program
    {
        static void Main(string[] args)
        {
            MyNewCollection<Challenge> mc1 = new MyNewCollection<Challenge>();
            Journal<Challenge> j1 = new Journal<Challenge>();
            mc1.CollectionCountChanged += j1.AddInfoAboutCountChanged;

            mc1.Add(new Challenge());
            mc1.Add(new Challenge());
            mc1.Add(new Challenge());
            mc1.Add(new Challenge());

            mc1.ShowCollection();
            Test t = new Test("Правоведение", 30, 20);
            mc1.Add(t);
            mc1.ShowCollection();

            foreach (Challenge x in mc1)
                Console.WriteLine(x);

            Console.WriteLine("JOURNAL");
            j1.PrintJournal();
        }
    }
}
