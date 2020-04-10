using System;
using System.IO;
using System.Windows.Forms;

namespace _7LabTask
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void PrintArray()
        {
            label3.Text = "";
            if (!masCreated)
            {
                MessageBox.Show("Массив не создан!");
            }
            else
            {
                if (str == 0)
                {
                    MessageBox.Show("Массив пустой.");
                }
                else
                {
                    label3.Visible = true;
                    button11.Visible = true;
                    string g = "";

                    for (int i = 0; i < jagged.Length; i++)
                    {
                        string f = "";
                        for (int j = 0; j < jagged[i].Length; j++)
                        {
                            f += jagged[i][j].ToString() + " ";
                        }
                        g += f + "\r\n";

                    }
                    label3.Text = g;
                }
            }
        }

        private void MakeInvisible()
        {
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button15.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
        }

        bool masCreated = false;
        int str; // строка
        int check = 0;

        int p, t; // счетчики для надписей
        string g; // изменяющаяся строка
        int[][] jagged;

        private void Button1_Click(object sender, EventArgs e) // создать массив
        {
            label2.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button8.Visible = true;
        }

        private void Button2_Click(object sender, EventArgs e) // кнопка удалить строки
        {
            if (!masCreated)
            {
                MessageBox.Show("Массив не создан!");
            }
            else
            {
                label3.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                button9.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
            }
        }

        private void Button3_Click(object sender, EventArgs e) // закрыть форму
        {
            this.Close();
        }

        private void Button4_Click(object sender, EventArgs e) // ввод ДСЧ
        {
            label3.Visible = true;
            label4.Visible = true;
            button5.Visible = false;
            button11.Visible = true;
            button15.Visible = true;
            textBox1.Visible = true;
        }

        private void Button5_Click(object sender, EventArgs e) // ввод с помощью ДСЧ
        {
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            button4.Visible = false;
            button6.Visible = true;
            button11.Visible = true;
            textBox1.Visible = true;
        }

        private void Button6_Click(object sender, EventArgs e) // проверка ввода количества строк
        {
            bool s = Int32.TryParse(textBox1.Text, out str);

            if ((s) && (str > 0) && (str <= 100)) // верный ввод
            {
                MessageBox.Show("Количество строк введено.");
                g = "Введите количество элементов строки №";
                p = 1;

                label6.Text = g + p;

                label6.Visible = true;
                button7.Visible = true;
                textBox2.Visible = true;

                jagged = new int[str][];
            }
            else // неверный ввод
            {
                if (!s || str <= 0)
                {
                    MessageBox.Show("Неверный ввод количества строк!");
                    textBox1.Clear();
                }
            }
            button6.Visible = false;
        }

        private void Button7_Click(object sender, EventArgs e) // проверка ввода количества элементов в строке
        {
            int col;
            bool num = Int32.TryParse(textBox2.Text, out col);

            if (num)
            {
                if ((col > 0) && (col < 100))
                {
                    jagged[p - 1] = new int[col];
                    p++;

                }
                else
                {
                    MessageBox.Show("Выход из диапазона");
                    textBox2.Clear();
                }
            }
            else
            {
                MessageBox.Show("Неправильное значение");
                textBox2.Clear();
            }

            if (p <= str)
            {
                label6.Text = "Введите количество элементов строки №" + p;
                textBox2.Clear();
            }
            else
            {
                p = 1;
                label6.Text = "Ввод окончен";
                button7.Visible = false;

                MessageBox.Show("Количество элементов в строках введено.");
                int c = jagged[0].Length;

                g = "Введите элементы строки №";
                t = 1;

                label7.Text = g + t + " (из " + c + " элементов)";

                label7.Visible = true;
                button12.Visible = true;
                textBox3.Visible = true;
            }
        }

        private void Button8_Click(object sender, EventArgs e) // закрыть всё кроме меню слева
        {
            MakeInvisible();
        }

        private void Button9_Click(object sender, EventArgs e) // удаление строк, новый массив
        {
            if (!masCreated)
            {
                MessageBox.Show("Массив пустой.");
            }
            else
            {
                int k, n; // количество строк, номер, начиная с которого удаляются строки

                bool kk = Int32.TryParse(textBox4.Text, out k);
                bool nn = Int32.TryParse(textBox5.Text, out n);

                if (kk)
                {
                    if (nn)
                    {
                        if (k > str)
                        {
                            MessageBox.Show("Слишком много выбранных строк!");
                            textBox4.Clear();
                        }

                        if (k <= 0)
                        {
                            MessageBox.Show("Количество строк для удаления должно быть больше 0!");
                            textBox4.Clear();
                        }

                        if (n <= 0)
                        {
                            MessageBox.Show("Номер строки должен быть больше 0.");
                            textBox5.Clear();
                        }

                        if (n + k - 1 > str)
                        {
                            MessageBox.Show("Невозможно удалить строки при заданных значениях.");
                            textBox4.Clear();
                            textBox5.Clear();
                        }

                        if (k == str && n == 1)
                        {
                            str = 0;
                            jagged = null;
                            MessageBox.Show("Массив стал пустым");

                            MakeInvisible();
                        }

                        if ((k > 0) && (n > 0) && (k <= str) && (n + k - 1 <= str))
                        {
                            int p = 0, j;
                            int[][] temp = new int[str - k][];
                            for (int i = 0; i < n - 1; i++)
                            {
                                temp[p] = new int[jagged[i].Length];
                                for (j = 0; j < jagged[i].Length; j++)
                                {
                                    temp[p][j] = jagged[i][j];
                                }
                                p++;
                            }

                            for (int i = k + n - 1; i < str; i++)
                            {
                                temp[p] = new int[jagged[i].Length];
                                for (j = 0; j < jagged[i].Length; j++)
                                {
                                    temp[p][j] = jagged[i][j];
                                }
                                p++;
                            }
                            str -= k;
                            jagged = temp;
                            MessageBox.Show("Массив успешно изменен.");

                            MakeInvisible();
                            PrintArray();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неверный ввод номера строки.");
                        textBox5.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Неверный ввод количества строк.");
                }
                textBox4.Clear();
            }
        }

        private void Button11_Click(object sender, EventArgs e) // закрыть всё кроме меню слева
        {
            MakeInvisible();
        }

        private void Button12_Click(object sender, EventArgs e) // ввод элементов массива
        {
            bool ok = true;
            int j;

            string[] mas = textBox3.Text.Split();

            if (mas.Length == jagged[p - 1].Length)
            {
                if (check < str)
                {
                    int temp;
                    for (j = 0; j < jagged[p - 1].Length; j++)
                    {
                        ok = Int32.TryParse(mas[j], out temp);
                        if (ok)
                        {
                            jagged[p - 1][j] = temp;
                        }
                        else
                        {
                            MessageBox.Show("Неправильно введён элемент " + (j + 1));
                            j = 1000;
                            textBox3.Clear();
                        }
                    }
                }
                textBox3.Clear();

                if (p == str)
                {
                    MessageBox.Show("Массив создан!");

                    masCreated = true;

                    MakeInvisible();

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();

                    PrintArray();
                }
                else
                {
                    p++;
                    label7.Text = "Введите элементы строки №" + p + " (из " + (jagged[p - 1].Length) + " элементов)";
                }
            }
            else
            {
                MessageBox.Show("Неверное количество чисел");
                textBox3.Clear();
            }
        }

        private void Button13_Click(object sender, EventArgs e) // чтение массива из файла
        {
            int i, j;
            string strs;
            int count1 = 0;
            string[] mas1;
            int[][] masReady = new int[100][];
            bool ok = true;
            bool check = false;

            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = @"D:\source\repos\HSEworks\1.3laboratories\7LabTask\bin\Debug";
            open.Filter = "*.txt|*.*";
            open.ShowDialog();
            Stream file = null;

            try
            {
                file = open.OpenFile();
                StreamReader sr = new StreamReader(file);
                try
                {
                    do
                    {
                        strs = sr.ReadLine();
                        if (strs == null && count1 == 0)
                        {
                            ok = false;
                            MessageBox.Show("В файле содержится не двумерный массив. Выберите другой файл", "Работа с двумерным массивом", MessageBoxButtons.OK,
            MessageBoxIcon.Error);
                            break;
                        }
                        else
                        {
                            if (strs == null && count1 != 0)
                            {
                                ok = false;
                                check = true;
                            }
                            else
                            {
                                strs = strs.Trim();

                                for (i = 0; i < strs.Length - 1; i++)
                                {
                                    strs = strs.Trim();
                                    if (strs[i] == ' ' && strs[i + 1] == ' ')
                                    {
                                        strs = strs.Remove(i, 1);
                                        i--;
                                    }
                                }

                                mas1 = strs.Split(' ');

                                masReady[count1] = new int[mas1.Length];

                                for (i = 0; i < mas1.Length; i++)
                                {
                                    ok = int.TryParse(mas1[i], out j);
                                    if (!ok)
                                    {
                                        MessageBox.Show("Исходные данные в файле имеют неверный формат\n" + "Значения должны быть целочисленными!\n" + "Отредактируйте файл", "Работа с рваными массивами", MessageBoxButtons.OK,
                                   MessageBoxIcon.Error); break;
                                    }
                                    else masReady[count1][i] = j;
                                }
                            }
                        }
                        if (ok) count1++;
                    } while (ok);
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("В файле содержится не рваный массив. Выберите другой файл", "Работа с рваным массивом", MessageBoxButtons.OK,
        MessageBoxIcon.Error);
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Вы не выбрали файл", "Работа с рваными массивами", MessageBoxButtons.OK,
                         MessageBoxIcon.Error); ok = false;
            }

            if (check)
            {
                ok = true;
                string[] brr = new string[count1];
                for (i = 0; i < count1; i++)
                {

                    strs = "";
                    for (j = 0; j < masReady[i].Length; j++)
                    {
                        strs += (Convert.ToString(masReady[i][j]) + " ");
                    }
                    brr[i] = strs;
                }

                jagged = masReady;
                strs = "";

                for (i = 0; i < count1 - 1; i++)
                {
                    strs += brr[i] + "\n";
                }
                try { strs += brr[count1 - 1]; }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Файл пуст!", "Работа с рваными массивами", MessageBoxButtons.OK,
MessageBoxIcon.Error);
                    ok = false;
                }

                if (check && ok)
                {
                    str = i+1;
                    masCreated = true;
                    label3.Visible = true;
                    label3.Text = strs;
                }
            }
        }

        private void Button14_Click(object sender, EventArgs e) // сохранение массива в файл
        {
            if (jagged != null)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string filename = save.FileName;
                    File.WriteAllText(filename, label3.Text);
                    MessageBox.Show("Файл сохранен");
                }
                else
                {
                    MessageBox.Show("Файл не сохранен.");
                }
            }
            else
                MessageBox.Show("Массив пуст!");
        }

        private void Button15_Click(object sender, EventArgs e) // создание массива с ДСЧ
        {
            Random rnd = new Random { };
            bool num = Int32.TryParse(textBox1.Text, out str);

            if (num)
            {
                if ((str > 0) && (str < 100))
                {
                    jagged = new int[str][];
                    for (int i = 0; i < str; i++)
                    {
                        int vs = rnd.Next(1, 7);
                        jagged[i] = new int[vs];

                    }
                    for (int i = 0; i < str; i++)
                    {
                        for (int j = 0; j < jagged[i].Length; j++)
                        {
                            jagged[i][j] = rnd.Next(-100, 100);
                        }
                    }

                    textBox1.Clear();
                    MessageBox.Show("Массив создан");
                    masCreated = true;

                    MakeInvisible();
                    PrintArray();
                }
                else
                {
                    MessageBox.Show("Выход из диапазона");
                    textBox1.Clear();
                }
            }
            else
            {
                MessageBox.Show("Неправильное значение");
                textBox1.Clear();
            }
        }
    }
}
