using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace courseWork2
{
    public partial class CustOrder : Form
    {
        int amountt;

        string prodAddr;
        string storeName;

        Byte[] storeLogo;

        public CustOrder()
        {
            InitializeComponent();

            GetStoreInfo();
            GetPhoto();
            label1.Text = storeName.ToUpper();
            label4.Text = MainCust.prodInfo[Convert.ToInt32(MainCust.lbl_Text), 1];

            this.cityTableAdapter.FillBy(this.custOrder_DataSet.city, Convert.ToInt32(CustBag.storeSelected));

            tbChooseAddress.Enabled = false;
            tbChooseSize.Enabled = false;
            upDownAmount.Enabled = false;
        }

        #region Функции

        public string GetID(string what)
        {
            string sql = "";

            if (what == "store")
                sql = "SELECT store_address_id FROM store_address WHERE store_id = '" + CustBag.storeSelected + "' AND address_id = '" + Convert.ToInt32(tbChooseAddress.SelectedValue) + "'";
            else if (what == "size")
                sql = "SELECT product_size_id FROM product_size WHERE product_id = '" + CustBag.prodSelected + "' AND size_id = '" + Convert.ToInt32(tbChooseSize.SelectedValue) + "'";

            string id = "";

            using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id = reader.GetValue(0).ToString();
                    }
                }
                else
                {
                    id = "0";
                }
                connection.Close();
            }

            return id;
        }

        public void GetStoreInfo()
        {
            string sqlExpression = "SELECT store_name, store_logo FROM store WHERE store_id = '" + CustBag.storeSelected + "'";

            using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                            storeName = reader.GetValue(0).ToString();

                        if (!reader.IsDBNull(1))
                        {
                            storeLogo = (byte[])reader.GetValue(1);
                            logoPreview.Image = MainShop.ByteArrayToImage(storeLogo);
                        }
                    }
                }

                connection.Close();
            }
        }

        public void GetPhoto()
        {
            string sqlExpression = "SELECT product_photo FROM product WHERE product_id = '" + CustBag.prodSelected + "'";

            using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            Byte[] photo = (byte[])reader.GetValue(0);
                            prodPic.Image = MainShop.ByteArrayToImage(photo);
                        }
                    }
                }

                connection.Close();
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

                command.Parameters.Add("@store_address_id", SqlDbType.Int).Value = Convert.ToInt32(GetID("store"));
                command.Parameters.Add("@product_size_id", SqlDbType.Int).Value = Convert.ToInt32(GetID("size"));
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (reader.IsDBNull(0))
                            amount = "0";
                        else
                            amount = reader.GetValue(0).ToString();

                        prodAddr = reader.GetValue(1).ToString();
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

        public void AddRowChequeSet()
        {
            string sql = "INSERT INTO cheque_set (cheque_id, product_address_id, cheque_product_amount) VALUES ('" + CustBag.chequeID + "', '" + prodAddr + "', '" + upDownAmount.Value.ToString() + "')";

            using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
            {
                // подключение к базе
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void AddRowStatus()
        {
            int chequeProd = Product.GetId(6);

            string sqlExpression = "INSERT INTO status_of_cheque (cheque_prod_id, cheque_status_id) VALUES ('" + chequeProd + "', '2')";

            using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
            {
                // подключение к базе
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void AddRowStoreProd()
        {
            int newAmount = amountt - Convert.ToInt32(upDownAmount.Value);

            string sqlExpression = "INSERT INTO product_address (product_size_id, store_address_id, store_product_amount) VALUES ('" + Convert.ToInt32(GetID("size")) + "', '" + Convert.ToInt32(GetID("store")) + "', '" + newAmount + "')";

            using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
            {
                // подключение к базе
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        #endregion
        #region Выбор параметров

        private void TbChooseCity_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                this.addressTableAdapter.FillBy(this.custOrder_DataSet.address, Convert.ToInt32(CustBag.storeSelected), Convert.ToInt32(tbChooseCity.SelectedValue));

                if (tbChooseAddress.Items.Count > 0)
                {
                    tbChooseAddress.SelectedIndex = 0;
                    if (tbChooseAddress.Items.Count >= 1 && tbChooseAddress.Text != "")
                    {
                        tbChooseAddress.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("В данном городе нет товара в наличии, выберите другой город");
                        tbChooseAddress.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("В данном городе нет товара в наличии, выберите другой город");
                    tbChooseAddress.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("В данном городе нет товара в наличии, выберите другой город");
                tbChooseAddress.Enabled = false;
            }

            tbChooseSize.Enabled = false;
            upDownAmount.Enabled = false;
        }

        private void TbChooseAddress_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                this.sizeTableAdapter.FillBy(this.custOrder_DataSet1.size, Convert.ToInt32(tbChooseAddress.SelectedValue), Convert.ToInt32(CustBag.storeSelected));

                if (tbChooseSize.Items.Count > 0)
                {
                    tbChooseSize.SelectedIndex = 0;
                    if (tbChooseSize.Items.Count >= 1 && tbChooseSize.Text != "")
                    {
                        tbChooseSize.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("В данном магазине нет товара в наличии, выберите другой адрес");
                        tbChooseSize.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("В данном магазине нет товара в наличии, выберите другой адрес");
                    tbChooseSize.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("В данном магазине нет товара в наличии, выберите другой адрес");
                tbChooseSize.Enabled = false;
            }

            upDownAmount.Enabled = false;
        }

        private void TbChooseSize_SelectionChangeCommitted(object sender, EventArgs e)
        {
            amountt = Convert.ToInt32(GetLastAmount());

            label6.Text = "Осталось " + amountt + " шт.";
            label6.Visible = true;

            if (amountt > 0)
            {
                label6.ForeColor = Color.Black;
                upDownAmount.Enabled = true;
            }
            else
            {
                upDownAmount.Enabled = false;
                label6.Text = "Нет в наличии";
                label6.ForeColor = Color.Red;
            }
        }

        private void UpDownAmount_ValueChanged(object sender, EventArgs e)
        {
            if (upDownAmount.Value <= amountt)
            {
                orderButton.Enabled = true;
            }
            else
            {
                orderButton.Enabled = false;
            }
        }

        #endregion

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            if (upDownAmount.Value <= amountt)
            {
                orderButton.Enabled = true;

                AddRowChequeSet();
                AddRowStatus();
                AddRowStoreProd();

                MessageBox.Show("Товар заказан! Можете просмотреть статус товара в разделе Мои Заказы");
            }
            else
            {
                MessageBox.Show("Нельзя заказать больше товаров, чем есть в наличии");
            }
        }
    }
}
