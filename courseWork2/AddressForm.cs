using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace courseWork2
{
    public partial class AddressForm : Form
    {
        string[,] address, tempAddress, city;
        bool[] added = new bool[2];
        bool[] isChanged = new bool[2];
        bool[] deleted = new bool[2];
        string notChanged;

        public AddressForm()
        {
            InitializeComponent();
            storeNameLabel.Text = "Адреса магазинов " + SignIn.userName;
            GetStoreAddressIntoGrid();
            GetCityInfo();
        }

        public int GetLastId()
        {
            int id = 0;
            string sqlExpression = "SELECT TOP 1 address_id FROM address ORDER BY address_id DESC";

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

        public void GetCityInfo()
        {
            string sqlExpression = "SELECT city_id, city_name FROM city";
            int i = 0;

            using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    city = new string[100, 2];

                    while (reader.Read())
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            city[i, j] = reader.GetValue(j).ToString();
                        }

                        i++;
                    }
                }
                connection.Close();
                reader.Close();
            }
        }

        public void GetStoreAddressIntoGrid()
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

                address = new string[100, 4];

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            address[i, j] = reader.GetValue(j).ToString();
                        }

                        i++;
                    }
                }
                connection.Close();
                reader.Close();
            }

            tempAddress = new string[100, 2];

            for (int m = 0; m < i; m++)
            {
                storeAddressGrid.Rows.Add(address[m, 0], address[m, 1]);

                for (int n = 0; n < 2; n++)
                {
                    tempAddress[m, n] = address[m, n];
                }
            }
        }

        private void BackToMainShopButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddressForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clothes_storeDataSet2.city". При необходимости она может быть перемещена или удалена.
            this.cityTableAdapter.Fill(this.clothes_storeDataSet2.city);
        }

        private void SaveAddressButton_Click(object sender, EventArgs e)
        {
            notChanged = null;

            for (int i = 0; i < storeAddressGrid.RowCount; i++)
            {
                for (int j = 0; j < storeAddressGrid.ColumnCount; j++)
                {
                    address[i, j] = (string)storeAddressGrid[j, i].Value;

                    if (address[i, j] != tempAddress[i, j] && address[i, j] == null)
                    {
                        deleted[j] = true;
                    }
                    else deleted[j] = false;

                    if (address[i, j] != tempAddress[i, j] && tempAddress[i, j] != null && address[i, j] != null)
                    {
                        isChanged[j] = true;
                    }
                    else isChanged[j] = false;

                    if (address[i, j] != tempAddress[i, j] && tempAddress[i, j] == null)
                    {
                        added[j] = true;
                    }
                    else added[j] = false;
                }

                if (added[0] == false && added[1] == false && (isChanged[0] == true || isChanged[1] == true))
                {
                    int count = 0;

                    while (city[count, 1] != null)
                    {
                        if (city[count, 1] == address[i, 0])
                        {
                            address[i, 2] = city[count, 0];
                        }
                        count++;
                    }

                    // запрос для изменения адреса
                    string sqlExpression = "UPDATE address SET address_street = '" + address[i, 1] + "', city_id = '" + address[i, 2] + "' WHERE address_id = '" + address[i, 3] + "';";
                    using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
                    {
                        // подключение к базе
                        connection.Open();
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                else if ((address[i, 0] == null || address[i, 1] == null) && i != storeAddressGrid.RowCount - 1)
                {
                    notChanged += " " + (i + 1).ToString();

                    storeAddressGrid.Rows[i].Cells[0].Value = null;
                    storeAddressGrid.Rows[i].Cells[1].Value = null;
                }
                else if (added[0] == true && added[1] == true)
                {
                    int count = 0;

                    while (city[count, 1] != null)
                    {
                        if (city[count, 1] == address[i, 0])
                        {
                            address[i, 2] = city[count, 0];
                        }
                        count++;
                    }

                    // запрос для добавления адреса
                    string sqlExpression = "INSERT INTO address (address_street, city_id) VALUES ('" + address[i, 1] + "', '" + address[i, 2] + "');" +
                                           "INSERT INTO store_address (store_id, address_id) VALUES ('" + SignIn.userID + "', '" + GetLastId() + "');";

                    using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
                    {
                        // подключение к базе
                        connection.Open();
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                else if (deleted[0] == true && deleted[1] == true)
                {
                    // запрос для добавления адреса
                    string sqlExpression = "DELETE FROM store_address WHERE address_id = '" + address[i, 3] + "';" +
                                           "DELETE FROM address WHERE address_id = '" + address[i, 3] + "';";

                    using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
                    {
                        // подключение к базе
                        connection.Open();
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }

            if (notChanged != null) MessageBox.Show("Ошибка! Строки под данными номерами не были изменены:" + notChanged + ".");
            else MessageBox.Show("Данные успешно сохранены!");
        }
    }
}
