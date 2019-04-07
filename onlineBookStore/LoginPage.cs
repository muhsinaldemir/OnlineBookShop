using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        if(txtUserName.Text!=" "&& txtPassword.Text!=" ")
            {
                if(txtUserName.Text=="admin"&& txtPassword.Text=="123456")//veritabanından cekilecek 
                {
                    BookShopForm bookShopForm = new BookShopForm(txtUserName.Text);
                    bookShopForm.Show();
                    this.Hide();
                   
                }
            }
        }
    }
}
