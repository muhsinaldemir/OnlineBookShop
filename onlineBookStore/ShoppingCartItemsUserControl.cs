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
        public Type type;
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
            //foreach(var item in ShoppingCartClass.itemsToPurchase)
            //{
            //    Console.WriteLine("Quantity change : " + item.product.name + "  " + item.quantity);
            //}
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["BookShopForm"];
            ((BookShopForm)f).lblTotalPriceValueGeneral.Text = ShoppingCartClass.calculateActualTotalPrice().ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var element = ShoppingCartClass.itemsToPurchase.Find(el => (el.product.id == id && el.product.GetType() == type));
            ShoppingCartClass.removeProduct(element);
            Console.WriteLine("Type in remove " + type);
        }
    }
}
