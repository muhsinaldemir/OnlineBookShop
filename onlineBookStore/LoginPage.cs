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
    public partial class LoginPage : Form, IMessageFilter
    {
        SqlConnection connection = new SqlConnection(@"Server=tcp: oop2.database.windows.net;Database=bookshop; User ID = oop2admin@oop2.database.windows.net; Password=oop2_project;Trusted_Connection=False; Encrypt=True;");
        public LoginPage()
        {
            InitializeComponent();
            Application.AddMessageFilter(this);
            this.FormClosed += (o, e) => Application.RemoveMessageFilter(this);
        }
        /**
         * click the login button if usernam and password are correct ,opens bookshopform
         * and read customer's information from database
         */ 
        private void btnLogin_Click(object sender, EventArgs e)
        {

            if(txtUserName.Text==""|| txtPassword.Text=="")
            {
                MessageBox.Show("username or password should not be empty!");
            }
            else
            {
                UserClass cs = null;
               connection.Open();
                SqlCommand commandCustomer = new SqlCommand("Select * from CustomerTable WHERE username=@username AND password=@password", connection);
                commandCustomer.Parameters.AddWithValue("@username", txtUserName.Text);
                commandCustomer.Parameters.AddWithValue("@password", txtPassword.Text);

                SqlDataReader readCustomer = commandCustomer.ExecuteReader();

                if (readCustomer != null)
                {
                    while (readCustomer.Read())
                    {
                        bool isAdmin = (bool)readCustomer["isadmin"];
                        if (!isAdmin)
                            cs = CustomerClass.Instance; //SINGLETON PATTERN
                        else
                            cs = AdminUserClass.Instance;
                        cs.customerID = readCustomer["id"].ToString();
                        cs.name = readCustomer["name"].ToString();
                        cs.surName = readCustomer["surname"].ToString();
                        cs.address = readCustomer["address"].ToString();
                        cs.email = readCustomer["email"].ToString();
                        cs.userName = readCustomer["username"].ToString();
                        cs.password = readCustomer["password"].ToString();
                        cs.IsAdmin = (bool)readCustomer["isadmin"];
                    }
                    connection.Close();
                    ShoppingCartClass shoppingCartClass = ShoppingCartClass.Instance; //SINGLETON PATTERN
                    ShoppingCartClass.customerID = cs.customerID;
                    ShoppingCartClass.user = cs;
                    BookShopForm bookShopForm = new BookShopForm(cs);
                    bookShopForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("username or password is not correct!");
                }
            }
        }
        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void btnPasswordVisible_Click(object sender, EventArgs e)
        {

        }
        ///if click on the picturebox password visible 
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
            }
            else if (txtPassword.PasswordChar == '\0')
            {
                txtPassword.PasswordChar = '*';
            }

        }

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == 0x201 || m.Msg == 0x203)
            {  // Trap left click + double-click
                string name = "Unknown";
                Control ctl = Control.FromHandle(m.HWnd);
                if (ctl != null) name = ctl.Name;
                //Point pos = new Point(m.LParam.ToInt32());
                string message = "A click occurred in Login Page at " + name + " at " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
                //FileWriterClass.WriteFile(AppConstants.LOG_FILE_LOCATION, message);
                //Console.WriteLine("Click {0}", message);
            }
            return false;
        }

        /// change form application width in left direction
        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {
            panelLogin.Left = (this.ClientSize.Width - panelLogin.Width) / 2;
            panelLogin.Top=(this.ClientSize.Height-panelLogin.Height)/ 2;
        }
        /// change loginpage's size application width in left direction 
        private void LoginPage_SizeChanged(object sender, EventArgs e)
        {
            panelLogin.Left = (this.ClientSize.Width - panelLogin.Width) / 2;
            panelLogin.Top = (this.ClientSize.Height - panelLogin.Height) / 2;
        }
    }
}
