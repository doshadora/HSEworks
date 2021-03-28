using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace courseWork2
{
    public partial class CustBag : Form
    {
        string[,] prods;
        public static string prodSelected;
        public static string storeSelected;

        public CustBag()
        {
            InitializeComponent();

            makeOrderButton.Enabled = false;

            FillBagGrid();
        }

        public void FillBagGrid()
        {
            string sqlExpression = "GetCustBag";

            int i = 0;
            prods = new string[20, 2];

            using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;  // указание, что команда представляет хранимую процедуру

                command.Parameters.Add("@cust_id", SqlDbType.Int).Value = SignIn.userID;
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        bagGrid.Rows.Add();
                        prods[i,0] = reader.GetValue(3).ToString();
                        prods[i, 1] = reader.GetValue(4).ToString();

                        for (int j = 0; j < 3; j++)
                        {
                            bagGrid.Rows[i].Cells[j].Value = reader.GetValue(j).ToString();
                        }

                        i++;
                    }
                }
                connection.Close();
                reader.Close();
            }
        }

        public void FindRow()
        {
            string sql1 = "SELECT store_address_id FROM store_address WHERE store_id = '" + prodSelected + "' AND address_id IS NULL";




            string sql = "SELECT product_address_id FROM product_address_id WHERE product_address_id = '" + prodAdr + "'";
        }

        private void MakeOrderButton_Click(object sender, EventArgs e)
        {
            string sqlExpression = "INSERT INTO cheque (cust_id) VALUES ('" + SignIn.userID + "')";

            FindRow();

            using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
            {
                // подключение к базе
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }

            CustOrder CustOrder = new CustOrder();
            CustOrder.Show();

            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BagGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (bagGrid.Rows[bagGrid.CurrentRow.Index].Cells[bagGrid.CurrentCell.ColumnIndex].Value != null)
            {
                makeOrderButton.Enabled = true;

                prodSelected = prods[bagGrid.CurrentRow.Index, 0];
                storeSelected = prods[bagGrid.CurrentRow.Index, 1];
            }
        }
    }
}
