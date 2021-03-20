using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace courseWork2
{
    public partial class Product : Form
    {
        Byte[] prodPicByte;

        string[] info;

        string sqlString;

        public Product()
        {
            InitializeComponent();

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

        public void GetInfoAboutProd()
        {
            if (Catalogue.infoClicked)
            {
                string sqlExpression =
                "SELECT dbo.product.product_code, dbo.product.product_name, dbo.product.product_info, dbo.gender.gender_name, dbo.category.category_name, dbo.subcategory.subcategory_name, dbo.product.product_photo " +
                "FROM dbo.product INNER JOIN " +
                    "dbo.category_gender ON dbo.product.category_gender_id = dbo.category_gender.caterogy_gender_id INNER JOIN " +
                    "dbo.cat_subcategory ON dbo.category_gender.cat_subcat_id = dbo.cat_subcategory.cat_subcat_id INNER JOIN " +
                    "dbo.category ON dbo.cat_subcategory.category_id = dbo.category.category_id INNER JOIN " +
                    "dbo.subcategory ON dbo.cat_subcategory.subcategory_id = dbo.subcategory.subcategory_id INNER JOIN " +
                    "dbo.gender ON dbo.category_gender.gender_id = dbo.gender.gender_id " +
                "WHERE(dbo.product.product_id = '" + Catalogue.prodID + "')";

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
                            //tbProdInfo.Text = reader.GetValue(2).ToString();
                            tbGender.Text = reader.GetValue(3).ToString();
                            tbProdCat.Text = reader.GetValue(4).ToString();
                            tbProdSubCat.Text = reader.GetValue(5).ToString();

                            prodPicByte = (byte[])reader.GetValue(6);
                            picPreview.Image = MainShop.ByteArrayToImage(prodPicByte);

                            info[0] = tbProdCode.Text;
                            info[1] = tbProdName.Text;
                            info[2] = tbProdInfo.Text;
                            info[3] = tbGender.Text; // id??
                            info[4] = tbProdCat.Text; //same
                            info[5] = tbProdSubCat.Text; // same

                            if (info[5] == "") info[5] = null;
                        }
                    }
                    connection.Close();
                    reader.Close();
                }
            }
        }

        private void GoBackToMainButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                                                                         
        private void ProdSaveButton_Click(object sender, EventArgs e)
        {
            if (Catalogue.infoClicked)
            {
                sqlString = "UPDATE product"
            }
            else
            {
                string role = "1";
                sqlString = "INSERT INTO cat_subcategory (category_id, subcategory_id) VALUES ('" + info[4] + "', '" + info[5] + "');" +
                            "INSERT INTO category_gender (cat_subcategory_id, gender_id) VALUES ('" + SignIn.GetLastId(role) + "', '" + info[3] + "');" +
                            "INSERT INTO product (product_code, product_name, product_info, @photo";
            }

            if (tbProdCode.Text != "" && info[0] != tbProdCode.Text)
            {
                MessageBox.Show("")
            }

            if (tbProdName.Text != "" && info[1] != tbProdName.Text)
            {

            }

            if (tbProdInfo.Text != "" && info[2] != tbProdInfo.Text)
            {

            }

            if (tbGender.Text != "" && info[3] != tbGender.Text)
            {

            }

            if (tbProdCat.Text != "" && info[4] != tbProdCat.Text)
            {

            }

            if ((tbProdSubCat.Text != "" || info[5] != tbProdSubCat.Text) && tbProdSubCat.Enabled == true)
            {

            }


            // запрос для изменения логотипа магазина
            string sqlExpression = "UPDATE product SET product_photo = @photo WHERE product_id = '" + Catalogue.prodID + "'";

            SqlConnection connection = new SqlConnection(SignIn.connectionString);

            try
            {
                // подключение к базе
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);

                command.Parameters.Add("@photo", SqlDbType.Image, prodPicByte.Length).Value = prodPicByte;

                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void ProdPhotoButton_Click(object sender, EventArgs e)
        {
            prodPicByte = MainShop.UploadPicture(prodPicByte);

            picPreview.Image = MainShop.ByteArrayToImage(prodPicByte);
            picPreview.Invalidate();

            this.Width = 477;

            prodPhotoButton.Left = 87;
            prodPhotoButton.Text = "Изменить фотографию";

            prodSaveButton.Left = 87;

            goBackToMainButton.Left = 233;
        }
    }
}
