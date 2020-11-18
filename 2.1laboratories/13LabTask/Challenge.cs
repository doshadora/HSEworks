using System;
using System.Collections.Generic;
using System.Text;

namespace _13LabTask
{
    public class Challenge
    {
        protected string[] arrayName = { "Матанализ", "Программирование", "Языковедение", "БЖД", "Управление сетями и данными", "Киберспорт", "Методология", "История русской культуры", "Прикладная физкультура", "Основы вожатской деятельности", "Украинский язык", "Логистика", "Теория вероятности", "Педагогика", "Речевой английский язык", "Немецкий язык", "Корейский язык", "Информационные технологии", "Лингводидактика", "Анатомия", "Физиология", "Мировая литература", "История искусств", "Французский язык", "БИология", "Древние языки", "Культурология", "Дискретная математика", "Философия", "Право", "История", "Английский язык", "Физкультура", "Эконометрика", "Управление данными" };
        protected static Random rnd = new Random();

        public string Name { get; set; }
        public int Questions { get; set; }

        public Challenge(string n, int q)
        {
            Name = n;
            Questions = q;
        }

        public Challenge()
        {
            Name = arrayName[rnd.Next(arrayName.Length)];
            Questions = rnd.Next(5, 50);
        }

        public override string ToString()
        {
            return Name + ", " + Questions.ToString();
        }

        public object Clone()
        {
            return new Challenge(this.Name, this.Questions);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Questions.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Challenge chal = (Challenge)obj;
            return (this.Name == chal.Name) && (this.Questions == chal.Questions);
        }
    }
}