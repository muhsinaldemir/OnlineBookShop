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
    public partial class PaymentForm : Form
    {
        UserClass user;

        public PaymentForm(UserClass user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            lblPaymentAmountValue.Text = ShoppingCartClass.calculateActualTotalPrice().ToString();
            lblPaymentAmountCashValue.Text = ShoppingCartClass.calculateActualTotalPrice().ToString();
        }

        private void makePayment(PaymentType paymentType)
        {
            ShoppingCartClass.placeOrder(user.customerID, ShoppingCartClass.calculateActualTotalPrice(), paymentType);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment is successful");
            makePayment(PaymentType.CreditCard);
            this.Close();
        }

        private void btnPaymentCash_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment is successful");
            makePayment(PaymentType.Cash);
            this.Close();
        }
    }
}
