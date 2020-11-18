using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10LabTask
{
    class Challenge
    {
        public string name, discipline, type;
        public int result, questions, retakes;
        public static string passed;
        public static int count = 0;
        static Random rnd = new Random();

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Discipline
        {
            get { return discipline; }
            set { discipline = value; }
        }

        public int Result
        {
            get { return result; }
            set { result = value; }
        }

        public int Questions
        {
            get { return questions; }
            set { questions = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Passed
        {
            get { return passed; }
            set { if (result >= 80) passed = "да"; else passed = "нет"; }
        }

        public Challenge(string n)
        {
            name = n;
        }

        public Challenge()
        {
            name = "";
        }

        virtual public void Average() { }

        virtual public void Show()
        {
            Console.WriteLine("Испытание: " + name);
        }
    }
}
