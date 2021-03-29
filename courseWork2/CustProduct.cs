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
    public partial class CustProduct : Form
    {
        public static string prodSelected;
        public static string storeSelected;

        string prodStoreID;
        int chequeId;

        public CustProduct()
        {
            InitializeComponent();

            tbProdCode.Text = MainCust.prodInfo[Convert.ToInt32(MainCust.lbl_Text), 0];
            tbProdInfo.Text = MainCust.prodInfo[Convert.ToInt32(MainCust.lbl_Text), 2];
            tbProdName.Text = MainCust.prodInfo[Convert.ToInt32(MainCust.lbl_Text), 1];
            tbPrice.Text = MainCust.prodInfo[Convert.ToInt32(MainCust.lbl_Text), 6];

            prodPic.Image = MainCust.picArray[Convert.ToInt32(MainCust.lbl_Text)];

            actionButton.Text = "В корзину";
        }

        public int FindRow()
        {
            string sql1 = "SELECT store_address_id FROM store_address WHERE store_id = '" + MainCust.storeID + "' AND address_id IS NULL";

            int prodAdr = 0, prodSize = 0, prodAdrSize = 0;

            using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
            {
                // подключение к базе
                connection.Open();
                SqlCommand command = new SqlCommand(sql1, connection);
                SqlDataReader reader = command.ExecuteReader();

                // условие, что запрос не пустой
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        prodAdr = Convert.ToInt32(reader.GetValue(0));
                    }
                }
            }

            sql1 = "SELECT product_size_id FROM product_size WHERE product_id = '" + MainCust.prodID + "' AND size_id IS NULL";

            using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
            {
                // подключение к базе
                connection.Open();
                SqlCommand command = new SqlCommand(sql1, connection);
                SqlDataReader reader = command.ExecuteReader();

                // условие, что запрос не пустой
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        prodSize = Convert.ToInt32(reader.GetValue(0));
                    }
                }
            }

            string sql = "SELECT product_address_id FROM product_address WHERE store_address_id = '" + prodAdr + "' AND product_size_id = '" + prodSize + "' AND store_product_amount IS NULL";

            using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
            {
                // подключение к базе
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                // условие, что запрос не пустой
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        prodAdrSize = Convert.ToInt32(reader.GetValue(0));
                    }
                }
            }

            return prodAdrSize;
        }

        public int CheckBag()
        {
            int alreadyInBag = 0;

            string sql = "SELECT dbo.cheque_set.cheque_prod_id " +
                "FROM dbo.cheque_set INNER JOIN " +
                    "dbo.status_of_cheque ON dbo.cheque_set.cheque_prod_id = dbo.status_of_cheque.cheque_prod_id " +
                "WHERE (dbo.cheque_set.cheque_id = '" + chequeId + "') AND (dbo.cheque_set.product_address_id = '" + prodStoreID + "') AND (dbo.status_of_cheque.status_date IN " +
                    "(SELECT MAX(status_date) AS Expr1 " +
                    "FROM dbo.status_of_cheque AS status_of_cheque_1 " +
                    "GROUP BY cheque_prod_id " +
                    "HAVING (dbo.status_of_cheque.cheque_status_id = '1')))";

            using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
            {
                // подключение к базе
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                // условие, что запрос не пустой
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        alreadyInBag = Convert.ToInt32(reader.GetValue(0));
                    }
                }
            }

            return alreadyInBag;
        }

        public void AddRowToBag()
        {
            string sqlExpression = "INSERT INTO cheque_set (cheque_id, product_address_id) VALUES ('" + chequeId + "', '" + prodStoreID + "')";

            using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
            {
                // подключение к базе
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }

            this.Close();

            int chequeProd = Product.GetId(6);

            sqlExpression = "INSERT INTO status_of_cheque (cheque_prod_id, cheque_status_id) VALUES ('" + chequeProd + "', '1')";

            using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
            {
                // подключение к базе
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            if (actionButton.Text == "В корзину")
            {
                string sqlExpression = "";

                chequeId = Product.GetId(5);

                if (chequeId == 0)
                {
                    sqlExpression = "INSERT INTO cheque (cust_id) VALUES ('" + SignIn.userID + "')";

                    using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
                    {
                        // подключение к базе
                        connection.Open();
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                    }

                    this.Close();

                    chequeId = Product.GetId(5);
                }

                prodStoreID = FindRow().ToString();

                int exists = CheckBag();

                if (exists == 0)
                {
                    AddRowToBag();
                    this.Close();
                }
                else MessageBox.Show("Товар уже в корзине");
            }
        }
    }
}
