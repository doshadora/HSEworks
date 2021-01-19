using System;
using System.Collections.Generic;
using System.Text;

namespace _14LabTask
{
    public class Students
    {
        protected static Random rnd = new Random();

        public static string[] lastNames = { "Соловьев", "Дерябин", "Носков", "Яковлев", "Томасов", "Костенко", "Иванов", "Петров", "Сидоров", "Попов", "Поляков", "Костин", "Богомяков", "Третьяков", "Павлов", "Галкин" };
        public static string[] names = { "Андрей", "Михаил", "Евгений", "Александр", "Алексей", "Лев", "Константин", "Владимир", "Пётр", "Вадим", "Арсений", "Никита", "Василий", "Артём", "Владислав" };
        public static int course;

        public string LastName { get; set; }

        public string SName { get; set; }

        public int Course { get; set; }

        public Students()
        {
            LastName = lastNames[rnd.Next(lastNames.Length)];
            SName = names[rnd.Next(names.Length)];
            Course = rnd.Next(1,5);
        }

        public Students(string f, string n, int c)
        {
            LastName = f;
            SName = n;
            Course = c;
        }

        public override string ToString()
        {
            return LastName.ToString() + " " + SName.ToString() + ", " + Course.ToString() + " курс";
        }

        public object Clone()
        {
            return new Students(this.LastName, this.SName, this.Course);
        }

        public override int GetHashCode()
        {
            return LastName.GetHashCode() + SName.GetHashCode() + Course.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Students s = (Students)obj;
            return (this.LastName == s.LastName) && (this.SName == s.SName) && (this.Course == s.Course);
        }

        public int CompareTo(object obj)
        {
            Students s = (Students)obj;
            if (string.Compare(LastName, s.LastName) > 0) return 1;
            else if (string.Compare(LastName, s.LastName) < 0) return -1;
            else return 0;
        }

        public virtual void Show()
        {
            Console.WriteLine(this.ToString());
        }
    }
}

