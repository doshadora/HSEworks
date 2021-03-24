using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace courseWork2
{
    public partial class MainCust : Form
    {
        Byte[] prodPicByte;
        string[,] prodInfo;

        string[] id;
        string temp;

        int numOfRows;

        public MainCust()
        {
            InitializeComponent();

            this.Height = 484;
            this.Width = 812;

            GetInfoProdGroup();
        }

        public void CountRowsAndGetID()
        {
            int i = 0;

            string sqlExpression = "SELECT COUNT(*) " +
                "FROM dbo.city INNER JOIN " +
                    "dbo.address ON dbo.city.city_id = dbo.address.city_id INNER JOIN " +
                    "dbo.store_address ON dbo.address.address_id = dbo.store_address.address_id INNER JOIN " +
                    "dbo.store ON dbo.store_address.store_id = dbo.store.store_id INNER JOIN " +
                    "dbo.product_address ON dbo.store_address.store_address_id = dbo.product_address.store_address_id INNER JOIN " +
                    "dbo.product_size ON dbo.product_address.product_size_id = dbo.product_size.product_size_id INNER JOIN " +
                    "dbo.product ON dbo.product_size.product_id = dbo.product.product_id " +
                "WHERE(dbo.product_address.change_date IN " +
                    "(SELECT MAX(change_date) " +
                    "FROM dbo.product_address AS product_address_1 " +
                    "WHERE product_address_1.store_product_amount IS NOT NULL " +
                    "GROUP BY product_address_1.store_address_id, product_address_1.product_size_id))";

            string sqlExpression1 = "SELECT dbo.product_address.product_address_id " +
               "FROM dbo.city INNER JOIN " +
                   "dbo.address ON dbo.city.city_id = dbo.address.city_id INNER JOIN " +
                   "dbo.store_address ON dbo.address.address_id = dbo.store_address.address_id INNER JOIN " +
                   "dbo.store ON dbo.store_address.store_id = dbo.store.store_id INNER JOIN " +
                   "dbo.product_address ON dbo.store_address.store_address_id = dbo.product_address.store_address_id INNER JOIN " +
                   "dbo.product_size ON dbo.product_address.product_size_id = dbo.product_size.product_size_id INNER JOIN " +
                   "dbo.product ON dbo.product_size.product_id = dbo.product.product_id " +
               "WHERE(dbo.product_address.change_date IN " +
                   "(SELECT MAX(change_date) " +
                   "FROM dbo.product_address AS product_address_1 " +
                   "WHERE product_address_1.store_product_amount IS NOT NULL " +
                   "GROUP BY product_address_1.store_address_id, product_address_1.product_size_id))";


            using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sqlExpression, connection);
                numOfRows = Convert.ToInt32(command.ExecuteScalar());

                id = new string[numOfRows];

                command = new SqlCommand(sqlExpression1, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id[i] = reader.GetValue(0).ToString();
                        i++;
                    }
                }
            }
        }

        public void FillInfoProdPanel()
        {
            for (int i = 0; i < numOfRows; i++)
            {
                cataloguePanel.RowCount += 1;

                for (int j = 0; j < 4; j++)
                {
                    PictureBox pic = new PictureBox();
                    pic.Image = MainShop.ByteArrayToImage(prodPicByte);
                    cataloguePanel.Controls.Add(pic, i, j);
                }
            }
        }

        public void GetInfoProdGroup()
        {
            cataloguePanel.Controls.Clear();
            CountRowsAndGetID();

            int i = 0;

            int j = 0;
            while (j < numOfRows)
            {
                if (j != numOfRows - 1)
                {
                    temp += "'" + id[j] + "', ";
                }
                else
                {
                    temp += "'" + id[j] + "'";
                }
                j++;
            }

            string sqlExpression =
                "SELECT dbo.product.product_code, dbo.product.product_name, dbo.product.product_info, " +
                "dbo.gender.gender_name, dbo.category.category_name, dbo.subcategory.subcategory_name, " +
                "dbo.product.product_photo, dbo.price.product_price " +
                "FROM dbo.product INNER JOIN " +
                    "dbo.category_gender ON dbo.product.category_gender_id = dbo.category_gender.category_gender_id INNER JOIN " +
                    "dbo.cat_subcategory ON dbo.category_gender.cat_subcat_id = dbo.cat_subcategory.cat_subcat_id INNER JOIN " +
                    "dbo.category ON dbo.cat_subcategory.category_id = dbo.category.category_id INNER JOIN " +
                    "dbo.subcategory ON dbo.cat_subcategory.subcategory_id = dbo.subcategory.subcategory_id INNER JOIN " +
                    "dbo.gender ON dbo.category_gender.gender_id = dbo.gender.gender_id INNER JOIN " +
                    "dbo.product_size ON dbo.product_size.product_id = dbo.product.product_id INNER JOIN " +
                    "dbo.product_address ON dbo.product_address.product_size_id = dbo.product_size.product_size_id INNER JOIN " +
                    "dbo.price ON dbo.price.product_id = dbo.product.product_id " +
                "WHERE(dbo.product_address.product_address_id IN (" + temp + ")) AND dbo.price.product_price IN " +
                            "(SELECT product_price FROM price " +
                            "WHERE version_date IN (SELECT MAX(version_date) FROM price GROUP BY product_id))";

            prodInfo = new string[numOfRows, 8];


            using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
            {
                connection.Open();

                while (i < numOfRows)
                {
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            prodInfo[i, 0] = reader.GetValue(0).ToString();
                            prodInfo[i, 1] = reader.GetValue(1).ToString();
                            prodInfo[i, 2] = reader.GetValue(2).ToString();
                            prodInfo[i, 3] = reader.GetValue(3).ToString();
                            prodInfo[i, 4] = reader.GetValue(4).ToString();
                            prodInfo[i, 5] = reader.GetValue(5).ToString();
                            prodInfo[i, 7] = reader.GetValue(7).ToString();

                            if (!reader.IsDBNull(6))
                            {
                                prodPicByte = (byte[])reader.GetValue(6);
                            }

                            FillInfoProdPanel();

                            i++;
                        }
                    }

                    reader.Close();
                }

                connection.Close();
            }
        }

        public void AddGroupToPanel()
        {

        }

        private void MenuBox_MouseHover(object sender, EventArgs e)
        {
            menuList.Visible = true;
        }

        private void MenuList_MouseLeave(object sender, EventArgs e)
        {
            menuList.Visible = false;
        }
    }
}
