using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Display : Form
    {
        // таймеры для текущего времени, времени с момента отправления поезда,
        // бегущей строки и её скорости
        Timer timer = new Timer();
        Timer timerlast = new Timer();
        Timer timerad = new Timer();
        Timer timerline = new Timer();

        // строка для хранения рекламного сообщения
        string text = " ";

        // управление скоростью бегущей строки
        TimeController timeController = new TimeController(0, new List<string>());

        // сообщение в бешущей строке
        CreepingLine cLine = new CreepingLine("12345");

        // поля для вывода текущего времени 
        // и времени, с момента отправления последнего поезда
        DateTime timelast = new DateTime(0, 0);
        DateTime timenow = new DateTime(0, 0);

        // списки для хранения информации о расписании, поездах и конечных станций
        List<string> stations = new List<string>();
        List<string> trains = new List<string>();
        List<string[]> timetable = new List<string[]>();
        List<string> arrTime = new List<string>();
        List<string> depTime = new List<string>();
        Random random = new Random();

        // строка для подключения к базе данных
        string connectionString = @"Data Source=LAPTOP-LIRE0JUV; Initial Catalog=Metro_Board; Integrated Security=True";

        public void GetTrainsStations() // метод для загрузки поездов и их конечных станций
        {
            // запрос для получения номеров поездов и их конечных станций
            string sqlExpression = "SELECT st.CodeTrain, s.NameStation FROM StationTrain st INNER JOIN Station s ON s.CodeStation = st.CodeStation";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // подключение к базе
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                // условие, что запрос не пустой
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // получение номера поезда - первого столбца в выборке
                        string codeTrain = reader.GetValue(0).ToString();

                        // получение наименования станции - второго столбца в выборке
                        string nameStation = reader.GetValue(1).ToString();

                        // добавление  поезда и станции в список
                        stations.Add(nameStation);
                        trains.Add(codeTrain);
                    }
                }
                else MessageBox.Show("Выборка пустая");

                // закрытие подключения
                connection.Close();
                reader.Close();
            }
        }

        public void GetAd() // метод для загрузки рекламных сообщений
        {
            string sqlExpression2 = "SELECT Ad FROM Ad";
            using (SqlConnection connection2 = new SqlConnection(connectionString))
            {
                connection2.Open();
                SqlCommand command2 = new SqlCommand(sqlExpression2, connection2);
                SqlDataReader reader = command2.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string line = reader.GetValue(0).ToString();
                        timeController.Ad.Add("                                    " +
                            "                                              " + line);
                    }
                }
                connection2.Close();
                reader.Close();
            }
        }

        public void GetTimetable() // запрос на загрузку расписания движения поездов
        {
            string sqlExpression3 = "SELECT * FROM StationTrain";
            using (SqlConnection connection3 = new SqlConnection(connectionString))
            {
                connection3.Open();
                SqlCommand command3 = new SqlCommand(sqlExpression3, connection3);
                SqlDataReader reader = command3.ExecuteReader();
                if (reader.HasRows)
                {
                    string[] temp = new string[4];
                    while (reader.Read())
                    {
                        temp[0] = reader.GetValue(0).ToString();
                        temp[1] = reader.GetValue(1).ToString();
                        temp[2] = reader.GetValue(2).ToString();
                        temp[3] = reader.GetValue(3).ToString();
                        timetable.Add(temp);

                        // списки прибытия и отправления поездов
                        arrTime.Add(temp[2]);
                        depTime.Add(temp[3]);
                    }
                }
                connection3.Close();
                reader.Close();
            }
        }

        public Display()
        {
            // загрузка данных перед началом работы информационного табло
            GetAd();
            GetTrainsStations();
            GetTimetable();

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) // настройка таймеров при открытии формы
        {
            // настройка всех таймеров
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
            timerlast.Interval = 1000;
            timerlast.Tick += new EventHandler(timer2_Tick);
            timerad.Tick += new EventHandler(timer3_Tick);
            timerad.Start();
            timerline.Interval = 60;
            timerline.Tick += new EventHandler(timer4_Tick);
            timerline.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) // таймер для текущего времени
        {
            if (Data.change1)
            {
                timenow = timenow.AddHours(Data.d);
                timenow = timenow.AddMinutes(Data.h);
                timenow = timenow.AddSeconds(Data.m);
                timenow = timenow.AddSeconds(1);
                Data.d = 0;
                Data.h = 0;
                Data.m = 0;
                LabelTime.Text = timenow.ToString("hh:mm:ss");
                labelsincelast.Text = timelast.ToString("mm:ss");
            }
            else
            {
                timenow = timenow.AddSeconds(1);
                LabelTime.Text = timenow.ToString("hh:mm:ss");
                labelsincelast.Text = timelast.ToString("mm:ss");
            }

            // цикл для обработки прибытия и отправления поездов
            for (int i = 0; i < arrTime.Count; i++)
            {
                // если поезд прибыл
                if (LabelTime.Text == arrTime[i])
                {
                    // остановка таймера - обнуление таймера - вывод сообщения о прибывшем поезде
                    timerlast.Stop();
                    timelast = new DateTime(0, 0);
                    label3.Text = "Поезд №" + trains[i] + " Станция " + stations[i];
                }

                // если поезд отправился
                if (LabelTime.Text == depTime[i])
                {
                    // старт таймера - вывод сообщения об отправлении поезда
                    timerlast.Start();
                    label3.Text = "Поезд №" + trains[i] + " отъехал";
                }
            }
        }

        // таймер для учета времени, прошедшего с момента отправления последнего поезда
        private void timer2_Tick(object sender, EventArgs e) 
        {
            // обновление таймера с момента отправления последнего поезда
            timelast = timelast.AddSeconds(1);
        }

        private void timer3_Tick(object sender, EventArgs e) // таймер для скорости вывода сообщений на бегущую строку
        {
            // настройка таймера для бегущей строки
            timerad.Interval = cLine.AdMessage.Length * 65;

            // выбор рекламного сообщения для вывода на бегущую строку
            cLine.AdMessage = timeController.Ad[++timeController.CurrentStringNumber % timeController.Ad.Count];
            text = cLine.AdMessage;
        }

        private void timer4_Tick(object sender, EventArgs e) // таймер для скорости вывода символов на бегущую строку
        {
            // вывод сообщения на бегущую строку
            text = text.Substring(1) + " ";
            textBox3.Text = text;
        }
    }
}
