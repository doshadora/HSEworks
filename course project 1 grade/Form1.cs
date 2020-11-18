using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace course_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class InfoAboutConnection
        {
            public int Number { get; set; }         // Номер группы.
            public string Term1 { get; set; }       // Термин 1.
            public string Connection { get; set; }  // Тип связи.
            public string Term2 { get; set; }       // Термин 2.
        }

        public class Group
        {
            public List<string> GroupTermList { get; set; } // Термины в группе.
        }

        // Список информации о связях.
        public List<InfoAboutConnection> dataList = new List<InfoAboutConnection>();

        // Список терминов.
        public List<string> termList = new List<string>();

        // Список групп.
        public List<List<string>> groups = new List<List<string>>();

        // Счётчик групп.
        public int Number = 0;


        // Метод для загрузки информации из файла.
        private void GetDataFromFile()
        {
            OpenFileDialog fileDlg = new OpenFileDialog();   // Открывает файловый диалог.

            fileDlg.FileName = "Document";                   // Имя сохраняемого документа.
            fileDlg.DefaultExt = ".txt";                     // Расширение сохраняемого документа.
            fileDlg.Filter = "Text documents (.txt)|*.txt";  // Фильтр файлов для вывода.

            if (fileDlg.ShowDialog() == DialogResult.Cancel)
                return;

            // Обрабатывает выбранные настройки.
            try
            {
                // Открывает документ.
                string filename = fileDlg.FileName;

                StreamReader fileReader = new StreamReader(filename);

                string text = fileReader.ReadToEnd();         // Считывает содержимое файла.

                string[] lines = Regex.Split(text, "\n");     // Получает строки из файла.

                text = "";


                // Проходит по всем строкам текста.
                for (int i = 0; i < lines.Length; i++)
                {
                    lines[i] = Regex.Split(lines[i], "//")[0];        // Удаляет комментарии из строки.
                    string[] subTest = Regex.Split(lines[i], "-");    // Разделяет на три слова(термин, связь, термин).

                    text += lines[i] + "\n";
                }

                richTextBox1.Text = text;   // Выводит содержимое файла в richtextbox.
            }
            catch (Exception)
            {
                MessageBox.Show("Возникла ошибка при чтении файла!");
            }
        }

        public void ProcessText()
        {
            dataList.Clear();   // Очищает список объектов.
            Number = 0;         // Обнуляет счётчик групп.
            termList.Clear();   // Очищает список всех терминов.
            groups.Clear();     // Очищает список групп.


            string pattern = @"\s*#";      // Паттерн для регулярного выражения.

            string[] lines = Regex.Split(richTextBox1.Text, "\n");

            // Каждую строчку в загруженном тексте разбивает на элементы,
            // превращает в объект типа InfoAboutConnection,
            // записывает в dataList.
            // Добавляет термины в termList для дальнейшего подсчёта
            // количества терминов в группе.
            for (int i = 0; i < lines.Length - 1; i++)
            {
                string[] fields = Regex.Split(lines[i], pattern);   // Разделяет строку на элементы.

                // Если в строке меньше 3 элементов, пропускает.
                if (fields.Length < 3)
                {
                    continue;
                }

                // Формирует список всех терминов.
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0 || j == 2)
                    {
                        fields[j] = fields[j].Replace(" ", "");
                        termList.Add(fields[j]);
                    }
                }

                // Удаляет повторяющиеся элементы в списке.
                DeleteSame(ref termList);

                termList.Sort();

                InfoAboutConnection info = new InfoAboutConnection();      // Объект с информацией о связи.

                // Записывает в таблицу и удаляет пробелы.
                info.Term1 = fields[0].Trim();
                info.Connection = fields[1];
                info.Term2 = fields[2].Trim();
                CheckList(info);
                info.Number = Number;

                // Добавляет объект в список.
                dataList.Add(info);
            }

            // Обновляет содержимое таблицы.
            PutDataToTable();

            MakeTermList();
        }


        // Метод для проверки на наличие связи в существующем списке.
        private void CheckList(InfoAboutConnection inf)
        {
            bool check = false;

            // Проверяет каждый существующий элемент на наличие связи.
            for (int i = 0; i < dataList.Count; i++)
            {
                if (dataList[i].Term1 == inf.Term1 || dataList[i].Term1 == inf.Term2 || dataList[i].Term2 == inf.Term1 || dataList[i].Term2 == inf.Term2)
                {
                    check = true;
                }
            }

            if (!check)
            {
                // Если не находит, то инкрементирует Number.
                Number++;
            }
        }

        // Метод для добавления данных в таблицу.
        private void PutDataToTable()
        {
            dataGridView1.Rows.Clear();

            foreach (InfoAboutConnection elem in dataList)
            {
                dataGridView1.Rows.Add(elem.Number, elem.Term1, elem.Connection, elem.Term2);
            }
        }

        // Метод для удаления одинаковых элементов в списке.
        private void DeleteSame(ref List<string> termList)
        {
            List<string> tempList = new List<string>();

            int count = 0;

            for (int i = 0; i < termList.Count; i++)
            {
                bool duplicatefound = false;

                for (int j = i + 1; j < termList.Count; j++)
                {
                    if (termList[i] == termList[j])
                    {
                        duplicatefound = true;
                    }
                }

                if (!duplicatefound)
                    tempList.Add(termList[i]);
                count++;
            }

            termList.Clear();

            foreach (string elem in tempList)
            {
                termList.Add(elem);
            }
        }

        // Метод для составления списка групп.
        private void MakeTermList()
        {
            string text = null;
            double average = 0;

            for (int num = 1; num <= Number; num++)
            {
                List<string> groupedTerms = new List<string>();

                for (int i = 0; i < termList.Count; i++)
                {
                    for (int j = 0; j < dataList.Count; j++)
                    {
                        if ((termList[i] == dataList[j].Term1 || termList[i] == dataList[j].Term2) && num == dataList[j].Number)
                        {
                            groupedTerms.Add(dataList[j].Term1.ToString());
                            groupedTerms.Add(dataList[j].Term2.ToString());
                        }
                    }
                }

                Group g = new Group();
                DeleteSame(ref groupedTerms);
                g.GroupTermList = groupedTerms;
                groups.Add(g.GroupTermList);
                PrintToBox(ref text, ref average, num, g.GroupTermList);
            }

            average /= groups.Count;
            text += "Среднее количество терминов в группе: " + average;

            richTextBox2.Text = text;
        }

        private void PrintToBox(ref string text, ref double average, int num, List<string> GroupTermList)
        {
            text += num + ") ";

            for (int i = 0; i < GroupTermList.Count; i++)
            {
                text += GroupTermList[i];

                if (i == GroupTermList.Count - 1) text += ".\n" + "Кол-во терминов: " + GroupTermList.Count + "\n";
                else text += ", ";
            }

            average += GroupTermList.Count;
            text += "\n";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = true;
            button1.Visible = false;
            button2.Visible = true;
            button4.Visible = false;
            button2.Focus();
            richTextBox1.Visible = true;

            GetDataFromFile();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;
            button2.Enabled = false;
            button5.Visible = true;
            button5.Focus();
            dataGridView1.Visible = true;
            richTextBox2.Visible = true;

            ProcessText();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            button1.Visible = true;
            button2.Visible = false;
            button2.Enabled = true;
            button4.Visible = true;
            button4.Focus();
            button5.Visible = false;
            dataGridView1.Visible = false;
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
        }
    }
}
