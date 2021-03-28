using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace courseWork2
{
    public partial class Product : Form
    {
        Byte[] prodPicByte;

        string[] info = new string[7];
        string[] catInfo;
        public static string[] rowExists = new string[2];

        bool catGenYes = false;
        bool catSubYes = false;
        public static bool update = false;

        string sqlString;
        string temp;

        public Product()
        {
            InitializeComponent();

            this.genderTableAdapter.Fill(this.genderDataSet.gender);

            GetInfoAboutProd();

            if (Catalogue.infoClicked)
            {
                labelProd.Text = tbProdName.Text.ToUpper();

                this.Width = 494;

                prodPhotoButton.Left = 97;
                prodPhotoButton.Text = "Изменить фотографию";

                prodSaveButton.Left = 97;

                goBackToMainButton.Left = 243;
            }
            else
            {
                labelProd.Text = "Новый товар";

                this.Width = 338;

                prodPhotoButton.Left = 22;
                prodPhotoButton.Text = "Добавить фотографию";

                prodSaveButton.Left = 22;

                goBackToMainButton.Left = 168;
            }
        }

        #region Функции

        public static int GetId(int param)
        {
            string sql = "";
            int id = 0;

            if (param == 1)
                sql = "SELECT TOP (1) product_size_id FROM product_size ORDER BY product_size_id DESC;";
            else if (param == 2)
                sql = "SELECT TOP (1) store_address_id FROM store_address ORDER BY store_address_id DESC;";
            else if (param == 3)
                sql = "SELECT store_address_id FROM store_address WHERE store_id = '" + SignIn.userID + "' AND address_id IS NULL;";
            else if (param == 4)
                sql = "SELECT TOP (1) product_id FROM product ORDER BY product_id DESC";

            using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
            {
                // подключение к базе
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);

                id = Convert.ToInt32(command.ExecuteScalar());
                
                // закрытие подключения
                connection.Close();

                if (param != 3)
                    return id + 1;
                else return id;
            }
        }

        public void GetInfoAboutProd()
        {
            if (Catalogue.infoClicked)
            {
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
                    "dbo.price ON dbo.price.product_id = dbo.product.product_id " +
                "WHERE(dbo.product.product_id = '" + Catalogue.prodID + "') AND dbo.price.product_price IN " +
                            "(SELECT product_price FROM price " +
                            "WHERE version_date IN (SELECT MAX(version_date) FROM price GROUP BY product_id))";

                using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            tbProdCode.Text = reader.GetValue(0).ToString();
                            tbProdName.Text = reader.GetValue(1).ToString();
                            tbProdInfo.Text = reader.GetValue(2).ToString();
                            info[3] = reader.GetValue(3).ToString();
                            tbGender.Text = reader.GetValue(3).ToString();
                            info[4] = reader.GetValue(4).ToString();
                            tbProdCat.Text = reader.GetValue(4).ToString();
                            info[5] = reader.GetValue(5).ToString();
                            tbProdSubCat.Text = reader.GetValue(5).ToString();
                            tbPrice.Text = reader.GetValue(7).ToString();
                            temp = reader.GetValue(7).ToString();

                            if (tbProdSubCat.Text != "")
                            {
                                tbProdSubCat.Enabled = true;
                            }
                            else tbProdSubCat.Enabled = false;

                            if (!reader.IsDBNull(6))
                            {
                                prodPicByte = (byte[])reader.GetValue(6);
                                picPreview.Image = MainShop.ByteArrayToImage(prodPicByte);
                            }
                        }
                    }
                    connection.Close();
                    reader.Close();
                }
            }
        }

        public static void IfRowExists(string rowID, string param1, string param2)
        {
            string sql = "";

            if (rowID == "cat_subcat_id")
            {
                if (param2 == null)
                {
                    param2 = GetId(3).ToString();
                }
                sql = "SELECT " + rowID + "" +
                             " FROM cat_subcategory" +
                             " WHERE category_id = '" + param1 + "' AND subcategory_id = '" + param2 + "'";

            }
            else if (rowID == "category_gender_id")
            {
                sql = "SELECT " + rowID + "" +
                             " FROM category_gender" +
                             " WHERE gender_id = '" + param1 + "' AND cat_subcat_id = '" + param2 + "'";
            }
            else if (rowID == "product_size_id")
            {
                sql = "SELECT " + rowID + "" +
                             " FROM product_size" +
                             " WHERE product_id = '" + param1 + "' AND size_id = '" + param2 + "'";
            }
            else if (rowID == "store_address_id")
            {
                sql = "SELECT " + rowID + "" +
                             " FROM store_address" +
                             " WHERE store_id = '" + param1 + "' AND address_id = '" + param2 + "'";
            }

            using (SqlConnection connection = new SqlConnection(SignIn.connectionString)) // 
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
                        rowExists[0] = "yes";
                        rowExists[1] = reader.GetValue(0).ToString();
                    }
                }
                else
                {
                    rowExists[0] = "no";
                }

                // закрытие подключения
                connection.Close();
                reader.Close();
            }
        }

        #endregion
        #region Добавление фото

        private void ProdPhotoButton_Click(object sender, EventArgs e)
        {
            prodPicByte = MainShop.UploadPicture(prodPicByte);

            picPreview.Image = MainShop.ByteArrayToImage(prodPicByte);
            picPreview.Invalidate();

            this.Width = 485;

            prodPhotoButton.Left = 87;
            prodPhotoButton.Text = "Изменить фотографию";

            prodSaveButton.Left = 87;

            goBackToMainButton.Left = 233;
        }

        #endregion
        #region Изменение категории

        private void TbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbProdSubCat.Enabled = false;

            info[3] = tbGender.Text;
            try
            {
                this.categoryTableAdapter.FillBy(this.catDataSet.category, (this.tbGender.Text));

                tbGender.SelectedIndex = tbGender.FindString(info[3]);

                int i = 0;

                info[4] = tbProdCat.Text;

                tbProdCat.SelectedIndex = tbProdCat.FindString(info[4]);
            }
            catch (System.Exception ex)
            {
            }
        }

        private void TbProdCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbProdSubCat.Enabled = false;

            info[5] = tbProdSubCat.Text;
            try
            {
                this.subcategoryTableAdapter.FillBy(this.subCatDataSet.subcategory, (this.tbProdCat.Text));

                if (tbProdSubCat.Items.Count == 0)
                {
                    tbProdSubCat.Text = "отсутсвуют";
                    tbProdSubCat.Enabled = false;
                }
                else
                {
                    tbProdSubCat.Enabled = true;

                    tbProdSubCat.SelectedIndex = tbProdSubCat.FindString(info[5]);
                }
            }
            catch (System.NullReferenceException ex)
            {
                tbProdSubCat.Text = "отсутствуют";
                tbProdSubCat.Enabled = false;

            }
            catch (System.Exception ex)
            {
                tbProdSubCat.Text = "отсутствуют";
                tbProdSubCat.Enabled = false;
            }
        }

        #endregion
        #region Сохранение

        private void ProdSaveButton_Click(object sender, EventArgs e)
        {
            string catGenID = "";

            info[0] = tbProdCode.Text;
            info[1] = tbProdName.Text;
            info[2] = tbProdInfo.Text;
            info[3] = tbGender.Text;
            info[4] = tbProdCat.Text;
            info[5] = tbProdSubCat.Text;
            info[6] = tbPrice.Text;

            catInfo = new string[3];

            catInfo[0] = tbGender.SelectedValue.ToString();
            catInfo[1] = tbProdCat.SelectedValue.ToString();

            if (tbProdSubCat.Enabled == true)
            {
                catInfo[2] = tbProdSubCat.SelectedValue.ToString();
            }
            else catInfo[2] = null;

            if (Catalogue.infoClicked)
            {
                IfRowExists("cat_subcat_id", catInfo[1], catInfo[2]);

                if (rowExists[0] == "yes")
                {
                    IfRowExists("category_gender_id", catInfo[0], rowExists[1]);

                    if (rowExists[0] == "yes")
                    {
                        catGenID = rowExists[1];
                    }
                }

                sqlString = "UPDATE product SET product_code = '" + Convert.ToInt64(info[0]) + "', product_name = '" + info[1] + "', product_info = '" + info[2] + "', product_photo = @photo, category_gender_id ='" + Convert.ToInt32(catGenID) + "' WHERE product_id = '" + Catalogue.prodID + "'";

                if (info[6] != temp)
                {
                    sqlString += "INSERT INTO price (product_id, product_price) VALUES ('" + Catalogue.prodID + "', '" + Convert.ToInt32(info[6]) + "')";
                }
            }
            else
            {
                IfRowExists("cat_subcat_id", catInfo[1], catInfo[2]);

                if (rowExists[0] == "yes")
                {
                    catSubYes = true;

                    IfRowExists("category_gender_id", catInfo[0], rowExists[1]);

                    if (rowExists[0] == "yes")
                    {
                        catGenYes = true;
                        catGenID = rowExists[1];
                    }
                }

                if (catGenYes && catSubYes)
                {
                    sqlString = "INSERT INTO product (product_code, product_name, product_info, product_photo, category_gender_id) VALUES ('" + Convert.ToInt64(info[0]) + "', '" + info[1] + "', '" + info[2] + "', @photo, '" + Convert.ToInt32(catGenID) + "'); " +
                                "INSERT INTO product_size (product_id, size_id) VALUES ('" + GetId(4) + "', NULL); " +
                                "INSERT INTO product_address (product_size_id, store_address_id) VALUES ('" + GetId(1) + "', '" + GetId(3) + "'); ";

                    if (info[6] != temp)
                    {
                        sqlString += "INSERT INTO price (product_id, product_price) VALUES ('" + GetId(4) + "', '" + Convert.ToInt32(info[6]) + "')";
                    }
                }
            }

            if (tbProdCode.Text == "" || tbProdName.Text == "" || tbProdInfo.Text == "" || tbGender.Text == "" || tbProdCat.Text == "" || (tbProdSubCat.Text == "" && tbProdSubCat.Enabled == true))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                SqlConnection connection = new SqlConnection(SignIn.connectionString);

                try
                {
                    // подключение к базе
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlString, connection);

                    command.Parameters.Add("@photo", SqlDbType.Image, prodPicByte.Length).Value = prodPicByte;

                    command.ExecuteNonQuery();
                    connection.Close();

                    if (Catalogue.infoClicked)
                        MessageBox.Show("Товар успешно изменен!");
                    else
                        MessageBox.Show("Товар успешно добавлен!");

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        #endregion

        private void GoBackToMainButton_Click(object sender, EventArgs e)
        {
            update = true;
            this.Close();
        }
    }
}
