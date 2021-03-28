using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace courseWork2
{
    public partial class MainCust : Form
    {
        Label priceLabel;

        Byte[] prodPicByte;

        public static string[,] prodInfo;
        public static int prodID;

        bool catChanged = false;
        bool subChanged = false;
        bool wasDisabled = false;

        string[] id;
        string temp;
        string extendSql;

        PictureBox[] boxArray;

        public static List<Image> picArray;

        int numOfRows;

        public MainCust()
        {
            InitializeComponent();

            this.Height = 484;
            this.Width = 812;

            applyFilterButton.Text = "Применить фильтры";

            FillInfoProdGrid();
        }

        private void MainCust_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "catsubcat_DataSet.category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.catsubcat_DataSet.category);
        }

        #region Функции

        public void CountRowsAndGetID()
        {
            int i = 0;

            string sqlExpression = "SELECT COUNT(*) " +
                "FROM (SELECT DISTINCT dbo.product.product_id " +
                    "FROM dbo.store_address INNER JOIN " +
                         "dbo.store ON dbo.store_address.store_id = dbo.store.store_id INNER JOIN " +
                         "dbo.product_address ON dbo.store_address.store_address_id = dbo.product_address.store_address_id INNER JOIN " +
                         "dbo.product_size ON dbo.product_address.product_size_id = dbo.product_size.product_size_id INNER JOIN " +
                         "dbo.product ON dbo.product_size.product_id = dbo.product.product_id INNER JOIN " +
                         "dbo.category_gender ON dbo.product.category_gender_id = dbo.category_gender.category_gender_id INNER JOIN " +
                         "dbo.cat_subcategory ON dbo.category_gender.cat_subcat_id = dbo.cat_subcategory.cat_subcat_id INNER JOIN " +
                         "dbo.category ON dbo.cat_subcategory.category_id = dbo.category.category_id INNER JOIN " +
                         "dbo.subcategory ON dbo.cat_subcategory.subcategory_id = dbo.subcategory.subcategory_id INNER JOIN " +
                         "dbo.gender ON dbo.category_gender.gender_id = dbo.gender.gender_id INNER JOIN " +
                         "dbo.price ON dbo.price.product_id = dbo.product.product_id " +
                    "WHERE (dbo.product_address.change_date IN " +
                        "(SELECT MAX(change_date) " +
                        "FROM dbo.product_address AS product_address_1 " +
                        "WHERE product_address_1.store_product_amount IS NOT NULL " +
                        "GROUP BY product_address_1.store_address_id, product_address_1.product_size_id))" + extendSql + ") AS [table]";

            string sqlExpression1 = "SELECT DISTINCT dbo.product.product_id " +
                                    "FROM dbo.store_address INNER JOIN " +
                                        "dbo.store ON dbo.store_address.store_id = dbo.store.store_id INNER JOIN " +
                                        "dbo.product_address ON dbo.store_address.store_address_id = dbo.product_address.store_address_id INNER JOIN " +
                                        "dbo.product_size ON dbo.product_address.product_size_id = dbo.product_size.product_size_id INNER JOIN " +
                                        "dbo.product ON dbo.product_size.product_id = dbo.product.product_id INNER JOIN " +
                                        "dbo.category_gender ON dbo.product.category_gender_id = dbo.category_gender.category_gender_id INNER JOIN " +
                                        "dbo.cat_subcategory ON dbo.category_gender.cat_subcat_id = dbo.cat_subcategory.cat_subcat_id INNER JOIN " +
                                        "dbo.category ON dbo.cat_subcategory.category_id = dbo.category.category_id INNER JOIN " +
                                        "dbo.subcategory ON dbo.cat_subcategory.subcategory_id = dbo.subcategory.subcategory_id INNER JOIN " +
                                        "dbo.gender ON dbo.category_gender.gender_id = dbo.gender.gender_id INNER JOIN " +
                                        "dbo.price ON dbo.price.product_id = dbo.product.product_id " +
                                    "WHERE (dbo.product_address.change_date IN (SELECT MAX(change_date) " +
                                    "FROM dbo.product_address AS product_address_1 " +
                                    "WHERE product_address_1.store_product_amount IS NOT NULL " +
                                    "GROUP BY product_address_1.store_address_id, product_address_1.product_size_id)) " + extendSql + "";

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

        public void GetDataForGrid()
        {
            for (int m = 0; m < numOfRows; m++)
            {
                if (m != numOfRows - 1)
                    temp += id[m] + ", ";
                else
                    temp += id[m];
            }

            string sqlExpression =
                "SELECT DISTINCT dbo.product.product_code, dbo.product.product_name, dbo.product.product_info, " +
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
                "WHERE (dbo.product.product_id IN (" + temp + ")) AND dbo.price.product_price IN " +
                            "(SELECT product_price FROM price " +
                            "WHERE version_date IN (SELECT MAX(version_date) FROM price GROUP BY product_id))" + extendSql + "";

            prodInfo = new string[numOfRows, 7];
            picArray = new List<Image>();

            int i = 0;

            using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
            {
                connection.Open();

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
                        prodInfo[i, 6] = reader.GetValue(7).ToString();

                        if (!reader.IsDBNull(6))
                        {
                            prodPicByte = (byte[])reader.GetValue(6);
                            picArray.Add(MainShop.ByteArrayToImage(prodPicByte));
                        }

                        i++;
                    }
                }
                reader.Close();
                connection.Close();
            }
        }

        public void FillInfoProdGrid()
        {
            picPanel.Controls.Clear();

            CountRowsAndGetID();
            GetDataForGrid();

            int xLoc = 12;
            int yLoc = 7;
            int y1Loc = 205;

            boxArray = new PictureBox[numOfRows];
            int j;

            for (int i = 0; i < numOfRows; i++)
            {
                boxArray[i] = new PictureBox();
                priceLabel = new Label();

                boxArray[i].Image = picArray[i];
                boxArray[i].Name = i.ToString();
                boxArray[i].Text = i.ToString();


                boxArray[i].Size = new System.Drawing.Size(135, 195);
                boxArray[i].SizeMode = PictureBoxSizeMode.StretchImage;

                boxArray[i].Click += PictureBox1_Click;

                priceLabel.Text = prodInfo[i, 6] + " руб.";
                priceLabel.Font = new Font(nameLabel.Font.Name, 9);

                picPanel.Controls.Add(boxArray[i]);
                picPanel.Controls.Add(priceLabel);

                boxArray[i].Location = new Point(xLoc, yLoc);
                priceLabel.Location = new Point(xLoc, y1Loc);

                if (i <= 4) j = 3;
                else j = 4;

                if (i % j != 0 || i == 0)
                {
                    xLoc += 141;
                }
                else
                {
                    xLoc = 12;
                    yLoc += 226;
                    y1Loc += 226;
                }
            }
        }

        #endregion
        #region Фильтры по каталогу

        private void TbChooseCat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            catChanged = true;

            this.subcategoryTableAdapter.FillBy(this.catsubcat_DataSet.subcategory, Convert.ToInt32(tbChooseCat.SelectedValue));

            if (tbChooseSubCat.Items.Count > 0)
            {
                tbChooseSubCat.SelectedIndex = 0;
                if (tbChooseSubCat.Items.Count >= 1 && tbChooseSubCat.Text != "")
                {
                    tbChooseSubCat.Enabled = true;
                    wasDisabled = false;
                }
                else
                {
                    tbChooseSubCat.Text = "отсуствуют";
                    tbChooseSubCat.Enabled = false;
                    wasDisabled = true;
                }
            }
            else
            {
                tbChooseSubCat.Text = "отсуствуют";
                tbChooseSubCat.Enabled = false;
                wasDisabled = true;
            }

            subChanged = false;
        }

        #endregion
        #region Меню

        private void MenuBox_MouseHover(object sender, EventArgs e)
        {
            menuList.Visible = true;
        }

        private void MenuList_MouseLeave(object sender, EventArgs e)
        {
            menuList.Visible = false;
        }

        private void MenuList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menuList.SelectedIndex == 0)
            {
                CustBag CustBag = new CustBag();
                CustBag.Show();
            }
            else if (menuList.SelectedIndex == 1)
            {
                CustOrder CustOrder = new CustOrder();
                CustOrder.Show();
            }
            else if (menuList.SelectedIndex == 2)
            {
                CustAccount CustAccount = new CustAccount();
                CustAccount.Show();
            }
        }

        #endregion
        #region Выбор товара из каталога

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            string lbl_Text;
            lbl_Text = (sender as PictureBox).Name;

            prodID = Convert.ToInt32(lbl_Text);

            CustProduct CustProduct = new CustProduct();
            CustProduct.Show();
        }

        #endregion

        private void ApplyFilterButton_Click(object sender, EventArgs e)
        {
            if (applyFilterButton.Text == "Применить фильтры")
            {
                if (catChanged == true && subChanged == true)
                {
                    extendSql = " AND dbo.category.category_id = '" + tbChooseCat.SelectedValue + "' AND dbo.subcategory.subcategory_id = '" + tbChooseSubCat.SelectedValue + "'";
                }
                else if (catChanged == true && subChanged == false)
                {
                    extendSql = " AND dbo.category.category_id = '" + tbChooseCat.SelectedValue + "'";
                }

                applyFilterButton.Text = "Сбросить фильтр";

                tbChooseCat.Enabled = false;
                tbChooseSubCat.Enabled = false;

                subChanged = false;
            }
            else if (applyFilterButton.Text == "Сбросить фильтр")
            {
                extendSql = "";
                applyFilterButton.Text = "Применить фильтры";

                tbChooseCat.Enabled = true;

                if (wasDisabled == false)
                    tbChooseSubCat.Enabled = true;
            }

            FillInfoProdGrid();
        }

        private void TbChooseSubCat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            subChanged = true;
        }
    }
}
