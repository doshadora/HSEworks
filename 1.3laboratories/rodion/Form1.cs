using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace rodion
{
    public partial class Form1 : Form
    {
        string[,] mas = new string[100, 4];
        string[,] mas0 = new string[100, 4];
        string[,] greatMas = new string[100, 4];
        string[] mas1 = new string[100];
        int[] mas2 = new int[100];
        int[] mas3 = new int[100];
        int count = 0;

        public List<Person> personList = new List<Person>();
        public List<Credit> creditList = new List<Credit>();

        [Serializable]
        public class Person
        {
            public string fio;

            public string FIO
            {
                get { return fio; }
                set { fio = value; }
            }

            public Person()
            {
                fio = "";
            }

            public Person(string F)
            {
                fio = F;
            }
        }

        [Serializable]
        public class Credit : Person
        {
            public int summ, period;
            public string type;

            public int Summ
            {
                get { return summ; }
                set { if (value > 10000 && value < 1000000001) summ = value; else summ = 0; }
            }

            public string Type
            {
                get { return type; }
                set { type = value; }
            }

            public int Period
            {
                get { return period; }
                set { if (value > 0 && value < 121) period = value; else period = 0; }
            }

            public Credit()
            {
                summ = 0; type = ""; period = 0;
            }

            public Credit(string F, int S, string T, int P)
                : base(F)
            {
                summ = S; type = T; period = P;
            }
        }

        public Form1()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void AddRow()
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox1.Created == true)
            {
                Person p = new Person(textBox1.Text);
                Credit cr = new Credit(textBox1.Text, Convert.ToInt32(textBox2.Text), comboBox1.Text, Convert.ToInt32(textBox3.Text));
                personList.Add(p);
                creditList.Add(cr);

                AddArrToJagMas();

                count++;

                int j = viewData.Rows.Add();
                AddInfoToTable(textBox1.Text, Convert.ToInt32(textBox2.Text), comboBox1.Text, Convert.ToInt32(textBox3.Text), j);

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox1.SelectedIndex = 0;

                button1.Focus(); // кнопка добавить
            }
            else
            {
                MessageBox.Show("Остались незаполненные поля!");
            }
        }

        private void PutDataToTable()
        {
            viewData.Rows.Clear();
            foreach (Credit cr in creditList)
            {
                viewData.Rows.Add(cr.fio, cr.summ, cr.type, cr.period);
            }
            AddDataToMas();
        }

        private void AddArrToJagMas()
        {
            string[] crMas = new string[4] { textBox1.Text, textBox2.Text, comboBox1.Text, textBox3.Text };

            for (int j = 0; j < 4; j++)
            {
                mas[viewData.Rows.Count - 1, j] = crMas[j];
            }
            mas1[viewData.Rows.Count - 1] = mas[viewData.Rows.Count - 1, 3];
            mas0 = mas;
            greatMas = mas;
        }

        private void AddDataToMas()
        {
            int count = 0;
            mas = new string[100, 4];
            mas1 = new string[100];
            personList.Clear();

            foreach (Credit cr in creditList)
            {
                mas[count, 0] = cr.fio;
                mas[count, 1] = Convert.ToString(cr.summ);
                mas[count, 2] = cr.type;
                mas[count, 3] = Convert.ToString(cr.period);

                Person p = new Person(cr.fio);
                personList.Add(p);

                mas1[count] = mas[count, 3];
                count++;
            }
            mas0 = mas;
            greatMas = mas;
        }

        private void DeleteRow()
        {
            try
            {
                if (viewData.RowCount > 1 && viewData.RowCount > viewData.SelectedRows.Count && viewData.SelectedCells.ToString() != "")
                {
                    if (viewData.SelectedRows.ToString() != "")
                    {
                        foreach (DataGridViewCell oneCell in viewData.SelectedCells)
                        {
                            if (oneCell.Selected)
                            {
                                viewData.Rows.RemoveAt(oneCell.RowIndex);
                            }

                        }
                    }
                }


            }
            catch (InvalidOperationException)
            { }
        }

        private void ResetHighlight()
        {
            for (int i = 0; i < viewData.RowCount - 1; i++)
            {
                viewData.Rows[i].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void PutDataBack(DataGridViewCellEventArgs e)
        {
            viewData.Rows[viewData.RowCount - 1].Selected = false;

            for (int k = 0; k < 4; k++)
            {
                viewData.Rows[viewData.RowCount - 1].Cells[k].Selected = false;
            }

            int i = e.RowIndex;

            if (i >= 0)
            {
                if (i != viewData.RowCount - 1)
                {
                    textBox1.Text = viewData.Rows[i].Cells[0].Value.ToString();
                    textBox2.Text = viewData.Rows[i].Cells[1].Value.ToString();
                    textBox3.Text = viewData.Rows[i].Cells[3].Value.ToString();
                    comboBox1.Text = viewData.Rows[i].Cells[2].Value.ToString();
                    viewData.AllowUserToDeleteRows = true;

                    foreach (DataGridViewCell oneCell in viewData.SelectedCells)
                    {
                        if (oneCell.Selected == true)
                        {
                            viewData.Rows.RemoveAt(i);
                            creditList.RemoveAt(i);
                            personList.RemoveAt(i);
                            AddDataToMas();
                        }
                    }
                }
            }
            viewData.Rows[viewData.RowCount - 1].Cells[0].Selected = true;
        }

        private void FindByPeriod()
        {
            //try
            //{
            int countp = personList.Count;
            int countt = countp;
            mas = greatMas;
            mas0 = greatMas;
            mas2 = new int[100];

            for (int i = 0; i < personList.Count; i++)
            {
                mas2[i] = int.Parse(mas1[i]);
                mas3 = mas2;
            }

            int thisPeriod = 0;
            int indexOfTP = -1;

            if (countp > 0)
            {
                for (int i = 0; i < countt; i++)
                {
                    for (int j = i + 1; j < viewData.Rows.Count-1; j++)
                    {
                        if (String.Compare(greatMas[i, 0], greatMas[j, 0]) == 0)
                        {
                            int here = j;
                            mas3[i] += mas3[j];
                            mas3[j] = 0;
                            mas2[i] = mas3[i];

                            DeleteStringMas2(here, countp);
                            DeleteStringMas(here, ref countp);
                        }
                    }
                }

                for (int i = 0; i < personList.Count; i++)
                {
                    if (mas3[i] == Convert.ToInt32(textBox5.Text))
                    {
                        thisPeriod = mas3[i];
                        indexOfTP = i;
                    }
                }
                if (thisPeriod != 0 && indexOfTP != -1)
                {
                    MessageBox.Show("На выбранный срок кредит взят клиентом " + mas[indexOfTP, 0] + " \nСрок кредита составляет " + thisPeriod + " месяцев.");
                }
                else
                {
                    MessageBox.Show("На данный срок кредиты не выдавались.");
                }
            }
            else
            {
                MessageBox.Show("Список клиентов пуст.");
            }
            //}
            //catch
            //{
            //    MessageBox.Show("Ошибка");
            //}
        }

        private void DeleteStringMas(int here, ref int countp)
        {
            int n = 0;
            string[,] vs1 = new string[countp - 1, 4];
            mas = new string[countp,4];

            if (countp != personList.Count)
            {
                here -= (personList.Count - countp);
            }

            for (int m = 0; m < countp; m++)
            {
                if (m == here)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        mas[m, j] = null;
                    }
                    continue;
                }
                else
                {
                    for (int j = 0; j < 4; j++)
                    {
                        vs1[n, j] = mas0[m, j];
                        vs1[n, 3] = Convert.ToString(mas2[n]);
                        mas[n, j] = mas0[m, j];
                    }
                    n++;
                }
            }

            countp--;

            mas0 = new string[countp, 4];
            mas0 = vs1;
        }

        private void DeleteStringMas2(int here, int countp)
        {
            int n = 0;
            int[] vs2 = new int[countp - 1];

            if (countp != personList.Count)
            {
                here -= (personList.Count - countp);
            }

            for (int m = 0; m < countp; m++)
            {
                if (m == here)
                {
                    continue;
                }
                else
                {
                    vs2[n] = mas2[m];
                    n++;
                }
            }

            mas2 = vs2;
        }

        private void FindByFIO()
        {
            int indexOfFIO = -1;
            int countResults = 0;
            string fioSearch = textBox4.Text;

            for (int i = 0; i < personList.Count; i++)
            {
                SeparateFIO(ref indexOfFIO, fioSearch, ref countResults);
            }

            if (countResults == 0)
            {
                MessageBox.Show("Клиент не найден!");
            }
        }

        private void SeparateFIO(ref int indexOfFIO, string fioSearch, ref int countResults)
        {
            int check = 0;
            string[] sepWords = new string[personList.Count];

            for (int i = 0; i < personList.Count; i++)
            {
                sepWords[i] = greatMas[i, 0];
            }

            foreach (string word in sepWords)
            {
                string threeChars = word.Remove(3);

                if (fioSearch == threeChars)
                {
                    indexOfFIO = check;
                    HighlightFIO(indexOfFIO, ref countResults);
                }

                check++;
            }
        }

        private void HighlightFIO(int indexOfFIO, ref int countResults)
        {
            for (int i = 0; i < viewData.RowCount - 1; i++)
            {
                if (indexOfFIO == i)
                {
                    countResults++;
                    viewData.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                }
            }
        }
        private void AddInfoToTable(string F, int S, string T, int P, int i)
        {
            viewData.Rows[i].SetValues(F, S, T, P);
        }

        private void SaveToFile()
        {
            if (viewData.RowCount > 1)
            {
                SaveFileDialog saveFD = new SaveFileDialog();
                saveFD.Filter = "All file (*.*) | *.*| Text file |*.txt";

                if (saveFD.ShowDialog() == DialogResult.OK)
                {
                    string filename = saveFD.FileName;
                    using (FileStream f1 = new FileStream(filename, FileMode.Create))
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        bf.Serialize(f1, creditList);
                    }
                    MessageBox.Show("Файл сохранен");

                }
            }
        }

        private void GetDataFromFile()
        {
            OpenFileDialog openFD = new OpenFileDialog();

            // получаем выбранный файл
            if (openFD.ShowDialog() == DialogResult.Cancel)
                return;

            try
            {
                // читаем файл в строку
                string filename = openFD.FileName;

                // Включаем бинарное форматирование
                BinaryFormatter bf = new BinaryFormatter();
                using (FileStream f2 = new FileStream(filename, FileMode.Open))
                {
                    try
                    {
                        creditList = (List<Credit>)bf.Deserialize(f2);
                    }
                    catch
                    {
                        string[] text = File.ReadAllText(filename).Split(new char[] { ' ', '.', '\r', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                        if (text.Length != 0)
                        {
                            MessageBox.Show("Выбран файл неверного формата!");
                        }
                        else
                        {
                            File.WriteAllText(filename, "");
                            creditList.Clear();
                            PutDataToTable();
                        }
                    }
                }
                PutDataToTable();
            }
            catch (Exception)
            {
                MessageBox.Show("Возникла ошибка при чтении файла!");
            }
        }

        private bool FIO_Check(string F)
        {
            Regex rg = new Regex(@"^[А-Я][а-я]{1,} [А-Я]{1}[.]{1}[А-Я]{1}[.]{1}$");
            Match m = rg.Match(F);
            return m.Success;
        }

        private bool FIOSearch_Check(string F)
        {
            Regex rg = new Regex(@"^[А-Я][а-я]{1,2}$");
            Match m = rg.Match(F);
            return m.Success;
        }

        private bool Summ_Check(string S)
        {
            Regex rg = new Regex(@"^[0-9]{1,10}$");
            Match m = rg.Match(S);
            if (m.Success)
            {
                if (Convert.ToInt32(S) > 0 && Convert.ToInt32(S) < 1000000001) return true;
                else return false;
            }
            else return false;
        }

        private bool Period_Check(string P)
        {
            Regex rg = new Regex(@"^[0-9]{1,}$");
            Match m = rg.Match(P);

            if (m.Success)
            {
                if (Convert.ToInt32(P) > 0 && Convert.ToInt32(P) < 121) return true;
                else return false;
            }
            else return false;
        }

        private bool Type_Check(string T)
        {
            if (comboBox1.SelectedIndex != -1 && comboBox1.SelectedIndex != 0)
            {
                return true;
            }
            else return false;
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            AddRow();
        }

        private void TextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            FindByPeriod();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

        private void Button3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.SelectedIndex = 0;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            GetDataFromFile();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (viewData.RowCount == 0)
            {
                MessageBox.Show("Сначала введите данные в таблицу");
            }
            else
            {
                SaveToFile();
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ResetHighlight();
        }

        private void TextBox3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3.Clear();
        }

        private void ViewData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            viewData.Rows[viewData.RowCount - 1].Selected = false;

            for (int i = 0; i < 4; i++)
            {
                viewData.Rows[viewData.RowCount - 1].Cells[i].Selected = false;
            }
        }

        private void ViewData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PutDataBack(e);
        }

        private void TextBox4_MouseClick(object sender, MouseEventArgs e)
        {
            textBox4.Clear();
        }

        private void TextBox5_MouseClick(object sender, MouseEventArgs e)
        {
            textBox5.Clear();
        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == ' ' || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (FIO_Check(textBox1.Text) == false)
            {
                MessageBox.Show("Введите фамилию с большой буквы и инициалы через точки!");
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void TextBox2_Validating(object sender, CancelEventArgs e)
        {
            if (Summ_Check(textBox2.Text) == false)
            {
                MessageBox.Show("Ошибка!");
                textBox2.Clear();
                textBox2.Focus();
            }
        }

        private void TextBox3_Validating(object sender, CancelEventArgs e)
        {
            if (Period_Check(textBox3.Text) == false)
            {
                MessageBox.Show("Ошибка!");
                textBox3.Clear();
                textBox3.Focus();
            }
        }

        private void TextBox4_Validating(object sender, CancelEventArgs e)
        {
            if (FIOSearch_Check(textBox4.Text) == false)
            {
                MessageBox.Show("Введите первые 3 буквы фамилии!");
                textBox4.Clear();
                textBox4.Focus();
            }
        }

        private void TextBox5_Validating(object sender, CancelEventArgs e)
        {
            if (Period_Check(textBox5.Text) == false)
            {
                MessageBox.Show("Ошибка!");
                textBox5.Clear();
                textBox5.Focus();
            }
        }

        private void ComboBox1_Validating(object sender, CancelEventArgs e)
        {
            if (Type_Check(comboBox1.Text) == false)
            {
                MessageBox.Show("Ошибка!");
                comboBox1.SelectedIndex = 0;
                comboBox1.Focus();
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == ' ' || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ResetHighlight();
            FindByFIO();
        }
    }
}
