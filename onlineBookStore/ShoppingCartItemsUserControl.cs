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
        public string name { get; set; }
        public int quantity { get; set; }
        public double unitPriceValue { get; set; }
        private double totalPriceValue = 0;
        public double getTotalPriceValue()
        {
            return totalPriceValue;
        }

        public void setTotalPriceValue(double value)
        {
            totalPriceValue = value;
        }
        //public double totalPriceValue {
        //    get
        //    {
        //        return totalPriceValue;
        //    }
        //    set
        //    {
        //        totalPriceValue = 0;
        //    }
        //}


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
            totalPriceValue += (quantity * unitPriceValue);
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            var element =ShoppingCartClass.itemsToPurchase.Find(el => el.product.id == id);
            element.quantity = Convert.ToInt32(nudQuantity.Value);
            foreach(var item in ShoppingCartClass.itemsToPurchase)
            {
                Console.WriteLine("Quantity change : " + item.product.name + "  " + item.quantity);
            }
            ShoppingCartClass.debug2();
            lblTotalPriceValue.Text = (Convert.ToInt32(nudQuantity.Value) * unitPriceValue).ToString();

            BookShopForm bookShopForm = new BookShopForm();
            bookShopForm.lblTotalPriceValueGeneral.Text = ShoppingCartClass.calculateActualTotalPrice().ToString();
            //bookShopForm.lblTotalPriceValueGeneral.Text = "aaa";

            //lblTotalPriceValue.Text = (Convert.ToInt32(nudQuantity.Value) * unitPriceValue).ToString();
            //totalPriceValue = (quantity * unitPriceValue);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {          
            ShoppingCartClass.removeProduct(new ItemToPurchaseClass());
        }
    }
}
