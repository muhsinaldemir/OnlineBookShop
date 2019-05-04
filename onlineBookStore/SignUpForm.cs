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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void clearUserControls()
        {
            txtName.Clear();
            txtSurname.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            UserClass user = CustomerClass.Instance;

            bool operationResult = user.saveCustomer(null, txtName.Text, txtSurname.Text, txtAddress.Text, txtEmail.Text, txtUserName.Text, txtPassword.Text, false);

            if (operationResult)
            {
                MessageBox.Show("You signed up successfully, Please wait for approval", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearUserControls();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void pbLoginExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //SignUpForm formSignUp = new SignUpForm();
            //formSignUp.Show();
        }
    }
}
