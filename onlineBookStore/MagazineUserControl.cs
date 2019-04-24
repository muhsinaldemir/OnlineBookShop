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
    /// MagazineUserControl class inherited from UserControl class
    public partial class MagazineUserControl : UserControl
    {
        public MagazineUserControl()
        {
            InitializeComponent();
        }

        public string magazineID { get; set; }
        public string magazineName { get; set; }
        public string magazineIssue { get; set; }
        public double magazinePrice { get; set; }
        public int stock { get; set; }
        public string cover_page_picture { get; set; }

        ///adding a homepage to the added magazine in the admin panel.
        private void MagazineUserControl_Load(object sender, EventArgs e)
        {
            lblMagazineName.Text = magazineName;
            lblMagazineIssue.Text = magazineIssue;
            lblMagazinePrice.Text = magazinePrice.ToString();
            lblStock.Text = stock.ToString();
            pbMagazine.ImageLocation = @"Resources\AllPictures\" + cover_page_picture;

        }
        /** @ brief adds the purchased magzine to the shopping cart
        * create a magzine from MagazineClass
        * and item added shoppingcartclass 
        */
        private void btnMagazineAddToCart_Click(object sender, EventArgs e)
        {
            MagazineClass magazine = new MagazineClass();
            magazine = MagazineClass.getAMagazineFromDB(magazineID);
            ShoppingCartClass.addProduct(new ItemToPurchaseClass(magazine, Convert.ToInt32(Math.Round(nudQuantity.Value, 0))));
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["BookShopForm"];
            int quantity = 0;
            foreach (var item in ShoppingCartClass.itemsToPurchase)
            {
                quantity += item.quantity;
            }
            ((BookShopForm)f).lblShoppinCartValue.Text = quantity.ToString();
            MessageBox.Show("Added to cart.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
