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

        private void BookUserControl_Load(object sender, EventArgs e)
        {
            lblBookName.Text = bookName;
            lblBookAuthor.Text = bookAuthor;
            lblPrice.Text = bookPrice.ToString();
        }
    }
}
