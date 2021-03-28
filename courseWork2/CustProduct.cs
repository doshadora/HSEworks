using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace courseWork2
{
    public partial class CustProduct : Form
    {
        public CustProduct()
        {
            InitializeComponent();

            tbProdCode.Text = MainCust.prodInfo[MainCust.prodID, 0];
            tbProdInfo.Text = MainCust.prodInfo[MainCust.prodID, 2];
            tbProdName.Text = MainCust.prodInfo[MainCust.prodID, 1];
            tbPrice.Text = MainCust.prodInfo[MainCust.prodID, 6];

            prodPic.Image = MainCust.picArray[MainCust.prodID];
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {

        }
    }
}
