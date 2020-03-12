using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace _7LabTask
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void CloseNotMenu()
        {
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button11.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
        }

        private void PrintArray()
        {
            if (!masCreated)
            {
                MessageBox.Show("Массив не создан");
            }
            else
            {
                if ((str == 0) || (col == 0))
                {
                    MessageBox.Show("Нулевой массив");
                }
                else
                {
                    label3.Visible = true;
                    button11.Visible = true;
                    string g = "";
                    for (int i = 0; i < str; i++)
                    {
                        string f = "";
                        for (int j = 0; j < col; j++)
                        {
                            f += matr[i, j].ToString() + " ";
                        }
                        g += f + "\r\n";

                    }
                    label3.Text = g;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button8.Visible = true;
        }

        private void Button2_Click(object sender, EventArgs e) // добавление строки
        {
            if (!masCreated)
            {
                MessageBox.Show("Массив не создан");
            }
            else
            {
                Random rnd = new Random { };
                int t;
                int[,] temp = new int[str + 1, col];

                for (t = 0; t < 1; t++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        temp[t, j] = rnd.Next(-100, 100);
                    }
                }
                for (int i = 0; i < str; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        temp[t, j] = matr[i, j];
                    }
                    t++;
                }
                str += 1;
                matr = temp;
                MessageBox.Show("Строка добавлена!");

                PrintArray();
            }
        }

        private void Button3_Click(object sender, EventArgs e) // назад
        {
            this.Close();
        }

        private void Button4_Click(object sender, EventArgs e) // ввод с помощью ДСЧ
        {
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            button5.Visible = false;
            button9.Visible = true;
            button11.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
        }

        private void Button5_Click(object sender, EventArgs e) // ручной ввод
        {
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            button4.Visible = false;
            button6.Visible = true;
            button11.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
        }

        bool masCreated = false;
        int str, col;

        private void Button6_Click(object sender, EventArgs e) // проверка ввода числа при вводе с клавиатуры
        {
            int check = 0;

            bool s = Int32.TryParse(textBox1.Text, out str);
            if ((s) && (str > 0)) // верный ввод
            {
                check += 1;
            }
            else // неверный ввод
            {
                MessageBox.Show("Неверный ввод количества строк!");
                textBox1.Clear();
            }

            bool c = Int32.TryParse(textBox2.Text, out col);
            if ((c) && (col > 0)) // верный ввод
            {
                check += 1;
            }
            else // неверный ввод
            {
                MessageBox.Show("Неверный ввод количества столбцов!");
                textBox2.Clear();
            }

            if (check == 2)
            {
                g = "Введите элементы строки №";
                p = 1;
                label7.Text = g + p;
                label7.Visible = true;
                button7.Visible = true;
                textBox3.Visible = true;
                matr = new int[str, col];
            }
        }

        int p;
        string g;
        int check = 0;
        int[,] matr;

        private void Button7_Click(object sender, EventArgs e) // проверка ввода массива с клавиатуры
        {
            string f = textBox3.Text;

            bool ok = true;
            int j;

            string[] mas = f.Split();

            if (mas.Length == col)
            {
                if (check < str)
                {
                    for (j = 0; j < col; j++)
                    {
                        ok = Int32.TryParse(mas[j], out matr[p - 1, j]);
                        if (!ok)
                        {
                            MessageBox.Show("Неправильно введён элемент " + (j + 1));
                            j = 1000;
                            textBox3.Clear();
                        }
                    }
                }
                if ((check < str) && ok)
                {
                    check++;
                    MessageBox.Show("Строка " + p + " введена успешно!");
                    p++;
                    textBox3.Clear();
                    label7.Text = g + p;
                }

                if (ok && check == str)
                {
                    label7.Text = "Массив готов";
                    MessageBox.Show("Массив введен");

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();

                    label2.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    button8.Visible = false;
                    button9.Visible = false;
                    textBox1.Visible = false;
                    textBox2.Visible = false;
                    textBox3.Visible = false;

                    masCreated = true;

                    PrintArray();
                }
            }

            else
            {
                MessageBox.Show("Не совпадает кол-во элементов в строке");
                textBox3.Clear();
            }

        }

        private void Button8_Click(object sender, EventArgs e) // возвращение к выбору действия
        {
            CloseNotMenu();
        }

        private void Button9_Click(object sender, EventArgs e) // создание массива с ДСЧ
        {
            bool s = Int32.TryParse(textBox1.Text, out str);
            bool c = Int32.TryParse(textBox2.Text, out col);

            if (s && c && str > 0 && col > 0 && (str <= 100) && (col <= 100))
            {
                int[,] temp = new int[str, col];
                Random rnd = new Random();

                for (int i = 0; i < str; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        temp[i, j] = rnd.Next(-100, 100);
                    }
                }

                matr = temp;
                masCreated = true;
                MessageBox.Show("Массив создан!");

                label2.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button8.Visible = false;
                button9.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;

                textBox1.Clear();
                textBox2.Clear();

                PrintArray();
            }
            else
            {
                if (!s || str <= 0)
                {
                    MessageBox.Show("Неверный ввод количества строк!");
                    textBox1.Clear();
                }
                if (!c || col <= 0)
                {
                    MessageBox.Show("Неверный ввод количества столбцов!");
                    textBox2.Clear();
                }
            }
        }

        private void Button11_Click(object sender, EventArgs e) // закрыть всё кроме меню слева
        {
            CloseNotMenu();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            int i, j;
            string strs = "", str1;
            int count1 = 0;
            string[] mas2, mas1;
            int[,] masReady = new int[100, 100];
            bool ok = true, check = false;

            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = @"D:\source\repos\HSEworks\1.3laboratories\7LabTask\bin\Debug";
            open.Filter = "*.txt|*.*";
            open.ShowDialog();
            Stream file = null;

            try
            {
                file = open.OpenFile();
                StreamReader sr = new StreamReader(file);
                str1 = sr.ReadLine();
                str1 = str1.Trim();

                for (i = 0; i < str1.Length - 1; i++)
                    if (str1[i] == ' ' && str1[i + 1] == ' ')
                    {
                        str1 = str1.Remove(i, 1);
                        i--;
                    }

                mas1 = str1.Split(' ');

                for (i = 0; i < mas1.Length; i++)
                {
                    ok = int.TryParse(mas1[i], out j);
                    if (!ok)
                    {
                        MessageBox.Show("Исходные данные в файле имеют неверный формат\n" + "Значения должны быть целочисленными!\n" + "Отредактируйте файл", "Работа с двумерными массивами", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                        break;
                    }
                    else masReady[count1, i] = j;
                }
                if (ok)
                {
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
                                    count1++;

                                    for (i = 0; i < strs.Length - 1; i++)
                                        strs = strs.Trim();
                                        if (strs[i] == ' ' && strs[i + 1] == ' ')
                                        {
                                            strs = strs.Remove(i, 1);
                                            i--;
                                        }

                                    mas2 = strs.Split(' ');
                                    for (i = 0; i < mas2.Length; i++)
                                    {
                                        ok = int.TryParse(mas2[i], out j);
                                        if (!ok)
                                        {
                                            MessageBox.Show("Исходные данные в файле имеют неверный формат\n" + "Значения должны быть целочисленными!\n" + "Отредактируйте файл", "Работа с двумерными массивами", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
                                            ok = false;
                                            break;
                                        }
                                        else masReady[count1, i] = j;
                                    }

                                    if (ok && (mas1.Length != mas2.Length))
                                    {
                                        MessageBox.Show("В файле содержится не двумерный массив. Выберите другой файл", "Работа с двумерным массивом", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                                        ok = false;
                                        break;
                                    }
                                    else if (ok)
                                    {
                                        mas2 = mas1;
                                        col = mas2.Length;
                                    }
                                }
                            }
                        } while (ok);
                    }
                    catch (NullReferenceException) when (strs == null && count1 == 0)
                    {
                        MessageBox.Show("В файле содержится не двумерный массив. Выберите другой файл", "Работа с двумерным массивом", MessageBoxButtons.OK,
        MessageBoxIcon.Error);
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Вы не выбрали файл", "Работа с двумерными массивами", MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                ok = false;
            }
            catch (NullReferenceException) when (masReady.Length == 0)
            {
                MessageBox.Show("Файл пуст!", "Работа с двумерными массивами", MessageBoxButtons.OK,
MessageBoxIcon.Error);
                ok = false;
            }

            count1 += 1;
            if (check)
            {
                int[,] mas3 = new int[count1, col];
                for (i = 0; i < count1; i++)
                {
                    for (j = 0; j < col; j++)
                    {
                        mas3[i, j] = masReady[i, j];
                    }
                }

                matr = mas3;

                string[] brr = new string[count1];

                for (i = 0; i < count1; i++)
                {
                    strs = null;
                    for (j = 0; j < col; j++)
                    {
                        strs += (Convert.ToString(masReady[i, j]) + " ");
                    }
                    brr[i] = strs;
                }
                strs = null;

                for (i = 0; i < count1 - 1; i++)
                {
                    strs += brr[i] + "\n";
                }

                str = count1;
                strs += brr[count1 - 1];

                label3.Text = strs;

                masCreated = true;
                PrintArray();
            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            if (matr != null)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                if (save.ShowDialog() == DialogResult.Cancel)
                    return;

                // получаем выбранный файл
                string filename = save.FileName;

                // сохраняем текст в файл
                File.WriteAllText(filename, label3.Text);
                MessageBox.Show("Файл сохранен");
            }
            else
                MessageBox.Show("Массив пустой!");
        }
    }
}