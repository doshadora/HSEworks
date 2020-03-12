using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace _8LabTask
{
    [Serializable]

    class Person
    {
        public string fio, type;
        public int summ, period;

        public string FIO
        {
            get { return fio; }
            set { fio = value; }
        }

        public Person(string F)
        {
            fio = F;
        }
    }

    [Serializable]
    class Credit : Person
    {
        public int Summ
        {
            get { return summ; }
            set { if (value > 0 && value < 1000000001) summ = value; else summ = 0; }
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

        public Credit(string F)
            : base(F)
        {
            summ = 0; period = 0; type = "";
        }
        public Credit(string F, int S, string T, int P)
            : base(F)
        {
            summ = S; type = T; period = P;
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddRow()
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox1.Created == true)
            {
                int j = dataGridView1.Rows.Add();
                AddInfoToTable(textBox1.Text, Convert.ToInt32(textBox2.Text), comboBox1.Text, Convert.ToInt32(textBox3.Text), j);

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

                button1.Focus(); // кнопка добавить
            }
            else
            {
                MessageBox.Show("Остались незаполненные поля!");
            }
        }

        private void AddInfoToTable(string F, int S, string T, int P, int i)
        {
            dataGridView1.Rows[i].SetValues(F, S, T, P);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Credit p1 = new Credit(textBox1.Text, textBox2.Text, comboBox1.Text, textBox3.Text) ;
            AddRow();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ComboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
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

        private bool FIO_Check(string F)
        {
            Regex rg = new Regex(@"^[А-Я][а-я]{1,} [А-Я]{1}[.]{1}[А-Я]{1}[.]{1}$");
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
        private bool Period_Check(int P)
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
            Regex rg = new Regex(@"^[А-Я][а-я]{1,} [А-Я]{1}[.]{1}[А-Я]{1}[.]{1}$");
            Match m = rg.Match(T);
            return m.Success;
        }

        private void TextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (FIO_Check(textBox1.Text) == true) fio = textBox1.Text;
            else
            {
                MessageBox.Show("Ошибка!");
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void TextBox2_Validating(object sender, CancelEventArgs e)
        {
            if (Summ_Check(textBox2.Text) == true) S = Convert.ToInt32(textBox1.Text);
            else
            {
                MessageBox.Show("Ошибка!");
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void TextBox3_Validating(object sender, CancelEventArgs e)
        {
            if (Period_Check(textBox3.Text) == true) P = Convert.ToInt32(textBox3.Text);
            else
            {
                MessageBox.Show("Ошибка!");
                textBox3.Clear();
                textBox3.Focus();
            }
        }
    }
}
