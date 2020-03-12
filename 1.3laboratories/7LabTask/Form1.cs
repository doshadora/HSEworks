using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7LabTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) // одномерный массив
        {
            Form2 arrayform = new Form2();
            arrayform.Show();
        }

        private void Button2_Click(object sender, EventArgs e) // двумерный массив
        {
            Form3 matrform = new Form3();
            matrform.Show();
        }

        private void Button3_Click(object sender, EventArgs e) // рваный массив
        {
            Form4 jaggedform = new Form4();
            jaggedform.Show();
        }

        private void Button4_Click(object sender, EventArgs e) // назад
        {
            this.Close();
        }
    }
}
