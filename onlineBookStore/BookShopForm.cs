﻿using System;
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
        //SqlConnection connection = new SqlConnection(@"Server=tcp: oop2.database.windows.net;Database=bookshop; User ID = oop2admin@oop2.database.windows.net; Password=oop2_project;Trusted_Connection=False; Encrypt=True;");

        static DatabaseHelperClass dbHelper = DatabaseHelperClass.Instance; //SINGLETON PATTERN

        //SqlConnection connection = dbHelper.getConnection();

        UserClass user;

        public BookShopForm(UserClass user)
        {
            this.user = user;
            InitializeComponent();
        }

        public BookShopForm()
        {
            InitializeComponent();
        }

        private void BookShopForm_Load(object sender, EventArgs e)
        {
            //UserClass cs = new UserClass(); //SINGLETON PATTERN
            UserClass cs2 = CustomerClass.Instance;
            //Console.WriteLine("Ana Form'da" + user.name + " " + user.isAdmin() +" " );

        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            tabControlGeneral.SelectedTab = tabAdminPanel;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            bool operationResult = AdminUserClass.userOperations("Add", txtUserId.Text,txtName.Text, txtSurname.Text, txtAddress.Text, txtEmail.Text, txtUserName.Text, txtPassword.Text, cbIsAdmin.Checked ? true : false);

            if(operationResult)
            {
                MessageBox.Show("User added successfully", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Clear();
                txtSurname.Clear();
                txtAddress.Clear();
                txtEmail.Clear();
                txtUserName.Clear();
                txtPassword.Clear();
                cbIsAdmin.Checked = false;
            }
            else
            {
                MessageBox.Show("Error!");
              
            }

            ////connection.Close();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            ////connection.Open();
            SqlConnection connection = dbHelper.getConnection();
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
                MessageBox.Show("Book added successfully", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBookAuthor.Clear();
                txtBookIsbn.Clear();
                txtBookName.Clear();
                txtBookPage.Clear();
                txtBookPrice.Clear();
                txtBookPublisher.Clear();
                txtCoverPagePicture.Clear();
            }
            ////connection.Close();
        }

        private void btnAddMusicCDs_Click(object sender, EventArgs e)
        {
            ////connection.Open();
            SqlConnection connection = dbHelper.getConnection();
            SqlCommand command = new SqlCommand("INSERT INTO MusicCDsTable (name,price,singer,type) values(@name,@price,@singer,@type)", connection);
            command.Parameters.AddWithValue("@name", txtMusicName.Text);
            command.Parameters.AddWithValue("@price", txtMusicPrice.Text);
            command.Parameters.AddWithValue("@singer", txtMusicSinger.Text);
            command.Parameters.AddWithValue("@type", txtMusicType.Text);
          
            int affected = command.ExecuteNonQuery();

            if (affected == 0)
            {
                MessageBox.Show("Error not successful");
            }
            else
            {
                MessageBox.Show("Music CDs added successfully", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMusicName.Clear();
                txtMusicPrice.Clear();
                txtMusicSinger.Clear();
                txtMusicType.Clear();
            }
            ////connection.Close();

        }

        private void btnAddMagazine_Click(object sender, EventArgs e)
        {
            ////connection.Open();
            SqlConnection connection = dbHelper.getConnection();
            SqlCommand command = new SqlCommand("INSERT INTO MagazineTable (name,price,issue,type) values(@name,@price,@issue,@type)", connection);
            command.Parameters.AddWithValue("@name", txtMagazineName.Text);
            command.Parameters.AddWithValue("@price", txtMagazinePrice.Text);
            command.Parameters.AddWithValue("@issue", txtMagazineIssue.Text);
            command.Parameters.AddWithValue("@type", txtMagazineType.Text);

            int affected = command.ExecuteNonQuery();

            if (affected == 0)
            {
                MessageBox.Show("Error not successful","INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Magazine added successfully","INFORMATION",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtMagazineIssue.Clear();
                txtMagazineName.Clear();
                txtMagazinePrice.Clear();
                txtMagazineType.Clear();
            }
            ////connection.Close();
        }

        private void tabUser_Click(object sender, EventArgs e)
        {
            ////connection.Open();
            SqlConnection connection = dbHelper.getConnection();
            DataTable dt = new DataTable();
            {

                SqlDataAdapter command = new SqlDataAdapter(" select * FROM CustomerTable", connection);
                {
                    command.Fill(dt);
                    dgvUsers.DataSource = dt;
                }

            }
            ////connection.Close();
        }

        private void tabBooks_Click(object sender, EventArgs e)
        {

            ////connection.Open();
            SqlConnection connection = dbHelper.getConnection();

            DataTable dt = new DataTable();
            {

                SqlDataAdapter command = new SqlDataAdapter(" select * FROM BookTable", connection);
                {

                    command.Fill(dt);
                    dgvBooks.DataSource = dt;
                }

            }
            ////connection.Close();
        }

        private void tabMusics_Click(object sender, EventArgs e)
        {

            ////connection.Open();
            SqlConnection connection = dbHelper.getConnection();

            DataTable dt = new DataTable();
            {

                SqlDataAdapter command = new SqlDataAdapter(" select * FROM MusicCDsTable", connection);
                {

                    command.Fill(dt);
                    dgvMusicCDs.DataSource = dt;
                }

            }
            ////connection.Close();
        }

        private void tabMagazine_Click(object sender, EventArgs e)
        {
            ////connection.Open();
            SqlConnection connection = dbHelper.getConnection();

            DataTable dt = new DataTable();
            {

                SqlDataAdapter command = new SqlDataAdapter(" select * FROM MagazineTable", connection);
                {

                    command.Fill(dt);
                    dgvMagazine.DataSource = dt;
                }

            }
            ////connection.Close();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            SqlConnection connection = dbHelper.getConnection();

            bool operationResult = AdminUserClass.userDelete(txtUserId.Text);

            if (operationResult)
            {
                MessageBox.Show("User deleted successfully", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error!","INFORMATION",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedValue = dgvUsers.SelectedCells[0].RowIndex;
            string id = dgvUsers.Rows[selectedValue].Cells[0].Value.ToString();
            string name = dgvUsers.Rows[selectedValue].Cells[1].Value.ToString();
            string surname = dgvUsers.Rows[selectedValue].Cells[2].Value.ToString();
            string address = dgvUsers.Rows[selectedValue].Cells[3].Value.ToString();
            string email = dgvUsers.Rows[selectedValue].Cells[4].Value.ToString();
            string username = dgvUsers.Rows[selectedValue].Cells[5].Value.ToString();
            string password = dgvUsers.Rows[selectedValue].Cells[6].Value.ToString();
            bool isAdmin = (bool)dgvUsers.Rows[selectedValue].Cells[7].Value;

            txtUserId.Text = id;
            txtName.Text = name;
            txtSurname.Text = surname;
            txtAddress.Text = address;
            txtEmail.Text = email;
            txtUserName.Text = username;
            txtPassword.Text = password;
            if(isAdmin)
                cbIsAdmin.Checked = true;
            else
                cbIsAdmin.Checked = false;

        }

        private void btnDeleteBooks_Click(object sender, EventArgs e)
        {
            //connection.Open();
            SqlConnection connection = dbHelper.getConnection();

            SqlCommand deleteCommand = new SqlCommand("delete from BookTable where id=@id", connection);
            deleteCommand.Parameters.AddWithValue("@id", txtBookId.Text.ToString());
            deleteCommand.ExecuteNonQuery();
            int affected = 0;
            affected = deleteCommand.ExecuteNonQuery();
            /*  MessageBox.Show(affected.ToString());
              if (affected == 0)
              {
                  MessageBox.Show("Error not successful");


              }
              else
              {
                  MessageBox.Show("successfully deleted.");
              }*/
            //connection.Close();

            // listele();
        }

        private void btnDeleteMusicCDs_Click(object sender, EventArgs e)
        {
            //connection.Open();
            SqlConnection connection = dbHelper.getConnection();
            SqlCommand deleteCommand = new SqlCommand("delete from MusicCDsTable where id=@id", connection);
            deleteCommand.Parameters.AddWithValue("@id", txtMusicCDsId.Text.ToString());
            deleteCommand.ExecuteNonQuery();
            int affected = 0;
            affected = deleteCommand.ExecuteNonQuery();
            /*  MessageBox.Show(affected.ToString());
              if (affected == 0)
              {
                  MessageBox.Show("Error not successful");


              }
              else
              {
                  MessageBox.Show("successfully deleted.");
              }*/
            //connection.Close();

            // listele();
        }

        private void btnDeleteMagazine_Click(object sender, EventArgs e)
        {
            //connection.Open();
            SqlConnection connection = dbHelper.getConnection();
            SqlCommand deleteCommand = new SqlCommand("delete from MagazineTable where id=@id", connection);
            deleteCommand.Parameters.AddWithValue("@id", txtMagazineId.Text.ToString());
            deleteCommand.ExecuteNonQuery();
            int affected = 0;
            affected = deleteCommand.ExecuteNonQuery();
            /*  MessageBox.Show(affected.ToString());
              if (affected == 0)
              {
                  MessageBox.Show("Error not successful");


              }
              else
              {
                  MessageBox.Show("successfully deleted.");
              }*/
            //connection.Close();

            // listele();
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int selectedValue = dgvBooks.SelectedCells[0].RowIndex;
            string id = dgvBooks.Rows[selectedValue].Cells[0].Value.ToString();
            string name = dgvBooks.Rows[selectedValue].Cells[1].Value.ToString();
            string price = dgvBooks.Rows[selectedValue].Cells[2].Value.ToString();
            string isbn = dgvBooks.Rows[selectedValue].Cells[3].Value.ToString();
            string author = dgvBooks.Rows[selectedValue].Cells[4].Value.ToString();
            string publisher = dgvBooks.Rows[selectedValue].Cells[5].Value.ToString();
            string page = dgvBooks.Rows[selectedValue].Cells[6].Value.ToString();
            string cover_page_picture = dgvBooks.Rows[selectedValue].Cells[6].Value.ToString();

            txtBookId.Text = id;
            txtBookName.Text = name;
            txtBookPrice.Text = price;
            txtBookIsbn.Text = isbn;
            txtBookAuthor.Text = author;
            txtBookPublisher.Text = publisher;
            txtBookPage.Text = page;
            txtCoverPagePicture.Text = cover_page_picture;

        }

        private void dgvMusicCDs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedValue = dgvMusicCDs.SelectedCells[0].RowIndex;
            string id = dgvMusicCDs.Rows[selectedValue].Cells[0].Value.ToString();
            string name = dgvMusicCDs.Rows[selectedValue].Cells[1].Value.ToString();
            string price = dgvMusicCDs.Rows[selectedValue].Cells[2].Value.ToString();
            string singer = dgvMusicCDs.Rows[selectedValue].Cells[3].Value.ToString();
            string type = dgvMusicCDs.Rows[selectedValue].Cells[4].Value.ToString();
           

            txtMusicCDsId.Text = id;
            txtMusicName.Text = name;
            txtMusicPrice.Text = price;
            txtMusicSinger.Text = singer;
            txtMusicType.Text = type;
           
        }

        private void dgvMagazine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedValue = dgvMagazine.SelectedCells[0].RowIndex;
            string id = dgvMagazine.Rows[selectedValue].Cells[0].Value.ToString();
            string name = dgvMagazine.Rows[selectedValue].Cells[1].Value.ToString();
            string price = dgvMagazine.Rows[selectedValue].Cells[2].Value.ToString();
            string issue = dgvMagazine.Rows[selectedValue].Cells[3].Value.ToString();
            string type = dgvMagazine.Rows[selectedValue].Cells[4].Value.ToString();


            txtMagazineId.Text = id;
            txtMagazineName.Text = name;
            txtMagazinePrice.Text = price;
            txtMagazineIssue.Text = issue;
            txtMagazineType.Text = type;
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {

            bool operationResult = AdminUserClass.userOperations("Update", txtUserId.Text, txtName.Text, txtSurname.Text, txtAddress.Text, txtEmail.Text, txtUserName.Text, txtPassword.Text, cbIsAdmin.Checked ? true : false);

            if (operationResult)
            {
                MessageBox.Show("User Updated successfully");
                txtName.Clear();
                txtSurname.Clear();
                txtAddress.Clear();
                txtEmail.Clear();
                txtUserName.Clear();
                txtPassword.Clear();
                cbIsAdmin.Checked = false;
            }
            else
            {
                MessageBox.Show("Error!");
            }

        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            //connection.Open();
            SqlConnection connection = dbHelper.getConnection();
            SqlCommand command = new SqlCommand("UPDATE BookTable SET name=@name,price=@price,isbn=@isbn,author=@author,publisher=@publisher,page=@page,cover_page_picture=@cover_page_picture", connection);
            command.Parameters.AddWithValue("@id", txtBookId.Text.ToString());
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
                MessageBox.Show("Book updated successfully");
                txtBookAuthor.Clear();
                txtBookIsbn.Clear();
                txtBookName.Clear();
                txtBookPage.Clear();
                txtBookPrice.Clear();
                txtBookPublisher.Clear();
                txtCoverPagePicture.Clear();
            }
            //connection.Close();

        }

        private void btnUpdateMusicCDs_Click(object sender, EventArgs e)
        {
            //connection.Open();
            SqlConnection connection = dbHelper.getConnection();
            SqlCommand command = new SqlCommand("UPDATE MusicCDsTable SET name=@name,price=@price,singer=@singer,type=@type", connection);
            command.Parameters.AddWithValue("@id", txtMusicCDsId.Text.ToString());
            command.Parameters.AddWithValue("@name", txtMusicName.Text);
            command.Parameters.AddWithValue("@price", txtMusicPrice.Text);
            command.Parameters.AddWithValue("@singer", txtMusicSinger.Text);
            command.Parameters.AddWithValue("@type", txtMusicType.Text);

            int affected = command.ExecuteNonQuery();

            if (affected == 0)
            {
                MessageBox.Show("Error not successful");
            }
            else
            {
                MessageBox.Show("Music CDs updated successfully");
                txtMusicName.Clear();
                txtMusicPrice.Clear();
                txtMusicSinger.Clear();
                txtMusicType.Clear();
            }
            //connection.Close();

        }

        private void btnUpdateMagazine_Click(object sender, EventArgs e)
        {
            //connection.Open();
            SqlConnection connection = dbHelper.getConnection();
            SqlCommand command = new SqlCommand("UPDATE MagazineTable SET name=@name,price=@price,issue=@issue,type=@type", connection);
            command.Parameters.AddWithValue("@id", txtMagazineId.Text.ToString());
            command.Parameters.AddWithValue("@name", txtMagazineName.Text);
            command.Parameters.AddWithValue("@price", txtMagazinePrice.Text);
            command.Parameters.AddWithValue("@issue", txtMagazineIssue.Text);
            command.Parameters.AddWithValue("@type", txtMagazineType.Text);

            int affected = command.ExecuteNonQuery();

            if (affected == 0)
            {
                MessageBox.Show("Error not successful");
            }
            else
            {
                MessageBox.Show("Magazine updated successfully");
                txtMagazineIssue.Clear();
                txtMagazineName.Clear();
                txtMagazinePrice.Clear();
                txtMagazineType.Clear();
            }
            //connection.Close();

        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            tabControlGeneral.SelectedTab = tabHomePage;

        }

        private void populateHomePageBooks()
        {
            List<BookClass> allBooks = BookClass.getAllBooksFromDB();
            //flowLayoutPanel1.Controls.AddRange();

            BookUserControl[] bookUserControls = new BookUserControl[allBooks.Count];
            
            if (flpHomePage.Controls.Count > 0)
                flpHomePage.Controls.Clear();

            int i = 0;
            foreach(var item in allBooks)
            {
                bookUserControls[i] = new BookUserControl();
                bookUserControls[i].bookID = item.id;
                bookUserControls[i].bookName = item.name;
                bookUserControls[i].bookAuthor = item.author;
                bookUserControls[i].bookPrice = item.price;
                bookUserControls[i].stock = item.stock;
                flpHomePage.Controls.Add(bookUserControls[i]);
                i++;
            }
          
        }

        private void populateHomePageMusicCDs()
        {
            List<MusicCDsClass> allMusicCDs = MusicCDsClass.getAllMusicCDsFromDB();
            //flowLayoutPanel1.Controls.AddRange();

            MusicCDUserControl[] musicCDsUserControls = new MusicCDUserControl[allMusicCDs.Count];

            if (flpHomePage.Controls.Count > 0)
                flpHomePage.Controls.Clear();

            int i = 0;
            foreach (var item in allMusicCDs)
            {
                musicCDsUserControls[i] = new MusicCDUserControl();
                musicCDsUserControls[i].musicCDID = item.id;
                musicCDsUserControls[i].musicCDName = item.name;
                musicCDsUserControls[i].musicCDPrice = item.price;
                musicCDsUserControls[i].musicCDSinger = item.singer;
                musicCDsUserControls[i].stock = item.stock;
                flpHomePage.Controls.Add(musicCDsUserControls[i]);
                i++;
            }
        }

        private void populateHomePageMagazine()
        {
            
            List<MagazineClass> allmagazine = MagazineClass.getAllMagazineFromDB();
            //flowLayoutPanel1.Controls.AddRange();

            MagazineUserControl[] magazineUserControls = new MagazineUserControl[allmagazine.Count];

            if (flpHomePage.Controls.Count > 0)
                flpHomePage.Controls.Clear();

            int i = 0;
            foreach (var item in allmagazine)
            {
                magazineUserControls[i] = new MagazineUserControl();
                magazineUserControls[i].magazineID = item.id;
                magazineUserControls[i].magazineName = item.name;
                magazineUserControls[i].magazinePrice = item.price;
                magazineUserControls[i].magazineIssue = item.issue;
                magazineUserControls[i].stock = item.stock;
                flpHomePage.Controls.Add(magazineUserControls[i]);
                i++;
            }
        }


        private void btnHomepageBooks_Click(object sender, EventArgs e)
        {
            populateHomePageBooks();
        }

        private void btnHomepageMusicCDs_Click(object sender, EventArgs e)
        {
            populateHomePageMusicCDs();
        }

        private void btnHomepageMagazine_Click(object sender, EventArgs e)
        {
            populateHomePageMagazine();
        }

        public void populateShoppingCartPanelView()
        {
            ShoppingCartItemsUserControl[] shoppingCartItemsUserControl = new ShoppingCartItemsUserControl[ShoppingCartClass.itemsToPurchase.Count];

            if (flpShoppingCart.Controls.Count > 0)
                flpShoppingCart.Controls.Clear();

            int i = 0;
            //double totalPrice = 0;
            foreach (ItemToPurchaseClass item in ShoppingCartClass.itemsToPurchase)
            {
                shoppingCartItemsUserControl[i] = new ShoppingCartItemsUserControl();
                shoppingCartItemsUserControl[i].id = item.product.id;
                shoppingCartItemsUserControl[i].name = item.product.name;
                shoppingCartItemsUserControl[i].quantity = item.quantity;
                shoppingCartItemsUserControl[i].unitPriceValue = item.product.price;
                shoppingCartItemsUserControl[i].type = item.product.GetType();
                //shoppingCartItemsUserControl[i].totalPriceValue = item.stock;
                flpShoppingCart.Controls.Add(shoppingCartItemsUserControl[i]);
                //totalPrice += item.product.price * item.quantity;
                i++;
            }

            lblTotalPriceValueGeneral.Text = ShoppingCartClass.calculateActualTotalPrice().ToString();

        }
        
        private void btnShoppingCart_Click(object sender, EventArgs e)
        {
            populateShoppingCartPanelView();
            tabControlGeneral.SelectedTab = tabShoppingCart;
        }

        private void tabShoppingCart_Click(object sender, EventArgs e)
        {

        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            PaymentForm paymentForm = new PaymentForm(user);
            paymentForm.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }
    }
}
