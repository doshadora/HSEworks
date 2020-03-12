using System;
using System.IO;
using System.Windows.Forms;


namespace _7LabTask
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void PrintArray()
        {
            if (masCreated)
            {
                string f, k;
                f = "";
                for (int i = 0; i < arr.Length; i++)
                {
                    k = arr[i].ToString();
                    f += k + " ";
                }

                label3.Visible = true;
                button11.Visible = true;

                label3.Text = f;
            }
            else
            {
                MessageBox.Show("Массив не создан!");
            }
        }

        private void MakeInvisible()
        {
            label2.Visible = false;
            label3.Visible = false;
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
            textBox3.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e) // создание массива
        {
            label2.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button8.Visible = true;
        }

        private void Button2_Click(object sender, EventArgs e) // кнопка удаления элементов
        {
            if (masCreated)
            {
                label6.Visible = true;
                button12.Visible = true;
                textBox3.Visible = true;
            }
            else
            {
                MessageBox.Show("Массив не создан!");
            }
        }

        private void Button3_Click(object sender, EventArgs e) // назад
        {
            this.Close();
        }

        private void Button4_Click(object sender, EventArgs e) // ввод с помощью ДСЧ
        {
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            button5.Visible = false;
            button9.Visible = true;
            textBox1.Visible = true;
        }

        private void Button5_Click(object sender, EventArgs e) // ручной ввод
        {
            label3.Visible = true;
            label2.Visible = true;
            label4.Visible = true;
            button4.Visible = false;
            button6.Visible = true;
            textBox1.Visible = true;
        }

        bool masCreated = false;
        int n;
        int[] arr;

        private void Button6_Click(object sender, EventArgs e) // проверка ввода числа при вводе с клавиатуры
        {
            bool ok = Int32.TryParse(textBox1.Text, out n);
            if ((ok) && (n > 0)) // верный ввод
            {
                label5.Visible = true;
                button7.Visible = true;
                button11.Visible = true;
                textBox2.Visible = true;
            }
            else // неверный ввод
            {
                MessageBox.Show("Ошибка! Повторите ввод!");
                textBox1.Clear();
            }
        }
        private void Button7_Click(object sender, EventArgs e) // проверка введённого массива
        {
            bool ok;
            string f = textBox2.Text;

            string[] arrs = f.Split();
            int[] temp = new int[n];
            if (n == arrs.Length)
            {
                ok = Int32.TryParse(arrs[0], out temp[0]);
                int i = 1;
                while ((ok) && (i < n))
                {
                    ok = Int32.TryParse(arrs[i], out temp[i]);
                    i++;
                }
                if (!ok)
                {
                    MessageBox.Show("Ошибка ввода элемента номер " + (i));
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show("Массив создан!");
                    textBox2.Clear();

                    arr = temp;

                    masCreated = true;

                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    button8.Visible = false;
                    button11.Visible = false;
                    textBox1.Visible = false;
                    textBox2.Visible = false;

                    PrintArray();
                }

            }
            else { MessageBox.Show("Введено другое кол-во элементов"); }
        }

        private void Button8_Click(object sender, EventArgs e) // возвращение к выбору действия
        {
            MakeInvisible();
        }

        private void Button9_Click(object sender, EventArgs e) // создание массива с ДСЧ
        {
            bool ok = Int32.TryParse(textBox1.Text, out n);
            int[] temp = new int[n];
            if (ok)
            {
                if ((n >= 0) && (n <= 100))
                {
                    Random rnd = new Random();
                    for (int i = 0; i < n; i++)
                    {
                        temp[i] = rnd.Next(-100, 100);
                    }
                    arr = temp;
                    masCreated = true;
                    MessageBox.Show("Массив создан!");

                    label2.Visible = false;

                    label4.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button8.Visible = false;
                    button9.Visible = false;
                    textBox1.Visible = false;

                    PrintArray();
                }
                else // неверный ввод
                {
                    MessageBox.Show("Ошибка! Повторите ввод!");
                    textBox1.Clear();
                }
            }
            textBox1.Clear();
        }

        private void Button11_Click(object sender, EventArgs e) // скрытие панели ввода чисел
        {
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
        }

        private void Button12_Click(object sender, EventArgs e) // удаление элемента под заданным номером
        {
            int i = 0, j = 0;
            int[] temp = new int[n - 1];
            bool ok = Int32.TryParse(textBox3.Text, out int index);
            if (index == 0 || index > n)
            {
                MessageBox.Show("Номер элемента введён неверно.");
                textBox3.Clear();
            }
            else
            {
                do
                {
                    if (index - 1 != i)
                    {
                        temp[j] = arr[i];
                        j++;
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                } while (i < n);
                arr = temp;
                n -= 1;

                textBox3.Clear();
                MessageBox.Show("Удаление выполнено.");

                if (arr.Length == 0)
                {
                    masCreated = false;
                    label3.Visible = false;
                    button11.Visible = false;
                    label6.Visible = false;
                    button12.Visible = false;
                    textBox3.Visible = false;

                    label3.Text = "";
                    MessageBox.Show("Массив стал пустым!");
                }
                else
                {
                    PrintArray();
                }
            }
        }

        private void Button13_Click(object sender, EventArgs e) // прочитать массив из файла
        {
            int count1 = 0;
            int i;
            string a;
            bool ok = false;
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = @"D:\source\repos\HSEworks\1.3laboratories\7LabTask\bin\Debug";
            open.Filter = "*.txt|*.*";
            open.ShowDialog();
            Stream file = null;

            try
            {
                file = open.OpenFile();
                StreamReader sr = new StreamReader(file);
                string[] arr1 = new string[1];
                a = sr.ReadLine();
                arr1[0] = a;
                if ((a = sr.ReadLine()) != null)
                {
                    MessageBox.Show("В файле содержится не одномерный массив. Выберите другой файл", "Работа с одномерным массивом", MessageBoxButtons.OK,
 MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        arr1[0] = arr1[0].Trim();
                        for (int j = 0; j < arr1[0].Length - 1; j++)
                            if (arr1[0][j] == ' ' && arr1[0][j + 1] == ' ')
                            {
                                arr1[0] = arr1[0].Remove(j, 1);
                                j--;
                            }
                        string[] mas1 = arr1[0].Split(' ');
                        arr = new int[mas1.Length];

                        for (i = 0; i < mas1.Length; i++)
                        {
                            int j;
                            ok = int.TryParse(mas1[i], out j);

                            if (!ok)
                            {
                                MessageBox.Show("Исходные данные в файле имеют неверный формат\n" + "Значения должны быть целочисленными!\n" + "Отредактируйте файл", "Работа с одномерными массивами", MessageBoxButtons.OK,
                          MessageBoxIcon.Error);
                                break;
                            }
                            else
                            {
                                arr[i] = j;
                                count1++;
                            }
                        }
                        if (ok)
                        {
                            int[] mas2 = new int[count1];
                            for (i = 0; i < mas2.Length; i++)
                            {
                                mas2[i] = arr[i];
                            }
                            arr = mas2;
                            a = "";
                            for (i = 0; i < arr1[0].Length; i++)
                                a += arr1[0][i];

                            masCreated = true;
                            label3.Visible = true;
                            button11.Visible = true;
                            label3.Text = a;

                            n = arr.Length;
                        }
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("Файл пуст! " + "Выберите другой файл", "Работа с одномерными массивами", MessageBoxButtons.OK,
MessageBoxIcon.Error);
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Вы не выбрали файл", "Работа с одномерными массивами", MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
            }
        }

        private void Button14_Click(object sender, EventArgs e) // сохранение массива в файл
        {
            if (arr != null)
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