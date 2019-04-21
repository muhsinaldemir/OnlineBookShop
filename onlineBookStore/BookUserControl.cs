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
    public partial class BookUserControl : UserControl
    {
        public BookUserControl()
        {
            InitializeComponent();
        }

        public string bookID { get; set; }
        public string bookName { get; set; }
        public string bookAuthor { get; set; }
        public double bookPrice { get; set; }
        public int stock { get; set; }
        private void BookUserControl_Load(object sender, EventArgs e)
        {
            lblBookName.Text = bookName;
            lblBookAuthor.Text = bookAuthor;
            lblPrice.Text = bookPrice.ToString();
            lblStock.Text = stock.ToString();
        }

        private void btnBookAddToCart_Click(object sender, EventArgs e)
        {
            BookClass book = new BookClass();
            book =BookClass.getaBooksFromDBByID(bookID);
            ItemToPurchaseClass.itemsToPurchase.Add(new ItemToPurchaseClass(book, Convert.ToInt32(Math.Round(nudQuantity.Value, 0))));

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
