using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace OnlineBookStore
{
    public partial class BookShopForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Server=tcp: oop2.database.windows.net;Database=bookshop; User ID = oop2admin@oop2.database.windows.net; Password=oop2_project;Trusted_Connection=False; Encrypt=True;");

        public BookShopForm()
        {
            InitializeComponent();
        }

        private void BookShopForm_Load(object sender, EventArgs e)
        {
         
        

        }

        private void btnOdemeBelgeleri_Click(object sender, EventArgs e)
        {
            tabControlGeneral.SelectedTab = tabAdminPanel;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO CustomerTable (name,surname,address,email,username,password) values(@name,@surname,@address,@email,@username,@password)", connection);
            command.Parameters.AddWithValue("@name", txtName.Text);
            command.Parameters.AddWithValue("@surname", txtSurname.Text);
            command.Parameters.AddWithValue("@address", txtAddress.Text);
            command.Parameters.AddWithValue("@email", txtEmail.Text);
            command.Parameters.AddWithValue("@username", txtUserName.Text);
            command.Parameters.AddWithValue("@password", txtPassword.Text);

            int affected = 0;
            affected=command.ExecuteNonQuery();

            if(affected==0)
            {
                MessageBox.Show("Error not successful");
            }
            else
            {
                MessageBox.Show("User added successfully");
              
                txtName.Clear();
                txtSurname.Clear();
                txtAddress.Clear();
                txtEmail.Clear();
                txtUserName.Clear();
                txtPassword.Clear();
            }

            connection.Close();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO BookTable (name,price,isbn,author,publisher,page,cover_page_picture) values(@name,@price,@isbn,@author,@publisher,@page,@cover_page_picture)", connection);
            command.Parameters.AddWithValue("@name", txtBookName.Text);
            command.Parameters.AddWithValue("@price", txtBookPrice.Text);
            command.Parameters.AddWithValue("@isbn", txtBookIsbn.Text);
            command.Parameters.AddWithValue("@author", txtBookAuthor.Text);
            command.Parameters.AddWithValue("@publisher", txtBookPublisher.Text);
            command.Parameters.AddWithValue("@page", txtBookPage.Text);
            command.Parameters.AddWithValue("@cover_page_picture", txtCoverPagePicture.Text);
            int affected = command.ExecuteNonQuery();

            if (affected == 0)
            {
                MessageBox.Show("Error not successful");
            }
            else
            {
                MessageBox.Show("User added successfully");
            }
            connection.Close();
        }
    }
}
