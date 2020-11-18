using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10LabTask
{
    class FinalExam : Exam
    {
        static Random rnd = new Random();
        public string fExam;

        public FinalExam(string d, int r, string p, int re)
            : base(d, r, p)
        {
            fExam = "Выпускной ";
            retakes = re;
        }

        public override void Show()
        {
            Console.WriteLine("\nИспытание: " + fExam + name + "\n  дисциплина: " + discipline + "\n  результат: " + result + "%" + "\n  кол-во пересдач: " + retakes + "\n  зачёт: " + passed);
        }
    }
}
