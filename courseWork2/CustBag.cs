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

        public static string chequeID;

        public CustBag()
        {
            InitializeComponent();

            makeOrderButton.Enabled = false;

            FillBagGrid();
        }


        #region Функции

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
                        prods[i, 0] = reader.GetValue(3).ToString();
                        prods[i, 1] = reader.GetValue(4).ToString();

                        chequeID = reader.GetValue(5).ToString();

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


        #endregion

        private void MakeOrderButton_Click(object sender, EventArgs e)
        {
            CustOrder CustOrder = new CustOrder();
            CustOrder.Show();
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
