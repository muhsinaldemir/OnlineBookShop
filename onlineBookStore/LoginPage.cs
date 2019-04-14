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
    public partial class LoginPage : Form
    {
        SqlConnection connection = new SqlConnection(@"Server=tcp: oop2.database.windows.net;Database=bookshop; User ID = oop2admin@oop2.database.windows.net; Password=oop2_project;Trusted_Connection=False; Encrypt=True;");
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if(txtUserName.Text==""|| txtPassword.Text=="")
            {
                MessageBox.Show("username or password should not be empty!");
            }
            else
            {
                CustomerClass cs = CustomerClass.Instance; //SINGLETON PATTERN
                connection.Open();
                SqlCommand commandCustomer = new SqlCommand("Select * from CustomerTable WHERE username=@username AND password=@password", connection);
                commandCustomer.Parameters.AddWithValue("@username", txtUserName.Text);
                commandCustomer.Parameters.AddWithValue("@password", txtPassword.Text);

                SqlDataReader readCustomer = commandCustomer.ExecuteReader();

                if (readCustomer != null)
                {
                    while (readCustomer.Read())
                    {
                        cs.customerID = readCustomer["id"].ToString();
                        cs.name = readCustomer["name"].ToString();
                        cs.surName = readCustomer["surname"].ToString();
                        cs.address = readCustomer["address"].ToString();
                        cs.email = readCustomer["email"].ToString();
                        cs.userName = readCustomer["username"].ToString();
                        cs.password = readCustomer["password"].ToString();

                        Console.WriteLine(cs.email);
                    }

                    connection.Close();
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
           if( txtPassword.PasswordChar=='*')
            {
                txtPassword.PasswordChar = '\0';
            }
           else if(txtPassword.PasswordChar=='\0')
            {
                txtPassword.PasswordChar = '*';
            }

        }
    }
}