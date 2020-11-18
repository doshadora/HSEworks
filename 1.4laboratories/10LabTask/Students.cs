using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _10LabTask
{
    internal class Students 
    {
        protected static Random rnd = new Random();

        public static string[] lastNames = { "Иванов", "Петров", "Сидоров", "Попов", "Поляков", "Костин", "Богомяков", "Третьяков", "Павлов", "Галкин" };
        public static string[] names = { "Андрей", "Михаил", "Евгений", "Александр", "Алексей", "Лев", "Константин", "Владимир", "Пётр", "Вадим", "Арсений", "Никита", "Василий", "Артём" ,"Владислав"};

        public string LastName { get; set; }

        public string Name { get; set; }

        public Students()
        {
            LastName = "";
            Name = "";
        }

        public Students(string f, string n)
        {
            LastName = f;
            Name = n;
        }

        public virtual void Show()
        {
            Console.WriteLine(LastName + " " + Name);
        }
    }
}
