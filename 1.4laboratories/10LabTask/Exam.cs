using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10LabTask
{
    class Exam : Challenge
    {
        static Random rnd = new Random();

        public Exam(string d, int r, string p) 
            : base(p)
        {
            discipline = d;
            result = r;
            passed = p;
        }

        public Exam()
        {
            int num = rnd.Next(1, 7);
            if (num == 1) this.discipline = "Математический анализ";
            if (num == 2) this.discipline = "Английский язык";
            if (num == 3) this.discipline = "Программирование";
            if (num == 4) this.discipline = "Философия";
            if (num == 5) this.discipline = "Правоведение";
            if (num == 6) this.discipline = "Экономика";
            if (num == 7) this.discipline = "Теоретические основы информатики";

            this.result = rnd.Next(0, 100);
        }

        public override void Show()
        {
            Console.WriteLine("\n" + "Испытание: " + name + "\n  дисциплина: " + discipline + "\n  результат: " + result + "%" + "\n  зачёт: "/* + Passed.passed*/);
        }

        public override void Average()
        {
        }
    }
}
