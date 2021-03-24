using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace courseWork2
{
    public partial class Catalogue : Form
    {
        string sqlExtendGrid; // строка для добавления ограничений в запрос на заполнение таблицы

        public static int prodID;
        public static int[] prodIDArray;

        int numOfRows;

        public static string prodName;

        public static bool infoClicked = false;

        public Catalogue()
        {
            InitializeComponent();

            labelCat.Text = "Каталог магазина\n" + SignIn.userName.ToUpper();
            fullInfoProdButton.Text = "Выберите строку";
            fullInfoProdButton.Enabled = false;

            sqlExtendGrid = "";
            FillProdGrid();

            tbChooseCode.Text = "Артикул";
            tbChooseName.Text = "Название товара";
        }

        #region Функции

        public void GetNumOfRows()
        {
            string sqlExpression = "SELECT COUNT(*) " +
                "FROM product_address INNER JOIN " +
                    "dbo.store_address ON dbo.store_address.store_address_id = dbo.product_address.store_address_id " +
                "WHERE dbo.store_address.store_id = '" + SignIn.userID + "' AND dbo.product_address.store_product_amount IS NULL";

            using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        numOfRows = Convert.ToInt32(reader.GetValue(0));
                    }
                }

                connection.Close();
                reader.Close();
            }
        }

        public void FillProdGrid()
        {
            productGrid.Rows.Clear();

            string sqlExpression =
                "SELECT dbo.product.product_code, dbo.product.product_name, dbo.product.product_id " +
                "FROM dbo.store_address INNER JOIN " +
                    "dbo.product_address ON dbo.store_address.store_address_id = dbo.product_address.store_address_id INNER JOIN " +
                    "dbo.product_size ON dbo.product_address.product_size_id = dbo.product_size.product_size_id INNER JOIN " +
                    "dbo.product ON dbo.product_size.product_id = dbo.product.product_id " +
                "WHERE(dbo.store_address.store_id = '" + SignIn.userID + "' AND dbo.store_address.address_id IS NULL) " +
                    "AND (dbo.product_address.store_product_amount IS NULL) " + sqlExtendGrid + "" +
                    "ORDER BY dbo.product.product_code";

            GetNumOfRows();
            prodIDArray = new int[numOfRows];

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
                        productGrid.Rows.Add();
                        prodIDArray[i] = Convert.ToInt32(reader.GetValue(2));

                        for (int j = 0; j < 2; j++)
                        {
                            productGrid.Rows[i].Cells[j].Value = reader.GetValue(j).ToString();
                        }

                        i++;
                    }
                }
                connection.Close();
                reader.Close();
            }
        }

        #endregion

        #region Фильтры

        private void TbChooseCode_Enter(object sender, EventArgs e)
        {
            tbChooseCode.Text = "";
            applyFilterButton.Enabled = true;
        }

        private void TbChooseCode_Leave(object sender, EventArgs e)
        {
            if (tbChooseCode.Text == "")
            {
                tbChooseCode.Text = "Артикул";

                if (tbChooseName.Text == "Название товара")
                    applyFilterButton.Enabled = false;
            }
        }

        private void TbChooseName_Enter(object sender, EventArgs e)
        {
            tbChooseName.Text = "";
            applyFilterButton.Enabled = true;
        }

        private void TbChooseName_Leave(object sender, EventArgs e)
        {
            if (tbChooseName.Text == "")
            {
                tbChooseName.Text = "Название товара";

                if (tbChooseCode.Text == "Артикул")
                    applyFilterButton.Enabled = false;
            }
        }

        private void ApplyFilterButton_Click(object sender, EventArgs e)
        {
            if (applyFilterButton.Text == "Применить фильтр")
            {
                if (tbChooseName.Text != "" && tbChooseCode.Text != "" && tbChooseName.Text != "Название товара" && tbChooseCode.Text != "Артикул")
                {
                    sqlExtendGrid = " AND dbo.product.product_code = '" + tbChooseCode.Text + "' AND dbo.product.product_name LIKE '%" + tbChooseName.Text + "%'";
                }
                else if (tbChooseName.Text != "" && tbChooseName.Text != "Название товара")
                {
                    sqlExtendGrid = " AND dbo.product.product_name LIKE '%" + tbChooseName.Text + "%'";
                }
                else if (tbChooseCode.Text != "" && tbChooseCode.Text != "Артикул")
                {
                    sqlExtendGrid = " AND dbo.product.product_code = '" + tbChooseCode.Text + "'";
                }

                applyFilterButton.Text = "Отменить фильтр";
            }
            else if (applyFilterButton.Text == "Отменить фильтр")
            {
                sqlExtendGrid = "";

                tbChooseName.Text = "Название товара";
                tbChooseCode.Text = "Артикул";


                applyFilterButton.Text = "Применить фильтр";
                applyFilterButton.Enabled = false;
            }

            FillProdGrid();
        }

        #endregion
        #region Информация о товаре

        private void FullInfoProdButton_Click(object sender, EventArgs e)
        {
            infoClicked = true;

            Product Product = new Product();
            Product.Show();
        }

        private void AddNewProdButton_Click(object sender, EventArgs e)
        {
            infoClicked = false;

            Product Product = new Product();
            Product.Show();
        }

        private void AddToStoreButton_Click(object sender, EventArgs e)
        {
            prodName = productGrid.Rows[productGrid.CurrentRow.Index].Cells[1].Value.ToString();

            AddProductToStore AddProductToStore = new AddProductToStore();
            AddProductToStore.Show();
        }

        #endregion
        #region Таблица

        private void ProductGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (productGrid.Rows[productGrid.CurrentRow.Index].Cells[productGrid.CurrentCell.ColumnIndex].Value != null)
            {
                fullInfoProdButton.Enabled = true;
                fullInfoProdButton.Text = "Детали";

                addToStoreButton.Enabled = true;

                prodID = prodIDArray[productGrid.CurrentRow.Index];
            }
        }

        private void ProductGrid_Leave(object sender, EventArgs e)
        {
            if (!fullInfoProdButton.ContainsFocus && !addToStoreButton.ContainsFocus)
            {
                fullInfoProdButton.Enabled = false;
                fullInfoProdButton.Text = "Выберите строку";

                addToStoreButton.Enabled = false;

                prodID = 0;
            }
        }

        #endregion

        private void GoBackToMainButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FillProdGrid();
        }
    }
}
