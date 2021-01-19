using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;
using System.Threading.Tasks;

namespace _14LabTask
{
    class Program
    {
        static void MenuForInquiries() // меню запросов
        {
            Console.WriteLine("1. Запрос на сводку данных (Все студенты двух университетов)");
            Console.WriteLine("2. Запрос на получение счетчика (Количество студентов 4 курса)");
            Console.WriteLine("3. Запрос на использование операций над множествами (Студенты 3 курса, не сдавшие экзамены (<50%))");
            Console.WriteLine("4. Агрегирование данных (Средний результат экзаменов)");
            Console.WriteLine("5. Запрос на использование группировки данных (Студенты 1-2 курса, сдававшие Матанализ или Программирование или Киберспорт)");
            Console.WriteLine("6. Выход");
        }

        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, Challenge>> uni = new Dictionary<string, Dictionary<string, Challenge>>();
            Dictionary<string, Challenge> university1 = new Univer().Firstd().ToDictionary(c => c.LastName);
            Dictionary<string, Challenge> university2 = new Univer().Secondd().ToDictionary(c => c.LastName);
            uni.Add("ПГНИУ", university1);
            uni.Add("ПГТУ", university2);

            Console.WriteLine();
            Console.WriteLine("1. Запрос на сводку данных (Все студенты двух университетов)");
            Query.Q1(uni);

            Console.WriteLine();
            Console.WriteLine("2. Запрос на получение счетчика (Количество студентов 4 курса)");
            Query.Q2(uni);

            Console.WriteLine();
            Console.WriteLine("3. Запрос на использование операций над множествами (Студенты 3 курса, сдавшие экзамены (>50%))");
            Query.Q3(university1, university2);

            Console.WriteLine();
            Console.WriteLine("4. Агрегирование данных (Минимальный результат экзаменов)");
            Query.Q4(university1);

            Console.WriteLine();
            Console.WriteLine("5. Запрос на использование группировки данных (Сумма всех курсов)");
            Query.Q5(uni);
        }
    }
}
