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
        private void MagazineUserControl_Load(object sender, EventArgs e)
        {
            lblMagazineName.Text = magazineName;
            lblMagazineIssue.Text = magazineIssue;
            lblMagazinePrice.Text = magazinePrice.ToString();
            lblStock.Text = stock.ToString();
        }

        private void btnMagazineAddToCart_Click(object sender, EventArgs e)
        {
            MagazineClass magazine = new MagazineClass();
            magazine = MagazineClass.getAMagazineFromDB(magazineID);
            ShoppingCartClass.addProduct(new ItemToPurchaseClass(magazine, Convert.ToInt32(Math.Round(nudQuantity.Value, 0))));
            MessageBox.Show("Added to cart.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
