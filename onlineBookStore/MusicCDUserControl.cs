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
    public partial class MusicCDUserControl : UserControl
    {
        public string musicCDID { get; set; }
        public string musicCDName { get; set; }
        public string musicCDSinger { get; set; }
        public double musicCDPrice { get; set; }
        public int stock { get; set; }

        public MusicCDUserControl()
        {
            InitializeComponent();
        }

        private void MusicCDUserControl_Load(object sender, EventArgs e)
        {
            lblMusicCDName.Text = musicCDName;
            lblMusicCDPrice.Text = musicCDPrice.ToString();
            lblMusicCDSinger.Text = musicCDSinger;
            lblStock.Text = stock.ToString();
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnMusicCDsAddToCart_Click(object sender, EventArgs e)
        {
            MusicCDsClass musicCDs = new MusicCDsClass();
            musicCDs = MusicCDsClass.getAMusicCDsFromDB(musicCDID);
            ShoppingCartClass.addProduct(new ItemToPurchaseClass(musicCDs, Convert.ToInt32(Math.Round(nudQuantity.Value, 0))));
        }
    }
}
