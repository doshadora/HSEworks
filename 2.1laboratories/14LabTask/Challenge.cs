using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14LabTask
{
    public class Challenge : Students
    {
        protected string[] arrayName = { "Матанализ", "Программирование", "Языковедение", "БЖД", "Управление сетями и данными", "Киберспорт", "Методология", "История русской культуры", "Прикладная физкультура", "Основы вожатской деятельности", "Украинский язык", "Логистика", "Теория вероятности", "Педагогика", "Речевой английский язык", "Немецкий язык", "Корейский язык", "Информационные технологии", "Лингводидактика", "Анатомия", "Физиология", "Мировая литература", "История искусств", "Французский язык", "БИология", "Древние языки", "Культурология", "Дискретная математика", "Философия", "Право", "История", "Английский язык", "Физкультура", "Эконометрика", "Управление данными" };
        protected static Random rnd = new Random();

        public string CName { get; set; }
        public int Result { get; set; }
        public Students StudBase { get { return new Students(this.LastName, this.SName, this.Course); } }

        public Challenge(string f, string n, int c, string cn, int r) : base(f, n, c)
        {
            CName = cn;
            Result = r;
        }

        public Challenge() : base()
        {
            CName = arrayName[rnd.Next(arrayName.Length)];
            Result = rnd.Next(1, 100);
        }

        public override string ToString()
        {
            return base.ToString() + " - " + CName + ", " + Result.ToString() + "%";
        }

        public Students GetBase()
        {
            return new Students(this.LastName, this.SName, this.Course);
        }

        public object Clone()
        {
            return new Challenge(this.LastName, this.SName, this.Course, this.CName, this.Result);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj) && (this.CName == ((Challenge)obj).CName) && (this.Result == ((Challenge)obj).Result);
        }

        public override void Show()
        {
            Console.WriteLine(this.ToString());
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() + CName.GetHashCode() + Result.GetHashCode();
        }
    }
}