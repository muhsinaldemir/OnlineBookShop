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
{    /// BookUserControl inherited from UserControl
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
        public string cover_page_picture { get; set; }
    
         ///adding to homepage from the added books in the admin panel.
        private void BookUserControl_Load(object sender, EventArgs e)
        {

            lblBookName.Text = bookName;
            lblBookAuthor.Text = bookAuthor;
            lblPrice.Text = bookPrice.ToString();
            lblStock.Text = stock.ToString();
            pbBook.ImageLocation = @"Resources\AllPictures\" + cover_page_picture;
        }
        /** @ brief adds the purchased book to the shopping cart
        * create a book from BookClass
        * and item added shoppingcartclass 
        */
        private void btnBookAddToCart_Click(object sender, EventArgs e)
        {
            BookClass book = new BookClass();
            book =BookClass.getaBooksFromDBByID(bookID);
            ShoppingCartClass.addProduct(new ItemToPurchaseClass(book, Convert.ToInt32(Math.Round(nudQuantity.Value, 0))));
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["BookShopForm"];
            int quantity = 0;
            foreach (var item in ShoppingCartClass.itemsToPurchase)
            {
                quantity += item.quantity;
            }
            ((BookShopForm)f).lblShoppinCartValue.Text = quantity.ToString();
            MessageBox.Show("Added to cart.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
