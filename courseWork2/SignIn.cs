using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace courseWork2
{
    public partial class SignIn : Form
    {
        // строка для подключения к базе данных
        public static string connectionString = @"Data Source=LAPTOP-LIRE0JUV; Initial Catalog=clothes_store; Integrated Security=True";

        string checkRole;
        bool exists;

        public static int userID = 0;
        public static string userName = "";
        public static string userLogin = "";
        public static string userPW = "";

        public SignIn()
        {
            InitializeComponent();
            this.Height = 200; // изменение размера формы  
        }

        #region Функции

        public static int GetLastId(string role)
        {
            int id = 0;
            string sqlExpression = "";

            if (role == "Покупатель")
            {
                sqlExpression = "SELECT TOP 1 cust_id FROM customer ORDER BY cust_id DESC";
            }
            else if (role == "Продавец")
            {
                sqlExpression = "SELECT TOP 1 store_id FROM store ORDER BY store_id DESC";
            }

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
                        id = Convert.ToInt32(reader.GetValue(0));
                    }
                }
                else
                {
                    id = 0;
                }
            }

            return id + 1;
        }

        public static bool IfLoginExists(bool exists)
        {
            // запрос для проверки на существование введённого логина
            string sqlExpression = "SELECT cust_phone AS phone FROM customer WHERE cust_phone = '"
                + userLogin + "' UNION ALL SELECT store_code AS phone FROM store WHERE store_code = '"
                + userLogin + "'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // подключение к базе
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                // условие, что запрос не пустой
                if (reader.HasRows)
                {
                    exists = true;
                }
                else
                {
                    exists = false;
                }
                // закрытие подключения
                connection.Close();
                reader.Close();
            }

            return exists;
        }

        #endregion
        #region Вход в аккаунт

        private void TbPasswordLog_Click(object sender, EventArgs e)
        {
            if (tbPasswordLog.Text == "Пароль")
                tbPasswordLog.Clear();
        }

        private void TbFIO_Click(object sender, EventArgs e)
        {
            if (tbFIO.Text == "ФИО")
                tbFIO.Clear();
        }

        private void TbPassword_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Пароль")
                tbPassword.Clear();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (tbPhoneLog.Text.Length == 0)
            {
                MessageBox.Show("Введите номер телефона!");
            }
            else if (tbPasswordLog.Text.Length == 0 || tbPasswordLog.Text == "Пароль")
            {
                MessageBox.Show("Введите пароль!");
            }
            else
            {
                userLogin = tbPhoneLog.Text;
                userPW = tbPasswordLog.Text;

                // запрос для поиска логина и пароля пользователя
                string sqlExpression = "SELECT cust_id, cust_phone AS phone, cust_password AS pw, " +
                    "cust_role AS role, cust_name AS name FROM customer WHERE cust_phone = '"
                    + userLogin + "' AND cust_password = '" + userPW + "' UNION ALL SELECT store_id, " +
                    "store_code AS phone, store_password AS pw, store_role AS role, store_name AS name" +
                    " FROM store WHERE store_code = '" + userLogin + "' AND store_password = '" + userPW + "'";
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
                            string role = reader.GetValue(3).ToString();
                            userName = reader.GetValue(4).ToString();

                            userID = Convert.ToInt32(reader.GetValue(0));

                            if (role == "Продавец")
                            {
                                MessageBox.Show("Вы вошли в свой аккаунт, " + userName);

                                MainShop MainShop = new MainShop();
                                MainShop.Show();
                            }
                            else if (role == "Покупатель")
                            {
                                MessageBox.Show("Вы вошли в свой аккаунт, " + userName);

                                MainCust MainCust = new MainCust();
                                MainCust.Show();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль.");
                        this.Height = 200; // изменение размера формы                        
                        tbGoToSignIn.Visible = true;
                    }
                    // закрытие подключения
                    connection.Close();
                    reader.Close();
                }
            }
        }

        private void TbGoToSignIn_Click(object sender, EventArgs e)
        {
            tbPhoneLog.Visible = false;
            tbPasswordLog.Visible = false;
            logInButton.Visible = false;
            tbGoToSignIn.Visible = false;
            tbFIO.Visible = true;
            tbPhone.Visible = true;
            tbPassword.Visible = true;
            signInButton.Visible = true;

            labelLogIn.Text = "Регистрация";

            this.Height = 210; // изменение размера формы  

            tbPhone.Text = userLogin;
            tbPassword.Text = userPW;
        }

        #endregion
        #region Регистрация

        private void TbBackToLog_Click(object sender, EventArgs e)
        {
            tbBackToLog.Visible = false;
            this.Close();

            tbPhoneLog.Visible = true;
            tbPasswordLog.Visible = true;
            logInButton.Visible = true;
            tbGoToSignIn.Visible = false;
            tbFIO.Visible = false;
            tbPhone.Visible = false;
            tbPassword.Visible = false;
            signInButton.Visible = false;

            labelLogIn.Text = "Войти в аккаунт";

            this.Height = 190; // изменение размера формы  

            tbPhoneLog.Text = tbPhone.Text;
            tbPasswordLog.Text = tbPassword.Text;
        }


        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (tbPhone.Text.Length != 10)
            {
                MessageBox.Show("Номер введен неверно!");
            }
            else if (tbPassword.Text.Length == 0 || tbPassword.Text == "Пароль")
            {
                MessageBox.Show("Введите пароль!");
            }
            else if (tbFIO.Text.Length == 0 || tbFIO.Text == "ФИО")
            {
                MessageBox.Show("Введите ФИО!");
            }
            else
            {
                userName = tbFIO.Text;
                userLogin = tbPhone.Text;
                userPW = tbPassword.Text;

                exists = IfLoginExists(exists);

                if (exists)
                {
                    MessageBox.Show("Аккаунт с данным логином уже существует! Введите другой логин или войдите в старый аккаунт.");

                    this.Height = 260; // изменение размера формы  
                    tbBackToLog.Visible = true;
                    tbPhone.Text = "";
                }
                else
                {
                    checkRole = userLogin.Substring(0, 3);

                    if (checkRole == "000") // проверка роли Продавец
                    {
                        int id = GetLastId("Продавец"); // поиск последнего идентификатора в таблице

                        // запрос для ввода данных о продавце в бд
                        string sqlExpression1 = "INSERT INTO store (store_id, store_name, store_code, " +
                            "store_password, store_role) VALUES ('" + id + "', '" + userName + "', '"
                            + userLogin + "', '" + userPW + "', 'Продавец')";

                        for (int i = 0; i < 2; i++)
                        {
                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                connection.Open();
                                SqlCommand command = new SqlCommand(sqlExpression1, connection);
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }

                            sqlExpression1 = "INSERT INTO store_address (store_id) VALUES ('" + id + "')";
                        }

                    }
                    else // проверка роли Покупатель
                    {
                        int id = GetLastId("Покупатель"); // поиск последнего идентификатора в таблице

                        // запрос для ввода данных о покупателе в бд
                        string sqlExpression1 = "INSERT INTO customer (cust_id, cust_name, cust_phone," +
                            " cust_password, cust_role) VALUES ('" + id + "', '" + userName + "', '"
                            + userLogin + "', '" + userPW + "', 'Покупатель')";
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand(sqlExpression1, connection);
                            try
                            {
                                command.ExecuteNonQuery();
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                    }

                    MessageBox.Show("Ваш аккаунт зарегистрирован");

                    tbPhoneLog.Visible = true;
                    tbPasswordLog.Visible = true;
                    logInButton.Visible = true;
                    tbGoToSignIn.Visible = false;
                    tbFIO.Visible = false;
                    tbPhone.Visible = false;
                    tbPassword.Visible = false;
                    signInButton.Visible = false;
                    tbBackToLog.Visible = false;

                    labelLogIn.Text = "Войти в аккаунт";

                    this.Height = 190; // изменение размера формы  
                    tbPhoneLog.Text = userLogin;
                    tbPasswordLog.Text = userPW;
                }
            }
        }

        #endregion
    }
}
