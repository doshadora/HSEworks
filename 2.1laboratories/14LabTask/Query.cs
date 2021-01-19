using System;
using System.Collections.Generic;
using System.Linq;

namespace _14LabTask
{
    class Query
    {
        public delegate T UsingMethod<T>(Dictionary<string, Dictionary<string, Challenge>> p);
        public delegate T UsingMethod1<T>(Dictionary<string, Challenge> p1, Dictionary<string, Challenge> p2);
        public delegate T UsingMethod2<T>(Dictionary<string, Challenge> e);

        static IEnumerable<Dictionary<string, Challenge>> GetCollOfStud(Dictionary<string, Dictionary<string, Challenge>> uni)
        {
            var dicOfStud = from c in uni select c.Value;
            return dicOfStud;
        }

        #region Запрос 1 
        public static List<Challenge> GetStudents_LINQ(Dictionary<string, Dictionary<string, Challenge>> uni)
        {
            List<Challenge> ls = new List<Challenge>();

            var students = from c in uni from c1 in c.Value where c1.Value is Challenge orderby c1.Value.LastName select c1.Value;
            foreach (Challenge c1 in students)
                ls.Add(c1);

            return ls;
        }
        public static List<Challenge> GetStudents_Lambda(Dictionary<string, Dictionary<string, Challenge>> uni)
        {
            List<Challenge> ls = new List<Challenge>();

            var GetStud = uni.SelectMany(stud => stud.Value).Where(stud => stud.Value is Challenge);
            var OrderStud = GetStud.OrderBy(item => item.Value.LastName);
            var student = OrderStud.Select(item => item.Value);

            foreach (Challenge k in student)
                ls.Add(k);

            return ls;
        }
        public static void ResultOfQ1(Dictionary<string, Dictionary<string, Challenge>> uni, UsingMethod<List<Challenge>> method)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            UsingMethod<List<Challenge>> um = new UsingMethod<List<Challenge>>(method);
            List<Challenge> students = um(uni);

            int i = 0;

            if (students.Count != 0)
                foreach (Challenge k in students)
                {
                    Console.WriteLine(k);
                    i++;
                }
            else throw new ArgumentNullException("В коллекции \"Университет\" нет студентов!");
        }

        public static void Q1(Dictionary<string, Dictionary<string, Challenge>> uni)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("Способ 1 (LINQ): ");
            Console.ForegroundColor = defaultColor;

            ResultOfQ1(uni, Query.GetStudents_LINQ);

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("Способ 2 (Лямбда-выражение): ");
            Console.ForegroundColor = defaultColor;

