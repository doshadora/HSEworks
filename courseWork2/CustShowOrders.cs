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
    public partial class CustShowOrders : Form
    {
        public CustShowOrders()
        {
            InitializeComponent();

            FillOrderGrid();
        }

        public void FillOrderGrid()
        {
            string sqlExpression = "GetCustOrder";

            int i = 0;

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
                        orderGrid.Rows.Add();

                        for (int j = 0; j < 7; j++)
                        {
                            orderGrid.Rows[i].Cells[j].Value = reader.GetValue(j).ToString();
                        }

                        i++;
                    }
                }
                connection.Close();
                reader.Close();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
