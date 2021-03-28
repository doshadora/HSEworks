using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace courseWork2
{
    public partial class AddProductToStore : Form
    {
        string[,] address;
        string currentAddress;

        string prodSizeID;
        string sqlString;

        bool changed = false;

        public AddProductToStore()
        {
            InitializeComponent();

            GetStoreAddressIntoGrid();

            button1.Visible = false;
            button2.Visible = false;

            nameLabel.Text = "Добавление товара " + Catalogue.prodName.ToUpper() + " в точки продажи";
        }
        private void AddProductToStore_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "addToStore_DataSet.size_type". При необходимости она может быть перемещена или удалена.
            this.size_typeTableAdapter.Fill(this.addToStore_DataSet.size_type);
        }

        #region Функции

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

                address = new string[100, 5];

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            address[i, j] = reader.GetValue(j).ToString();
                        }

                        i++;
                    }
                }
                connection.Close();
                reader.Close();
            }

            for (int m = 0; m < i; m++)
            {
                storeAddressGrid.Rows.Add(address[m, 0], address[m, 1]);
            }
        }

        public string GetLastAmount()
        {
            string amount = "";

            string sqlExpression = "Catalogue_GetLastAmount";

            using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;  // указание, что команда представляет хранимую процедуру

                command.Parameters.Add("@store_address_id", SqlDbType.Int).Value = Convert.ToInt32(currentAddress);
                command.Parameters.Add("@product_size_id", SqlDbType.Int).Value = GetProdSizeID();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (reader.IsDBNull(0))
                            amount = "0";
                        else
                            amount = reader.GetValue(0).ToString();
                    }
                }
                else
                {
                    amount = "0";
                }
                connection.Close();
            }

            return amount;
        }

        public int GetProdSizeID()
        {
            int id = 0;

            string sqlExpression = "SELECT product_size_id " +
                "FROM product_size INNER JOIN " +
                    "size ON size.size_id = product_size.size_id " +
                "WHERE size.size_id = '" + tbSize.SelectedValue + "' AND product_size.product_id = '" + Catalogue.prodID + "'";

            using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);

                id = Convert.ToInt32(command.ExecuteScalar());

                connection.Close();
            }

            return id;
        }

        #endregion
        #region Выбор параметров

        private void TbCountry_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (changed)
                {
                    tbSize.Enabled = true;
                    tbAddress.Text = "Выберите размер";
                }

                this.sizeTableAdapter.FillBy(this.addToStore_DataSet.size, tbCountry.Text);

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void StoreAddressGrid_MouseClick(object sender, MouseEventArgs e)
        {
            button1.Visible = false;

            if (storeAddressGrid.Rows[storeAddressGrid.CurrentRow.Index].Cells[storeAddressGrid.CurrentCell.ColumnIndex].Value != null)
            {
                currentAddress = address[storeAddressGrid.CurrentRow.Index, 4];
                tbAddress.Text = "Выберите страну";

                label2.Visible = true;
                label3.Visible = true;
                tbCountry.Visible = true;
                tbSize.Visible = true;

                tbCountry.Enabled = true;

                changed = true;
            }
        }

        private void TbSize_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tbCountry.Enabled = false;
            tbSize.Enabled = false;

            label4.Visible = true;
            tbCurrentAmount.Visible = true;

            string check = GetLastAmount();
            tbCurrentAmount.Text = check;

            label5.Visible = true;
            tbNewAmount.Visible = true;
            tbNewAmount.Enabled = true;

            tbAddress.Text = "Введите новое количество";

            saveButton.Visible = true;
        }

        private void TbNewAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        #endregion
        #region Сохранение

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (tbNewAmount.Text != "")
            {
                Product.IfRowExists("product_size_id", Catalogue.prodID.ToString(), tbSize.SelectedValue.ToString());

                if (Product.rowExists[0] == "yes")
                {
                    prodSizeID = Product.rowExists[1];
                }
                else if (Product.rowExists[0] == "no")
                {
                    sqlString = "INSERT INTO product_size (product_id, size_id) VALUES ('" + Catalogue.prodID + "', '" + tbSize.SelectedValue + "'); ";
                    prodSizeID = Product.GetId(1).ToString();
                }

                sqlString += "INSERT INTO product_address (product_size_id, store_address_id, store_product_amount) VALUES ('" + prodSizeID + "', '" + currentAddress + "', '" + tbNewAmount.Text + "');";

                SqlConnection connection = new SqlConnection(SignIn.connectionString);

                try
                {
                    // подключение к базе
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlString, connection);

                    command.ExecuteNonQuery();
                    connection.Close();

                    button1.Visible = true;

                    tbNewAmount.Text = "";
                    tbCountry.Enabled = false;
                    tbSize.Enabled = false;

                    label4.Visible = false;
                    label5.Visible = false;

                    tbCurrentAmount.Visible = false;
                    tbNewAmount.Visible = false;


                }
                catch (Exception ex)
                {
                    button2.Visible = true;
                    MessageBox.Show(ex.Message);
                }
            }
            else MessageBox.Show("Введите значение");
        }

        #endregion

        private void GoBackToMainButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
