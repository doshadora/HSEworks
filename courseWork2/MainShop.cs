using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace courseWork2
{
    public partial class MainShop : Form
    {
        bool loginChanged = false, pwChanged = false, infoChanged = false, nameChanged = false, logoChanged = false, logoDeleted = false;
        bool equal, exist;
        public static string tempLogin = "", tempPassword = "";
        int i = 0;

        public static string storeInfo = "";
        public static byte[] byteStoreLogo;
        public static Image storeLogo;
        public static List<string> storeAddress = new List<string>();

        public MainShop()
        {
            InitializeComponent();
            mainPicStore.Image = Image.FromFile("ЗаставкаMain.jpg");
            labelStore.Text = SignIn.userName.ToUpper();

            GetAllUserInfo();

            if (storeInfo == null || storeLogo == null)
            {
                MessageBox.Show("Перейдите в раздел редактирования аккаунта и заполните все данные о магазине!");
                ordersButton.Enabled = false;
                statsButton.Enabled = false;
                catalogueButton.Enabled = false;
            }
        }

        private void MainShop_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clothes_storeDataSet1.city". При необходимости она может быть перемещена или удалена.
            this.cityTableAdapter.Fill(this.clothes_storeDataSet1.city);
        }

        #region Функции

        public void HideAll()
        {
            ordersButton.Visible = false;
            statsButton.Visible = false;
            editStoreButton.Visible = false;
            catalogueButton.Visible = false;
            mainPicStore.Visible = false;
            backToMainButton.Visible = true;
            editLogGroup.Visible = false;
        }

        public static bool IfLoginPW(bool equall, string login)
        {
            // запрос для проверки на соответствие старого логина и пароля
            string sqlExpression = "SELECT store_code AS phone, store_password as pw FROM store WHERE store_code = '"
                + login + "' AND store_password = '" + tempPassword + "'";

            using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
            {
                // подключение к базе-
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                // условие, что запрос не пустой
                if (reader.HasRows)
                {
                    equall = true;
                }
                else
                {
                    equall = false;
                }

                // закрытие подключения
                connection.Close();
                reader.Close();
            }

            return equall;
        }

        public void GetAllUserInfo()
        {
            // запрос для получения информации о магазине и его логотипа
            string sqlExpression = "SELECT store_info, store_logo FROM store WHERE store_id = '"
                + SignIn.userID + "' AND (store_info IS NOT NULL OR store_logo IS NOT NULL)";

            using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
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
                        if (!reader.IsDBNull(0))
                            storeInfo = reader.GetValue(0).ToString();

                        if (!reader.IsDBNull(1))
                        {
                            byteStoreLogo = (byte[])reader.GetValue(1);
                            storeLogo = ByteArrayToImage(byteStoreLogo);

                            logoPic.Image = storeLogo;

                            logoPreview.Image = storeLogo;
                            logoPreviewLabel.Visible = false;
                        }
                    }
                }
                // закрытие подключения
                connection.Close();
                reader.Close();
            }
        }

        public static Byte[] UploadPicture(byte[] pic)
        {
            OpenFileDialog openDialog = new OpenFileDialog();  // создание диалогового окна для выбора файла
            openDialog.Filter = "Image files (*.jpg)|*.jpg";   // формат загружаемого файла

            if (openDialog.ShowDialog() == DialogResult.OK)    // если в окне была нажата кнопка "ОК"
            {
                try
                {
                    pic = File.ReadAllBytes(openDialog.FileName);
                }
                catch
                {
                    DialogResult result = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return pic;
        }

        public static Image ByteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }

        #endregion
        #region Редактирование параметров входа в аккаунт

        private void GoToLogEditButton_Click(object sender, EventArgs e)
        {
            editLogGroup.Visible = true;
            editAccountGroup.Visible = false;

            i = 0;

            tbEditPhone.Text = SignIn.userLogin.Substring(3);
            tbOldPassword.Text = "";
            tbNewPassword.Text = "";
            tbEditPhone.Enabled = true;
            tbOldPassword.Enabled = true;
            tbNewPassword.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
        }

        private void TbEditPhone_Click(object sender, EventArgs e)
        {
            tbOldPassword.Enabled = false;
            tbNewPassword.Enabled = false;
            button1.Visible = true;
            button2.Visible = false;
        }

        private void TbEditPhone_Leave(object sender, EventArgs e)
        {
            tempLogin = SignIn.userLogin;

            if (tbEditPhone.Text.Length != 7)
            {
                MessageBox.Show("Неверно введен номер!");
            }
            else if ("000" + tbEditPhone.Text != SignIn.userLogin)
            {
                SignIn.userLogin = "000" + tbEditPhone.Text;

                exist = SignIn.IfLoginExists(exist);

                if (exist)
                {
                    MessageBox.Show("Под данным номером уже зарегистрирован аккаунт, попробуйте другой номер!");
                    tbOldPassword.Enabled = true;
                    loginChanged = false;
                    SignIn.userLogin = tempLogin;
                    button1.Visible = false;
                }
                else
                {
                    tbOldPassword.Enabled = true;
                    loginChanged = true;
                }
            }
            else
            {
                tbOldPassword.Enabled = true;
                button1.Visible = false;
                loginChanged = false;
            }
        }

        private void TbOldPassword_Click(object sender, EventArgs e)
        {
            tbEditPhone.Enabled = false;
            tbNewPassword.Enabled = false;
            button1.Visible = false;
            button2.Visible = true;
        }

        private void TbOldPassword_Leave(object sender, EventArgs e)
        {
            tempPassword = tbOldPassword.Text;

            if (loginChanged)
                equal = IfLoginPW(equal, tempLogin);
            else
                equal = IfLoginPW(equal, SignIn.userLogin);

            if (equal == false && i != 2)
            {
                MessageBox.Show("Неверный пароль! Попробуйте еще раз.");
                i++;
                tbOldPassword.Focus();
            }
            else if (i == 2)
            {
                MessageBox.Show("Попробуйте повторить попытку позже.");
            }
            else
            {
                i = 0;
                tbNewPassword.Enabled = true;
            }
        }

        private void TbNewPassword_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;

            tbEditPhone.Enabled = true;
        }

        private void TbNewPassword_Leave(object sender, EventArgs e)
        {
            if (tbNewPassword.Text == tbOldPassword.Text || tbNewPassword.Text == "")
            {
                pwChanged = false;

                button1.Visible = false;
                button2.Visible = false;

                tbEditPhone.Enabled = true;
                tbOldPassword.Enabled = true;
                tbNewPassword.Enabled = false;

                tbOldPassword.Text = "";
                tbNewPassword.Text = "";
            }
            else pwChanged = true;
        }

        private void SaveLogButton_Click(object sender, EventArgs e)
        {
            string newPW = tbNewPassword.Text;

            if (loginChanged && pwChanged)
            {
                // запрос для изменения логина и пароля
                string sqlExpression = "UPDATE store SET store_code = '" + SignIn.userLogin + "' WHERE store_code = '" + tempLogin + "';" +
                                       "UPDATE store SET store_password = '" + newPW + "' WHERE store_code = '" + SignIn.userLogin + "'";

                using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
                {
                    // подключение к базе
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    int num = command.ExecuteNonQuery() - 1;

                    if (num != 0)
                        MessageBox.Show("Логин и пароль изменены в " + num + " записи.");
                    else
                        MessageBox.Show("Изменения не были произведены.");

                    button1.Visible = false;
                    button2.Visible = false;

                    tbEditPhone.Enabled = true;
                    tbOldPassword.Enabled = true;
                    tbNewPassword.Enabled = false;

                    tbOldPassword.Text = "";
                    tbNewPassword.Text = "";

                    connection.Close();
                }
            }
            else if (loginChanged)
            {
                // запрос для изменения логина
                string sqlExpression = "UPDATE store SET store_code = '" + SignIn.userLogin + "' WHERE store_code = '" + tempLogin + "'";

                using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
                {
                    // подключение к базе
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    int num = command.ExecuteNonQuery();

                    if (num != 0)
                        MessageBox.Show("Логин изменён в " + num + " записи.");
                    else
                        MessageBox.Show("Изменения не были произведены.");

                    button1.Visible = false;
                    button2.Visible = false;

                    tbEditPhone.Enabled = true;
                    tbOldPassword.Enabled = true;
                    tbNewPassword.Enabled = false;

                    tbOldPassword.Text = "";
                    tbNewPassword.Text = "";

                    connection.Close();
                }
            }
            else if (pwChanged)
            {
                // запрос для изменения пароля
                string sqlExpression = "UPDATE store SET store_password = '" + newPW + "' WHERE store_code = '" + SignIn.userLogin + "'";

                using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
                {
                    // подключение к базе
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    int num = command.ExecuteNonQuery();

                    if (num != 0)
                        MessageBox.Show("Пароль изменён в " + num + " записи.");
                    else
                        MessageBox.Show("Изменения не были произведены.");

                    button1.Visible = false;
                    button2.Visible = false;

                    tbEditPhone.Enabled = true;
                    tbOldPassword.Enabled = true;
                    tbNewPassword.Enabled = false;

                    tbOldPassword.Text = "";
                    tbNewPassword.Text = "";

                    connection.Close();
                }
            }
            else MessageBox.Show("Изменения не были произведены");
        }

        #endregion
        #region Редактирование информации о магазине

        private void EditStoreButton_Click(object sender, EventArgs e)
        {
            groupName.Text = "Редактирование аккаунта";
            HideAll();

            goToLogEditButton.Visible = true;
            goToProfileEditButton.Visible = true;
        }

        private void GoToProfileEditButton_Click(object sender, EventArgs e)
        {
            GetAllUserInfo();
            editLogGroup.Visible = false;
            editAccountGroup.Visible = true;

            tbStoreName.Text = SignIn.userName;
            tbStoreInfo.Text = storeInfo;
        }

        private void TbStoreName_Click(object sender, EventArgs e)
        {
            tbStoreName.Text = "";
        }

        private void UploadLogoButton_Click(object sender, EventArgs e)
        {
            byteStoreLogo = UploadPicture(byteStoreLogo);

            logoPreview.Image = ByteArrayToImage(byteStoreLogo);
            logoPreview.Invalidate();

            logoPreviewLabel.Visible = false;
            logoDeleted = false;
        }

        private void OpenAddressButton_Click(object sender, EventArgs e)
        {
            AddressForm AddressForm = new AddressForm();
            AddressForm.Show();
        }

        private void StatsButton_Click(object sender, EventArgs e)
        {
            Statistics Statistics = new Statistics();
            Statistics.Show();
        }

        private void DeleteLogoPreviewButton_Click(object sender, EventArgs e)
        {
            logoPreview.Image = null;
            logoPreviewLabel.Visible = true;

            byteStoreLogo = null;
            logoDeleted = true;
        }

        private void SaveAccChangesButton_Click(object sender, EventArgs e)
        {
            if (tbStoreInfo.Text != "" && tbStoreName.Text != "" && logoPreview.Image != null)
            {
                // информация о магазине
                if (tbStoreInfo.Text != "" && tbStoreInfo.Text != storeInfo)
                {
                    // запрос для изменения логина и пароля
                    string sqlExpression = "UPDATE store SET store_info = '" + tbStoreInfo.Text + "' WHERE store_id = '" + SignIn.userID + "'";

                    using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
                    {
                        // подключение к базе
                        connection.Open();
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        int num = command.ExecuteNonQuery();
                        connection.Close();
                    }

                    storeInfo = tbStoreInfo.Text;
                    infoChanged = true;
                }

                // название магазина
                if (tbStoreName.Text != "" && tbStoreName.Text != SignIn.userName)
                {
                    // запрос для изменения логина и пароля
                    string sqlExpression = "UPDATE store SET store_name = '" + tbStoreName.Text + "' WHERE store_id = '" + SignIn.userID + "'";

                    using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
                    {
                        // подключение к базе
                        connection.Open();
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                    }

                    SignIn.userName = tbStoreName.Text;
                    labelStore.Text = SignIn.userName.ToUpper();

                    nameChanged = true;
                }

                // логотип магазина
                if (logoPreview.Image != storeLogo)
                {
                    string sqlExpression = "";

                    // запрос для изменения логотипа магазина
                    if (!logoDeleted)
                    {
                        sqlExpression = "UPDATE store SET store_logo = @byteStoreLogo WHERE store_id = '" + SignIn.userID + "'";
                        storeLogo = logoPreview.Image;
                    }
                    else
                    {
                        sqlExpression = "UPDATE store SET store_logo = NULL WHERE store_id = '" + SignIn.userID + "'";
                        storeLogo = null;
                    }

                    SqlConnection connection = new SqlConnection(SignIn.connectionString);

                    try
                    {
                        // подключение к базе
                        connection.Open();
                        SqlCommand command = new SqlCommand(sqlExpression, connection);

                        if (!logoDeleted)
                            command.Parameters.Add("@byteStoreLogo", SqlDbType.Image, byteStoreLogo.Length).Value = byteStoreLogo;

                        command.ExecuteNonQuery();
                        connection.Close();

                        logoChanged = true;

                        logoPic.Image = storeLogo;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }

                if (nameChanged && infoChanged && logoChanged)
                {
                    MessageBox.Show("Название магазина, его описание и логотип изменены");
                }
                else
                {
                    if (nameChanged && infoChanged)
                    {
                        MessageBox.Show("Название магазина и его описание изменены");
                    }
                    else if (nameChanged && logoChanged)
                    {
                        MessageBox.Show("Название магазина и логотип изменены");
                    }
                    else if (logoChanged && infoChanged)
                    {
                        MessageBox.Show("Описание магазина и логотип изменены");
                    }
                    else
                    {
                        if (nameChanged)
                        {
                            MessageBox.Show("Название магазина изменено");
                        }
                        else if (infoChanged)
                        {
                            MessageBox.Show("Описание магазина изменено");
                        }
                        else if (logoChanged)
                        {
                            MessageBox.Show("Логотип магазина изменен");
                        }
                        else MessageBox.Show("Изменения не были произведены");
                    }
                }

                ordersButton.Enabled = true;
                statsButton.Enabled = true;
                catalogueButton.Enabled = true;
            }
            else MessageBox.Show("Заполните все поля");
        }

        private void TbStoreName_Leave(object sender, EventArgs e)
        {
            if (tbStoreName.Text == "")
            {
                tbStoreName.Text = SignIn.userName;
            }
        }

        #endregion
        #region Просмотр текущих заказов

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            OrderStatus OrderStatus = new OrderStatus();
            OrderStatus.Show();
        }

        #endregion
        #region Просмотр каталога магазина

        private void CatalogueButton_Click(object sender, EventArgs e)
        {
            Catalogue Catalogue = new Catalogue();
            Catalogue.Show();

        }

        #endregion

        private void BackToMainButton_Click(object sender, EventArgs e)
        {
            ordersButton.Visible = true;
            statsButton.Visible = true;
            editStoreButton.Visible = true;
            catalogueButton.Visible = true;
            mainPicStore.Visible = true;
            backToMainButton.Visible = false;
            goToLogEditButton.Visible = false;
            goToProfileEditButton.Visible = false;
            editLogGroup.Visible = false;
            editAccountGroup.Visible = false;

            groupName.Text = "Главное меню";
        }
    }
}
