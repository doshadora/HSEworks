using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace courseWork2
{
    public partial class OrderStatus : Form
    {
        string[,] address;
        string[,] status;
        bool duplicate = false;

        string[,] infoGrid;
        string[] columnNames;

        string sqlExpression;

        int option;
        int select;
        string insertStatus;
        List<int> displayed = new List<int>();

        public OrderStatus()
        {
            InitializeComponent();

            FilterOpened();
            GetStoreCitiesIntoCBox();
            GetStatusIntoCBox();

            tbChooseCity.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbChooseCity.AutoCompleteSource = AutoCompleteSource.ListItems;

            tbChooseStat.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbChooseStat.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        #region Функции

        public void FilterOpened()
        {
            filterGroup.Visible = true;

            goBackToFilterButton.Visible = false;
            orderGroup.Visible = false;
            changeStatGroup.Visible = false;
            changeStatButton.Visible = false;

            this.Height = 250;
            this.Width = 340;

            labelName.Text = "Статус заказа";
            labelName.Left = 95;
            labelName.Top = 16;

            submitFilterButton.Left = 73;
            submitFilterButton.Top = 108;

            goBackToMainButton.Left = 80;
            goBackToMainButton.Top = 180;
        }

        public void StatOpened()
        {
            filterGroup.Visible = false;

            this.Height = 350;
            this.Width = 977;

            orderGroup.Visible = true;
            changeStatGroup.Visible = true;

            changeStatGroup.Top = 38;

            goBackToFilterButton.Visible = true;

            goBackToFilterButton.Left = 104;
            goBackToFilterButton.Top = 241;

            goBackToMainButton.Left = 104;
            goBackToMainButton.Top = 270;

            labelName.Left = 381;

            tbOrderDate.Text = "";
            tbStatDate.Text = "";
            tbCurrentStat.Text = "";
        }

        public void GetStoreCitiesIntoCBox()
        {
            string sqlExpression = "Get_Address";

            int i = 0;

            using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;  // указание, что команда представляет хранимую процедуру

                command.Parameters.Add("@id", SqlDbType.Int).Value = SignIn.userID;
                SqlDataReader reader = command.ExecuteReader();

                address = new string[10, 4];

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        duplicate = false;

                        for (int j = 0; j < i; j++)
                        {
                            if (address[j, 0] == reader.GetValue(2).ToString())
                                duplicate = true;
                        }

                        if (!duplicate)
                        {
                            address[i, 0] = reader.GetValue(2).ToString();
                            address[i, 1] = reader.GetValue(0).ToString();

                            tbChooseCity.Items.Add(address[i, 1]);

                            i++;
                        }
                    }
                }
                connection.Close();
                reader.Close();
            }
        }

        public void GetStatusIntoCBox()
        {
            string sqlExpression = "SELECT cheque_status_id, status_name FROM cheque_product_status WHERE role_name = 'Продавец' OR cheque_status_id = '2' ORDER BY cheque_status_id";

            int i = 0;

            using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    status = new string[4, 2];

                    while (reader.Read())
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            status[i, j] = reader.GetValue(j).ToString();
                        }

                        if (i != 3)
                            tbChooseStat.Items.Add(status[i, 1]);

                        i++;
                    }
                }
                connection.Close();
                reader.Close();
            }
        }

        public void GetInfo()
        {
            sqlExpression = "OrderStatus_NoFilters";

            infoGrid = new string[20, 12];

            using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;  // указание, что команда представляет хранимую процедуру

                command.Parameters.Add("@store_id", SqlDbType.Int).Value = SignIn.userID;
                SqlDataReader reader = command.ExecuteReader();

                int i = 0;

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        for (int j = 0; j < 12; j++)
                        {
                            infoGrid[i, j] = reader.GetValue(j).ToString();
                        }
                        i++;
                    }
                }

                connection.Close();
                reader.Close();
            }
        }

        public void FillHeaders(string[] headers)
        {
            DataGridViewTextBoxColumn header = new DataGridViewTextBoxColumn();

            for (int i = 0; i < headers.Length; i++)
            {
                orderGrid.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = headers[i] });
            }
        }

        public void FillOrderGrid(int option, int numOfCols)
        {
            orderGrid.Rows.Clear();
            displayed.Clear();

            if (option == 1)
            {
                orderGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                for (int i = 0; i < 20; i++)
                {
                    if (infoGrid[i, 0] != null)
                    {
                        orderGrid.Rows.Add();
                        for (int j = 0; j < numOfCols; j++)
                        {
                            orderGrid.Rows[i].Cells[j].Value = infoGrid[i, j];

                            displayed.Add(i);
                        }
                    }
                }
            }
            else if (option == 2)
            {
                orderGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                for (int i = 0; i < 20; i++)
                {
                    if (infoGrid[i, 0] != null)
                    {
                        if (infoGrid[i, 0] == tbChooseCity.Text && infoGrid[i, 2] == tbChooseStat.Text)
                        {
                            orderGrid.Rows.Add();
                            int count = 0;

                            for (int j = 0; j < numOfCols; j++)
                            {
                                if (j != 0 && j != 2)
                                {
                                    orderGrid.Rows[i].Cells[count].Value = infoGrid[i, j];

                                    displayed.Add(i);
                                }
                                else
                                {
                                    numOfCols++;
                                    count--;
                                }

                                count++;
                            }
                        }
                    }
                }
            }
            else if (option == 3)
            {
                orderGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                for (int i = 0; i < 20; i++)
                {
                    if (infoGrid[i, 0] != null)
                    {
                        if (infoGrid[i, 2] == tbChooseStat.Text)
                        {
                            orderGrid.Rows.Add();
                            int count = 0;

                            for (int j = 0; j < numOfCols; j++)
                            {
                                if (j != 2)
                                {
                                    orderGrid.Rows[i].Cells[count].Value = infoGrid[i, j];

                                    displayed.Add(i);
                                }
                                else
                                {
                                    numOfCols++;
                                    count--;
                                }

                                count++;
                            }
                        }
                    }
                }
            }
            else if (option == 4)
            {
                orderGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                for (int i = 0; i < 20; i++)
                {
                    if (infoGrid[i, 0] != null)
                    {
                        if (infoGrid[i, 0] == tbChooseCity.Text)
                        {
                            orderGrid.Rows.Add();
                            int count = 0;

                            for (int j = 0; j < numOfCols; j++)
                            {
                                if (j != 0)
                                {
                                    orderGrid.Rows[i].Cells[count].Value = infoGrid[i, j];

                                    displayed.Add(i);
                                }
                                else
                                {
                                    numOfCols++;
                                    count--;
                                }

                                count++;
                            }
                        }
                    }
                }
            }

            if (displayed.Count == 0)
            {
                MessageBox.Show("По вашему запросу не найдены заказы");
            }
        }

        public void GetButtonName()
        {
            for (int i = 0; i < 3; i++)
            {
                if (status[i,1] == tbCurrentStat.Text)
                {
                    changeStatButton.Text = status[i + 1, 1];
                    insertStatus = status[i + 1, 0];
                }
            }
        }

        #endregion
        #region Фильтры

        private void SubmitFilterButton_Click(object sender, EventArgs e)
        {
            StatOpened();
            GetInfo();

            var screen = Screen.FromControl(this);
            this.Top = screen.Bounds.Height / 2 - this.Height / 2;
            this.Left = screen.Bounds.Width / 2 - this.Width / 2;

            orderGrid.Columns.Clear();

            if (tbChooseCity.Text == "" && tbChooseStat.Text == "")
            {
                labelName.Text = "Текущие заказы";
                columnNames = new string[7] { "Город", "Адрес", "Статус заказа", "Артикул", "Размер", "Количество", "Цена" };

                option = 1;
            }
            else if (tbChooseCity.Text != "" && tbChooseStat.Text != "")
            {
                labelName.Text = "Город: " + tbChooseCity.Text + ". Статус: " + tbChooseStat.Text;
                columnNames = new string[5] { "Адрес", "Артикул", "Размер", "Количество", "Цена" };

                option = 2;
            }
            else if (tbChooseStat.Text != "")
            {
                labelName.Text = "Статус: " + tbChooseStat.Text;
                columnNames = new string[6] { "Город", "Адрес", "Артикул", "Размер", "Количество", "Цена" };

                option = 3;
            }
            else if (tbChooseCity.Text != "")
            {
                labelName.Text = "Заказы в городе " + tbChooseCity.Text;
                columnNames = new string[6] { "Адрес", "Статус заказа", "Артикул", "Размер", "Количество", "Цена" };

                option = 4;
            }

            FillHeaders(columnNames);

            FillOrderGrid(option, columnNames.Length);
        }

        #endregion
        #region Просмотр статуса заказа

        private void GoBackToFilterButton_Click(object sender, EventArgs e)
        {
            FilterOpened();
        }

        private void OrderGrid_MouseClick(object sender, MouseEventArgs e)
        {
            select = orderGrid.CurrentRow.Index;

            if (displayed.Count != 0)
            {
                tbOrderDate.Text = infoGrid[displayed[select], 10];
                tbStatDate.Text = infoGrid[displayed[select], 11];
                tbCurrentStat.Text = infoGrid[displayed[select], 2];

                GetButtonName();
                changeStatButton.Visible = true;
            }
        }

        private void ChangeStatButton_Click(object sender, EventArgs e)
        {
            // запрос для изменения статуса
            string sqlExpression = "INSERT INTO status_of_cheque (cheque_status_id, cheque_prod_id) VALUES ('" + insertStatus + "', '" + infoGrid[displayed[select], 8] + "');";

            using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
            {
                // подключение к базе
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }

            MessageBox.Show("Статус заказа успешно изменён!");

            tbOrderDate.Text = "";
            tbStatDate.Text = "";
            tbCurrentStat.Text = "";

            GetInfo();
            FillOrderGrid(option, columnNames.Length);
        }

        #endregion

        private void GoBackToMainButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
