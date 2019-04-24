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
{/// MusicCDUserControl inherited from UserControl
    public partial class MusicCDUserControl : UserControl
    {
        public string musicCDID { get; set; }
        public string musicCDName { get; set; }
        public string musicCDSinger { get; set; }
        public double musicCDPrice { get; set; }
        public int stock { get; set; }
        public string picture { get; set; }

        public MusicCDUserControl()
        {
            InitializeComponent();
        }
        ///adding a homepage to the added musicCDs in the admin panel.
        private void MusicCDUserControl_Load(object sender, EventArgs e)
        {
            lblMusicCDName.Text = musicCDName;
            lblMusicCDPrice.Text = musicCDPrice.ToString();
            lblMusicCDSinger.Text = musicCDSinger;
            lblStock.Text = stock.ToString();
            pbMusicCDs.ImageLocation = @"Resources\AllPictures\" + picture;
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {

        }
        /** @ brief adds the purchased musicCDs to the shopping cart
        * create a book from MusicCDsClass
        * and item added shoppingcartclass 
        */

        private void btnMusicCDsAddToCart_Click(object sender, EventArgs e)
        {
            MusicCDsClass musicCDs = new MusicCDsClass();
            musicCDs = MusicCDsClass.getAMusicCDsFromDB(musicCDID);
            ShoppingCartClass.addProduct(new ItemToPurchaseClass(musicCDs, Convert.ToInt32(Math.Round(nudQuantity.Value, 0))));
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["BookShopForm"];
            int quantity = 0;
            foreach (var item in ShoppingCartClass.itemsToPurchase)
            {
                quantity += item.quantity;
            }
            ((BookShopForm)f).lblShoppinCartValue.Text = quantity.ToString();
            MessageBox.Show("Added to cart.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
