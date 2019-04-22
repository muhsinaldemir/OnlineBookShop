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
    public partial class ShoppingCartItemsUserControl : UserControl
    {
        public string id { get; set; }
        public string name { get;set;}
        public int quantity { get; set; }
        public double unitPriceValue { get; set; }
        public double totalPriceValue { get; set; }


        public ShoppingCartItemsUserControl()
        {
            InitializeComponent();
        }

        private void ShoppingCartItemsUserControl_Load(object sender, EventArgs e)
        {
            lblName.Text = name;
            nudQuantity.Value = quantity;
            lblUnitPriceValue.Text = unitPriceValue.ToString();
            lblTotalPriceValue.Text = (quantity * unitPriceValue).ToString();
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            lblTotalPriceValue.Text = (Convert.ToInt32(nudQuantity.Value) * unitPriceValue).ToString();
        }
    }
}
