using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class MyAccountUserControl : UserControl
    {
        public string id { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public double unitPriceValue { get; set; }
        public string picture { get; set; }

        public MyAccountUserControl()
        {
            InitializeComponent();
        }

        private void MyAccountUserControl_Load(object sender, EventArgs e)
        {
            lblName.Text = name;
            lblMyAccountQuantity.Text = quantity.ToString();
            pbShoppingCart.ImageLocation = @"Resources\AllPictures\" + picture;
            lblUnitPriceValue.Text = unitPriceValue.ToString();
            lblTotalPriceValue.Text = (quantity * unitPriceValue).ToString();
        }

        private void pbCancelOrder_Click(object sender, EventArgs e)
        {
            ShoppingCartClass.cancelOrder(name,unitPriceValue);
        }
    }
}
