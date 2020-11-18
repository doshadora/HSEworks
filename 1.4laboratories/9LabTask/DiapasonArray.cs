using System;

namespace _9LabTask
{
    class DiapasonArray
    {
        Diapason[] arr = null;
        static Random rnd = new Random();
        public static int counter = 0;

        public int Length
        {
            get
            {
                return arr.Length;
            }
        }

        public DiapasonArray() // создание конструктором без параметров
        {
            arr = new Diapason[1];
            Diapason d = new Diapason(0, 0);
            arr[0] = d;
        }

        public DiapasonArray(int size) // создание ДСЧ
        {
            arr = new Diapason[size];
            for (int i = 0; i < size; i++)
            {
                Diapason d = new Diapason(rnd.Next(0, 20), rnd.Next(21, 40));
                arr[i] = d;
                counter++;
            }
        }

        public DiapasonArray(params string[] p) // создание вручную
        {
            int size = p.Length;
            arr = new Diapason[size];

            for (int i = 0; i < size; i++)
            {
                Diapason d = new Diapason();
                string str = p[i];
                string[] m = str.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                double X;
                double Y;
                if (m.Length > 2)
                {
                    Console.WriteLine("Вы ввели неверное количество параметров!");
                }

                else if (!Double.TryParse(m[0], out X))
                {
                    Console.WriteLine($"Ошибка ввода координаты X{i + 1}");
                }
                else if (!Double.TryParse(m[1], out Y))
                {
                    Console.WriteLine($"Ошибка ввода координаты Y{i + 1}");
                }
                else
                {
                    d.x = Convert.ToDouble(m[0]);
                    d.y = Convert.ToDouble(m[1]);
                    arr[i] = d;
                }
            }
        }

        public Diapason this[int index] // доступ к объектам массива
        {
            get
            {
                if (index >= 0 && index < arr.Length)
                    return arr[index];
                else
                {
                    Console.WriteLine("Error!");
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (index >= 0 && index < arr.Length)
                    arr[index] = value;
                else
                {
                    Console.WriteLine("Error!");
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public void Show()
        {
            if (arr == null || arr.Length == 0 || arr.Length == 1)
            {
                Console.WriteLine("Массив пустой");
                return;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].Show();
            }
        }

       
    }
}