using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10LabTask
{
    class Test : Challenge
    {
        static Random rnd = new Random();

        public Test(string d, string t, int q, int r)
        {
            discipline = d;
            type = t;
            questions = q;
            result = r;
        }

        public Test()
        {
            int num = rnd.Next(1, 7);
            if (num == 1) this.discipline = "Математический анализ";
            if (num == 2) this.discipline = "Английский язык";
            if (num == 3) this.discipline = "Программирование";
            if (num == 4) this.discipline = "Философия";
            if (num == 5) this.discipline = "Правоведение";
            if (num == 6) this.discipline = "Экономика";
            if (num == 7) this.discipline = "Теоретические основы информатики";

            int num1 = rnd.Next(1, 3);
            if (num1 == 1) this.type = "микроконтроль";
            if (num1 == 2) this.type = "онлайн-тест";
            if (num1 == 3) this.type = "по лекции";

            this.questions = rnd.Next(20, 50);
            result = rnd.Next(0, 100);
        }

        public override void Show()
        {
            Console.WriteLine("\n" + "Испытание: " + name + "(" + type + ")" + "\n  дисциплина: " + discipline + "\n  кол-во вопросов: " + questions + "\n  результат: " + result + "%");
        }
    }
}