            ResultOfQ1(uni, Query.GetStudents_Lambda);
        }
        #endregion
        #region Запрос 2
        public static int GetNumberOfStudOn4Course_LINQ(Dictionary<string, Dictionary<string, Challenge>> uni)
        {
            int num = (from c in uni from c1 in c.Value where c1.Value.Course == 4 select c1.Value).Count();
            return num;
        }

        public static int GetNumberOfStudOn4Course_Lambda(Dictionary<string, Dictionary<string, Challenge>> uni)
        {
            var GetPeople = uni.SelectMany(stud => stud.Value).Where(Challenge => Challenge.Value.Course == 4);
            var OrderPeople = GetPeople.OrderBy(item => item.Value.LastName);
            int people = (OrderPeople.Select(Students => Students)).Count();

            return people;
        }

        public static void ResultOfQ2(Dictionary<string, Dictionary<string, Challenge>> uni, UsingMethod<int> method)
        {
            UsingMethod<int> um = new UsingMethod<int>(method);
            Console.WriteLine(um(uni));
        }

        public static void Q2(Dictionary<string, Dictionary<string, Challenge>> uni)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("Способ 1 (LINQ): ");
            Console.ForegroundColor = defaultColor;

            ResultOfQ2(uni, Query.GetNumberOfStudOn4Course_LINQ);

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("Способ 2 (Лямбда-выражение): ");
            Console.ForegroundColor = defaultColor;

            ResultOfQ2(uni, Query.GetNumberOfStudOn4Course_Lambda);
        }
        #endregion
        #region Запрос 3
        public static IEnumerable<Challenge> GetAllRes_LINQ(Dictionary<string, Challenge> a1, Dictionary<string, Challenge> a2)
        {
            var chal = (from c1 in a1 where c1.Value.Course == 3 && c1.Value is Challenge && c1.Value.Result > 50 select c1.Value).Union(from c2 in a2 where c2.Value.Course == 3 && c2.Value is Challenge && c2.Value.Result > 50 select c2.Value).OrderBy(Challenge => Challenge.LastName);
            return chal;
        }

        public static IEnumerable<Challenge> GetAllRes_Lambda(Dictionary<string, Challenge> a1, Dictionary<string, Challenge> a2)
        {
            var chal = a1.Select(Challenge => Challenge.Value).Where(Challenge => Challenge is Challenge && Challenge.Course == 3 && Challenge.Result > 50).Union(a2.Select(Challenge => Challenge.Value)).Where(Challenge => Challenge is Challenge && Challenge.Course == 3 && Challenge.Result > 50).OrderBy(Challenge => Challenge.LastName);
            return chal;
        }

        public static void ResultOfQ3(Dictionary<string, Challenge> a1, Dictionary<string, Challenge> a2, UsingMethod1<IEnumerable<Challenge>> method)
        {
            int i = 0;

            UsingMethod1<IEnumerable<Students>> um = new UsingMethod1<IEnumerable<Students>>(method);

            foreach (Students c in um(a1, a2))
            {
                Console.WriteLine(c);
                i++;
            }

        }

        public static void Q3(Dictionary<string, Challenge> a1, Dictionary<string, Challenge> a2)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("Способ 1 (LINQ): ");
            Console.ForegroundColor = defaultColor;

            ResultOfQ3(a1, a2, Query.GetAllRes_LINQ);

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("Способ 2 (Лямбда-выражение): ");
            Console.ForegroundColor = defaultColor;

            ResultOfQ3(a1, a2, Query.GetAllRes_Lambda);
        }
        #endregion
        #region Запрос 4
        public static int GetMinResultFirstU_LINQ(Dictionary<string, Challenge> uni1)
        {
            int minResultFirstU = (from a in uni1 where a.Value is Challenge select a.Value.Result).Min();
            return minResultFirstU;
        }

        public static int GetMinResultFirstU_Lambda(Dictionary<string, Challenge> uni1)
        {
            int minResultFirstU = 0;
            minResultFirstU = uni1.Values.Select(Challenge => Challenge.Result).Min();
            return minResultFirstU;
        }

        public static void ResultOfQ4(Dictionary<string, Challenge> uni1, UsingMethod2<int> method)
        {
            UsingMethod2<int> um = new UsingMethod2<int>(method);
            Console.WriteLine(um(uni1) + "%");
        }

        public static void Q4(Dictionary<string, Challenge> uni1)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("Способ 1 (LINQ): ");
            Console.ForegroundColor = defaultColor;

            ResultOfQ4(uni1, Query.GetMinResultFirstU_LINQ);

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("Способ 2 (Лямбда-выражение): ");
            Console.ForegroundColor = defaultColor;

            ResultOfQ4(uni1, Query.GetMinResultFirstU_Lambda);
        }
        #endregion
        #region Запрос 5 
        public static void GetGroupByCourse_LINQ(Dictionary<string, Dictionary<string, Challenge>> uni)
        {
            var gr = from a in uni from aa in a.Value where aa.Value is Challenge group aa by aa.Value.Course;
            Console.WriteLine("Вывод по курсам: ");
            PrintCollection(gr);
        }

        public static void GetGroupByCourse_Lambda(Dictionary<string, Dictionary<string, Challenge>> uni)
        {
            var gr = uni.SelectMany(Challenge => Challenge.Value).GroupBy(x => x.Value.Course);
            Console.WriteLine("Вывод по курсам: ");
            PrintCollection(gr);
        }

        public static void PrintCollection(IEnumerable<IGrouping<int, KeyValuePair<string, Challenge>>> coll)
        {
            int i = 0;
            foreach (var item in coll)
            {
                Console.WriteLine($"Ключ №{item.Key}\n");

                int j = 0;
                foreach (var chal in item)
                {
                    Console.WriteLine($"{j + 1}. {chal.Value}\n");
                    j++;
                }

                i++;
            }
        }

        public static void Q5(Dictionary<string, Dictionary<string, Challenge>> uni)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("Способ 1 (LINQ): ");
            Console.ForegroundColor = defaultColor;

            GetGroupByCourse_LINQ(uni);

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("Способ 2 (Лямбда-выражение): ");
            Console.ForegroundColor = defaultColor;

            GetGroupByCourse_Lambda(uni);

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
        }
        #endregion
    }
}
