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
using System.IO;

namespace OnlineBookStore
{
    public partial class BookShopForm : Form, IMessageFilter
    {
        ///dbHelper created from DatabaseHelperClass
        static DatabaseHelperClass dbHelper = DatabaseHelperClass.Instance; //SINGLETON PATTERN
        ///  user created from UserClass to send to BookShopForm's parameter.
        UserClass user;
        /**  @brief Default Constructor   
         * Constructs the object with default parameters  
         */
        int imageIndex = 1;
        public BookShopForm(UserClass user)
        {
            this.user = user;
            InitializeComponent();
            Application.AddMessageFilter(this);
            this.FormClosed += (o, e) => Application.RemoveMessageFilter(this);
        }

        public BookShopForm()
        {
            InitializeComponent();
            Application.AddMessageFilter(this);
            this.FormClosed += (o, e) => Application.RemoveMessageFilter(this);
        }


        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == 0x201 || m.Msg == 0x203)
            {  // Trap left click + double-click
                string name = "Unknown";
                Control ctl = Control.FromHandle(m.HWnd);
                if (ctl != null) name = ctl.Name;
                //Point pos = new Point(m.LParam.ToInt32());
                string message = "Username " + user.userName + " Clicked object " + name + " at " + DateTime.Now.ToLongDateString() + " "+ DateTime.Now.ToLongTimeString();
                FileWriterClass.WriteFile(AppConstants.LOG_FILE_LOCATION, message);
                Console.WriteLine("Click {0}", message);
            }
            return false;
        }


        /**  BookShopForm_Load() finds whether the user is admin or not.
         * If the user is admin, the admin panel and report panel'visibility will be true .
         * 
         */
        private void BookShopForm_Load(object sender, EventArgs e)
        {
            ShoppingCartClass.attach(new CustomerObserverClass());

            if(!user.isAdmin())
            {
                pbAdminPanel.Visible = false;
                pbReport.Visible = false;
            }
            lblGeneralUserName.Text = user.name + " " + user.surName;
            tabControlGeneral.SelectedTab = tabHomePage;
        }

        /// If tabcontrolgeneral is selected, tabadminpanel will open.
       
        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            tabControlGeneral.SelectedTab = tabAdminPanel;
        }
        /** @brief  buton add user
         *add user to create a user class and calls adminuserclass.useroperations. 
         * if it is not added, the error message is printed on the screen.
         * after adding,clears the textboxes.
         */
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            UserClass user;
            if (cbIsAdmin.Checked)
            {
                user = CustomerClass.Instance;
            }
            else
            {
                user = AdminUserClass.Instance;
            }
            bool operationResult = user.saveCustomer(txtUserId.Text, txtName.Text, txtSurname.Text, txtAddress.Text, txtEmail.Text, txtUserName.Text, txtPassword.Text, cbIsAdmin.Checked ? true : false);

            if (operationResult)
            {
                MessageBox.Show("User added successfully", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearUserControls();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }
        /** @brief click on the add  book button to print to the database.
         * writes the information entered to the textboxes into the database.
         * if it is not added book the database, the error message is printed on the screen.
         * after adding,clears the textboxes.
         */

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            SqlConnection connection = dbHelper.getConnection();
            SqlCommand command = new SqlCommand("INSERT INTO BookTable (name,price,stock,isbn,author,publisher,page,cover_page_picture) values(@name,@price,@stock,@isbn,@author,@publisher,@page,@cover_page_picture)", connection);

            command.Parameters.AddWithValue("@name", txtBookName.Text);
            command.Parameters.AddWithValue("@price", txtBookPrice.Text);
            command.Parameters.AddWithValue("@stock", txtBookStock.Text);
            command.Parameters.AddWithValue("@isbn", txtBookIsbn.Text);
            command.Parameters.AddWithValue("@author", txtBookAuthor.Text);
            command.Parameters.AddWithValue("@publisher", txtBookPublisher.Text);
            command.Parameters.AddWithValue("@page", txtBookPage.Text);
            command.Parameters.AddWithValue("@cover_page_picture", txtBookImage.Text);
            int affected = command.ExecuteNonQuery();

            if (affected == 0)
            {
                MessageBox.Show("Error not successful");
            }
            else
            {
                MessageBox.Show("Book added successfully", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearBookControls();
            }
        }
        /** @brief click on the add musicsCDs button to print to the database.
         * writes the information entered to the textboxes into the database.
         * if it is not added musicsCDs the database, the error message is printed on the screen.
         * after adding,clears the textboxes.
         */
        private void btnAddMusicCDs_Click(object sender, EventArgs e)
        {
            SqlConnection connection = dbHelper.getConnection();
            SqlCommand command = new SqlCommand("INSERT INTO MusicCDsTable (name,price,stock,singer,type,picture) values(@name,@price,@stock,@singer,@type,@picture)", connection);
            command.Parameters.AddWithValue("@name", txtMusicName.Text);
            command.Parameters.AddWithValue("@price", txtMusicPrice.Text);
            command.Parameters.AddWithValue("@stock", txtMusicCDsStock.Text);
            command.Parameters.AddWithValue("@singer", txtMusicSinger.Text);
            command.Parameters.AddWithValue("@type", txtMusicType.Text);
            command.Parameters.AddWithValue("@picture", txtMusicCDsImage.Text);
            int affected = command.ExecuteNonQuery();

            if (affected == 0)
            {
                MessageBox.Show("Error not successful");
            }
            else
            {
                MessageBox.Show("Music CDs added successfully", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearMusicCDsControl();
            }
        }
        /** @brief click on the add magazine button to print to the database.
        * writes the information entered to the textboxes into the database.
        * if it is not added magazine the database, the error message is printed on the screen.
        * after adding,clears the textboxes.
        */

        private void btnAddMagazine_Click(object sender, EventArgs e)
        {
            SqlConnection connection = dbHelper.getConnection();
            SqlCommand command = new SqlCommand("INSERT INTO MagazineTable (name,price,stock,issue,type,cover_page_picture) values(@name,@price,@stock,@issue,@type,@cover_page_picture)", connection);
            command.Parameters.AddWithValue("@name", txtMagazineName.Text);
            command.Parameters.AddWithValue("@price", txtMagazinePrice.Text);
            command.Parameters.AddWithValue("@stock", txtMagazineStock.Text);
            command.Parameters.AddWithValue("@issue", txtMagazineIssue.Text);
            command.Parameters.AddWithValue("@type", txtMagazineType.Text);
            command.Parameters.AddWithValue("@cover_page_picture", txtMagazineImage.Text);
            int affected = command.ExecuteNonQuery();

            if (affected == 0)
            {
                MessageBox.Show("Error not successful","INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Magazine added successfully","INFORMATION",MessageBoxButtons.OK,MessageBoxIcon.Information);
                clearMagazineControls();
            }
        }
        /**
         * finds the selected customer information in datagridview from  CustomerTable in the database.
         */
        private void tabUser_Click(object sender, EventArgs e)
        {
            SqlConnection connection = dbHelper.getConnection();
            DataTable dt = new DataTable();
            {

                SqlDataAdapter command = new SqlDataAdapter(" select * FROM CustomerTable", connection);
                {
                    command.Fill(dt);
                    dgvUsers.DataSource = dt;
                }
            }
        }
        /**
         * finds the selected book information in datagridview from  BookTable in the database.
         */
        private void tabBooks_Click(object sender, EventArgs e)
        {
            SqlConnection connection = dbHelper.getConnection();

            DataTable dt = new DataTable();
            {

                SqlDataAdapter command = new SqlDataAdapter(" select * FROM BookTable", connection);
                {
                    command.Fill(dt);
                    dgvBooks.DataSource = dt;
                }
            }
        }
        /**
         * finds the selected MusicCDs information in datagridview from  MusicCDsTable in the database.
         */
        private void tabMusics_Click(object sender, EventArgs e)
        {
            SqlConnection connection = dbHelper.getConnection();

            DataTable dt = new DataTable();
            {

                SqlDataAdapter command = new SqlDataAdapter(" select * FROM MusicCDsTable", connection);
                {

                    command.Fill(dt);
                    dgvMusicCDs.DataSource = dt;
                }
            }
        }
        /**
         * finds the selected magazine information in datagridview from  MagazineTable in the database.
         */

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
        }
        /** @brief button delete user
         * call userDelete() function in AdminUserClass
         * The parameter of the userDelete() function is id.
         */

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
        /**
        * finds the selected user information in datagridview
        * and prints this information to the corresponding textboxes.
        */
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
        /**
         * button delete books from the database
        */

        private void btnDeleteBooks_Click(object sender, EventArgs e)
        {
            SqlConnection connection = dbHelper.getConnection();

            SqlCommand deleteCommand = new SqlCommand("delete from BookTable where id=@id", connection);
            deleteCommand.Parameters.AddWithValue("@id", txtBookId.Text.ToString());
            deleteCommand.ExecuteNonQuery();
            int affected = 0;
            affected = deleteCommand.ExecuteNonQuery();
        }
        /**
         * button delete MusicCDs from the database
        */
        private void btnDeleteMusicCDs_Click(object sender, EventArgs e)
        {
            SqlConnection connection = dbHelper.getConnection();
            SqlCommand deleteCommand = new SqlCommand("delete from MusicCDsTable where id=@id", connection);
            deleteCommand.Parameters.AddWithValue("@id", txtMusicCDsId.Text.ToString());
            deleteCommand.ExecuteNonQuery();
            int affected = 0;
            // listele();
        } 
        /**
         * button delete MusicCDs from the database
        */

        private void btnDeleteMagazine_Click(object sender, EventArgs e)
        {
            SqlConnection connection = dbHelper.getConnection();
            SqlCommand deleteCommand = new SqlCommand("delete from MagazineTable where id=@id", connection);
            deleteCommand.Parameters.AddWithValue("@id", txtMagazineId.Text.ToString());
            deleteCommand.ExecuteNonQuery();
            int affected = 0;
            affected = deleteCommand.ExecuteNonQuery();
            // listele();
        }
        /**
        * finds the selected book information in datagridview 
        * and prints this information to the corresponding textboxes.
        */

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int selectedValue = dgvBooks.SelectedCells[0].RowIndex;
            string id = dgvBooks.Rows[selectedValue].Cells[0].Value.ToString();
            string name = dgvBooks.Rows[selectedValue].Cells[1].Value.ToString();
            string price = dgvBooks.Rows[selectedValue].Cells[2].Value.ToString();
            string stock= dgvBooks.Rows[selectedValue].Cells[3].Value.ToString();
            string isbn = dgvBooks.Rows[selectedValue].Cells[4].Value.ToString();
            string author = dgvBooks.Rows[selectedValue].Cells[5].Value.ToString();
            string publisher = dgvBooks.Rows[selectedValue].Cells[6].Value.ToString();
            string page = dgvBooks.Rows[selectedValue].Cells[7].Value.ToString();
            string cover_page_picture = dgvBooks.Rows[selectedValue].Cells[8].Value.ToString();

            txtBookId.Text = id;
            txtBookName.Text = name;
            txtBookPrice.Text = price;
            txtBookStock.Text = stock;
            txtBookIsbn.Text = isbn;
            txtBookAuthor.Text = author;
            txtBookPublisher.Text = publisher;
            txtBookPage.Text = page;
            txtBookImage.Text = cover_page_picture;
            pbBook.ImageLocation = @"Resources\AllPictures\" + cover_page_picture;

        }
        /**
        * finds the selected MusicCDs information in datagridview 
        * and prints this information to the corresponding textboxes.
        */

        private void dgvMusicCDs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedValue = dgvMusicCDs.SelectedCells[0].RowIndex;
            string id = dgvMusicCDs.Rows[selectedValue].Cells[0].Value.ToString();
            string name = dgvMusicCDs.Rows[selectedValue].Cells[1].Value.ToString();
            string price = dgvMusicCDs.Rows[selectedValue].Cells[2].Value.ToString();
            string stock= dgvMusicCDs.Rows[selectedValue].Cells[3].Value.ToString();
            string singer = dgvMusicCDs.Rows[selectedValue].Cells[4].Value.ToString();
            string type = dgvMusicCDs.Rows[selectedValue].Cells[5].Value.ToString();
           string picture = dgvMusicCDs.Rows[selectedValue].Cells[6].Value.ToString();

            txtMusicCDsId.Text = id;
            txtMusicName.Text = name;
            txtMusicPrice.Text = price;
            txtMusicCDsStock.Text = stock;
            txtMusicSinger.Text = singer;
            txtMusicType.Text = type;
            txtMusicCDsImage.Text = picture;
            pbMusic.ImageLocation=@"Resources\AllPictures\" + picture;
           
        }
        /**
        * finds the selected Magazine information in datagridview 
        * and prints this information to the corresponding textboxes.
        */
        private void dgvMagazine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedValue = dgvMagazine.SelectedCells[0].RowIndex;
            string id = dgvMagazine.Rows[selectedValue].Cells[0].Value.ToString();
            string name = dgvMagazine.Rows[selectedValue].Cells[1].Value.ToString();
            string price = dgvMagazine.Rows[selectedValue].Cells[2].Value.ToString();
            string stock= dgvMagazine.Rows[selectedValue].Cells[3].Value.ToString();
            string issue = dgvMagazine.Rows[selectedValue].Cells[4].Value.ToString();
            string type = dgvMagazine.Rows[selectedValue].Cells[5].Value.ToString();
            string cover_page_picture = dgvMagazine.Rows[selectedValue].Cells[6].Value.ToString();


            txtMagazineId.Text = id;
            txtMagazineName.Text = name;
            txtMagazinePrice.Text = price;
            txtMagazineStock.Text = stock;
            txtMagazineIssue.Text = issue;
            txtMagazineType.Text = type;
            txtMagazineImage.Text = cover_page_picture;
            pbMagazine.ImageLocation = @"Resources\AllPictures\"+ cover_page_picture;
        }
        /** @brief buton update user
         * call userOperations() function in AdminUserClass
         * The parameter of the userDelete() function is id,name,surname,address,email,username,password.
         */
        
        private void clearUserControls()
        {
            txtName.Clear();
            txtSurname.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            cbIsAdmin.Checked = false;
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {

            bool operationResult = AdminUserClass.userOperations("Update", txtUserId.Text, txtName.Text, txtSurname.Text, txtAddress.Text, txtEmail.Text, txtUserName.Text, txtPassword.Text, cbIsAdmin.Checked ? true : false);

            if (operationResult)
            {
                MessageBox.Show("User Updated successfully");
                clearUserControls();
            }
            else
            {
                MessageBox.Show("Error!");
            }

        }
        /// buton update book
        
        private void clearBookControls()
        {
            txtBookAuthor.Clear();
            txtBookIsbn.Clear();
            txtBookName.Clear();
            txtBookPage.Clear();
            txtBookPrice.Clear();
            txtBookStock.Clear();
            txtBookPublisher.Clear();
            txtBookImage.Clear();
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            SqlConnection connection = dbHelper.getConnection();
            SqlCommand command = new SqlCommand("UPDATE BookTable SET name=@name,price=@price,stock=@stock,isbn=@isbn,author=@author,publisher=@publisher,page=@page,cover_page_picture=@cover_page_picture WHERE id=@id", connection);
            command.Parameters.AddWithValue("@id", txtBookId.Text.ToString());
            command.Parameters.AddWithValue("@name", txtBookName.Text);
            command.Parameters.AddWithValue("@price", txtBookPrice.Text);
            command.Parameters.AddWithValue("@stock", txtBookStock.Text);
            command.Parameters.AddWithValue("@isbn", txtBookIsbn.Text);
            command.Parameters.AddWithValue("@author", txtBookAuthor.Text);
            command.Parameters.AddWithValue("@publisher", txtBookPublisher.Text);
            command.Parameters.AddWithValue("@page", txtBookPage.Text);
            command.Parameters.AddWithValue("@cover_page_picture", txtBookImage.Text);
            int affected = command.ExecuteNonQuery();

            if (affected == 0)
            {
                MessageBox.Show("Error not successful");
            }
            else
            {
                MessageBox.Show("Book updated successfully");
                clearBookControls();
            }
        }

        private void clearMusicCDsControl()
        {
            txtMusicName.Clear();
            txtMusicPrice.Clear();
            txtMusicCDsStock.Clear();
            txtMusicSinger.Clear();
            txtMusicType.Clear();
            txtMusicCDsImage.Clear();
        }
        private void btnUpdateMusicCDs_Click(object sender, EventArgs e)
        {
            SqlConnection connection = dbHelper.getConnection();
            SqlCommand command = new SqlCommand("UPDATE MusicCDsTable SET name=@name,price=@price,stock=@stock,singer=@singer,type=@type,picture=@picture WHERE id=@id", connection);
            command.Parameters.AddWithValue("@id", txtMusicCDsId.Text.ToString());
            command.Parameters.AddWithValue("@name", txtMusicName.Text);
            command.Parameters.AddWithValue("@price", txtMusicPrice.Text);
            command.Parameters.AddWithValue("@stock", txtMusicCDsStock.Text);
            command.Parameters.AddWithValue("@singer", txtMusicSinger.Text);
            command.Parameters.AddWithValue("@type", txtMusicType.Text);
            command.Parameters.AddWithValue("@picture", txtMusicCDsImage.Text);
            int affected = command.ExecuteNonQuery();

            if (affected == 0)
            {
                MessageBox.Show("Error not successful");
            }
            else
            {
                MessageBox.Show("Music CDs updated successfully");
                clearMusicCDsControl();
            }
        }

        private void clearMagazineControls()
        {
            txtMagazineIssue.Clear();
            txtMagazineName.Clear();
            txtMagazineStock.Clear();
            txtMagazinePrice.Clear();
            txtMagazineType.Clear();
            txtMagazineImage.Clear();
        }
        private void btnUpdateMagazine_Click(object sender, EventArgs e)
        {
            SqlConnection connection = dbHelper.getConnection();
            SqlCommand command = new SqlCommand("UPDATE MagazineTable SET name=@name,price=@price,stock=@stock,issue=@issue,type=@type,cover_page_picture=@cover_page_picture WHERE id=@id", connection);
            command.Parameters.AddWithValue("@id", txtMagazineId.Text.ToString());
            command.Parameters.AddWithValue("@name", txtMagazineName.Text);
            command.Parameters.AddWithValue("@price", txtMagazinePrice.Text);
            command.Parameters.AddWithValue("@stock", txtMagazineStock.Text);
            command.Parameters.AddWithValue("@issue", txtMagazineIssue.Text);
            command.Parameters.AddWithValue("@type", txtMagazineType.Text);
            command.Parameters.AddWithValue("@cover_page_picture", txtMagazineImage.Text);

            int affected = command.ExecuteNonQuery();

            if (affected == 0)
            {
                MessageBox.Show("Error not successful");
            }
            else
            {
                MessageBox.Show("Magazine updated successfully");
                clearMagazineControls();
            }
        }
        /// If tabcontrolgeneral is selected, tabhomepage will open.
        private void btnHomePage_Click(object sender, EventArgs e)
        {
            tabControlGeneral.SelectedTab = tabHomePage;

        }

        private void btnHomepageBooks_Click(object sender, EventArgs e)
        {
        }
        /// calls  populateHomePageMusicCDs() function
        private void btnHomepageMusicCDs_Click(object sender, EventArgs e)
        {
        }
        /// calls populateHomePageMagazine() function
        private void btnHomepageMagazine_Click(object sender, EventArgs e)
        {
        }

        private void changeAd()
        {
            if (imageIndex >= 5)
            { imageIndex = 1; }
            pbAd.ImageLocation = @"Resources\Ad\" + "Ad" + imageIndex +".png";
            Console.WriteLine(pbAd.ImageLocation);
            imageIndex = imageIndex + 1;
        }

        public void populateShoppingCartPanelView()
        {
            //ShoppingCartItemsUserControl[] shoppingCartItemsUserControl = new ShoppingCartItemsUserControl[ShoppingCartClass.itemsToPurchase.Count];
            //if (flpShoppingCart.Controls.Count > 0)
            //    flpShoppingCart.Controls.Clear();

            //int i = 0;
            //foreach (ItemToPurchaseClass item in ShoppingCartClass.itemsToPurchase)
            //{
            //    shoppingCartItemsUserControl[i] = new ShoppingCartItemsUserControl();
            //    shoppingCartItemsUserControl[i].id = item.product.id;
            //    shoppingCartItemsUserControl[i].name = item.product.name;
            //    shoppingCartItemsUserControl[i].quantity = item.quantity;
            //    shoppingCartItemsUserControl[i].unitPriceValue = item.product.price;
            //    shoppingCartItemsUserControl[i].type = item.product.GetType();
            //    shoppingCartItemsUserControl[i].picture = item.product.cover_page_picture;
            //    flpShoppingCart.Controls.Add(shoppingCartItemsUserControl[i]);
            //    i++;
            //}
            //lblTotalPriceValueGeneral.Text = ShoppingCartClass.calculateActualTotalPrice().ToString();
        }
      /// call populateShoppingCartPanelView() function
        private void btnShoppingCart_Click(object sender, EventArgs e)
        {
            populateShoppingCartPanelView();
            tabControlGeneral.SelectedTab = tabShoppingCart;
        }
        private void tabShoppingCart_Click(object sender, EventArgs e)
        {

        }
        /**
         * a new paymentform is created and show that on screen
        */
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            PaymentForm paymentForm = new PaymentForm(user);
            paymentForm.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }
        /// button add image book
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "All Files |*.png; *.jpeg;*.jpg| PNG Files (*.png)|*.png|JPEG Files (*.jpeg)|*.jpeg|JPG Files (*.jpg)|*.jpg";
            openFileDialog1.Title = "Dosya seçiniz.";
            openFileDialog1.ShowDialog();
            string filepath = openFileDialog1.FileName;
            string destPath = Application.StartupPath + @"\Resources\AllPictures\" + openFileDialog1.SafeFileName ;
            Directory.CreateDirectory(Application.StartupPath + @"\Resources\AllPictures\");
            File.Copy(filepath, destPath, true);
           
            pbBook.Image = Image.FromFile(filepath);
            txtBookImage.Text = openFileDialog1.SafeFileName ;


        }
        /// button add image musicCDs
        private void btnAddMusic_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofdMusic = new OpenFileDialog();
            ofdMusic.Multiselect = false;
            ofdMusic.Filter = "All Files |*.png; *.jpeg;*.jpg| PNG Files (*.png)|*.png|JPEG Files (*.jpeg)|*.jpeg|JPG Files (*.jpg)|*.jpg";
            ofdMusic.Title = "Dosya seçiniz.";
            ofdMusic.ShowDialog();
            string filepath = ofdMusic.FileName;
            string destPath = Application.StartupPath + @"\Resources\AllPictures\" + ofdMusic.SafeFileName;
            Directory.CreateDirectory(Application.StartupPath + @"\Resources\AllPictures\");
            File.Copy(filepath, destPath, true);

            pbMusic.Image = Image.FromFile(filepath);
            txtMusicCDsImage.Text = ofdMusic.SafeFileName;
        }
        /// button add image magazine
       
        private void btnAddImageMagazine_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdMagazine = new OpenFileDialog();
            ofdMagazine.Multiselect = false;
            ofdMagazine.Filter = "All Files |*.png; *.jpeg;*.jpg| PNG Files (*.png)|*.png|JPEG Files (*.jpeg)|*.jpeg|JPG Files (*.jpg)|*.jpg";
            ofdMagazine.Title = "Dosya seçiniz.";
            ofdMagazine.ShowDialog();
            string filepath = ofdMagazine.FileName;
            string destPath = Application.StartupPath + @"\Resources\AllPictures\" + ofdMagazine.SafeFileName;
            Directory.CreateDirectory(Application.StartupPath + @"\Resources\AllPictures\");
            File.Copy(filepath, destPath, true);

            pbMagazine.Image = Image.FromFile(filepath);
            txtMagazineImage.Text = ofdMagazine.SafeFileName;

        }

        private void pbHomePage_Click(object sender, EventArgs e)
        {
            tabControlGeneral.SelectedTab = tabHomePage;
            BookClass book = new BookClass();
            book.printProperties();
        }

        private void populateShoppingCartView()
        {
            ShoppingCartItemsUserControl[] shoppingCartItemsUserControl = new ShoppingCartItemsUserControl[ShoppingCartClass.itemsToPurchase.Count];
            shoppingCartItemsUserControl = ShoppingCartClass.printProducts();
            if (flpShoppingCart.Controls.Count > 0)
                flpShoppingCart.Controls.Clear();
            int i = 0;
            foreach (ItemToPurchaseClass item in ShoppingCartClass.itemsToPurchase)
            {
                flpShoppingCart.Controls.Add(shoppingCartItemsUserControl[i]);
                i++;
            }
            lblTotalPriceValueGeneral.Text = ShoppingCartClass.calculateActualTotalPrice().ToString();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            populateShoppingCartView();
            tabControlGeneral.SelectedTab = tabShoppingCart;
        }

        private void pbAdminPanel_Click(object sender, EventArgs e)
        {
            tabControlGeneral.SelectedTab = tabAdminPanel;
        }
        /** @brief button exit
         * if click exit button print message  on the screen ,
         * If yes is clicked, the application closes. 
         */

        private void pbExit_Click(object sender, EventArgs e)
        {
            const string message = "Really want to exit?";
            const string caption = "EXIT";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }
        /** dbHelper created from DatabaseHelperClass 
         * A list of list in the  ItemToPurchaseClass' getAllUserPurchases() function is created.
        * myAccountUserControls array is created from the  MyAccountUserControl
        * The size of  myAccountUserControls is up to the length of list
        */
        public void populateMyAccount()
        {
            //DatabaseHelperClass dbHelper = DatabaseHelperClass.Instance; //SINGLETON PATTERN
            //List<ItemToPurchaseClass> list =  dbHelper.getAllUserPurchases(Convert.ToInt32(user.customerID));
            //MyAccountUserControl[] myAccountUserControls = new MyAccountUserControl[list.Count];

            //if (flpMyAccount.Controls.Count > 0)
            //    flpMyAccount.Controls.Clear();

            //int i = 0;
            //foreach (ItemToPurchaseClass item in list)
            //{
            //    myAccountUserControls[i] = new MyAccountUserControl();
            //    myAccountUserControls[i].id = item.product.id;
            //    myAccountUserControls[i].name = item.product.name;
            //    myAccountUserControls[i].quantity = item.quantity;
            //    myAccountUserControls[i].unitPriceValue = item.product.price;
            //    myAccountUserControls[i].picture = item.product.cover_page_picture;
            //    flpMyAccount.Controls.Add(myAccountUserControls[i]);
            //    i++;
            //}
        }

        private void populateMyAccountView()
        {
            MyAccountUserControl[] myAccountUserControls = CustomerClass.printCustomerPurchases(user.customerID);
            if (flpMyAccount.Controls.Count > 0)
                flpMyAccount.Controls.Clear();

            int i = 0;
            foreach (var item in myAccountUserControls)
            {
                flpMyAccount.Controls.Add(myAccountUserControls[i]);
                i++;
            }



        }

        /** calls  populateMyAccount()
         * If tabcontrolgeneral is selected, tabMyAccount will open.
        */
        private void pbMyAccount_Click(object sender, EventArgs e)
        {
            //CustomerClass cUser = CustomerClass.Instance;
            //cUser.printCustomerPurchases(user.customerID);
            populateMyAccountView();
            tabControlGeneral.SelectedTab = tabMyAccount;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbMagazines_Click(object sender, EventArgs e)
        {
            MagazineClass magazine = new MagazineClass();
            magazine.printProperties();
        }

        private void pbBooks_Click(object sender, EventArgs e)
        {
            BookClass book = new BookClass();
            book.printProperties();
        }

        private void pbMusicCds_Click(object sender, EventArgs e)
        {
            MusicCDsClass music = new MusicCDsClass();
            music.printProperties();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            changeAd();
        }
    }
}
