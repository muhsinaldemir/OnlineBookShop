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
    public partial class PaymentForm : Form, IMessageFilter
    {
        /// create new object user from UserClass
        UserClass user;
        /**   
         * @brief Default Constructor
         * Constructs the object with default parameters 
         * @param UserClass user
         */
        public PaymentForm(UserClass user)
        {
            this.user = user;
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
                string message = "Username " + user.userName + " Clicked object " + name + " at " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
                FileWriterClass.WriteFile(@"Logs\" + user.userName + "_clicklogs.txt", message);
                Console.WriteLine("Click {0}", message);
            }
            return false;
        }

        /**
         * call calculateActualTotalPrice() from ShoppingCartClass
         * and assign lblPaymentAmountValue and lblPaymentAmountCashValue
         */
        private void PaymentForm_Load(object sender, EventArgs e)
        {
            lblPaymentAmountValue.Text = ShoppingCartClass.calculateActualTotalPrice().ToString();
            lblPaymentAmountCashValue.Text = ShoppingCartClass.calculateActualTotalPrice().ToString();
        }
        /** @brief makePayment() function
         * @param PaymentType paymentType
         * call placeorder from ShoppingCartClass
         * placeorder() function have customerıd and paymenttype parameters
         */
        private void makePayment(PaymentType paymentType)
        {
            ShoppingCartClass.placeOrder(user.customerID, paymentType, ShoppingCartClass.calculateActualTotalPrice());
        }
      
         /// click credit card button 
        
        private void btnPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment is successful");
            makePayment(PaymentType.CreditCard);
            this.Close();
        }
       
        /// click cash button
        private void btnPaymentCash_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment is successful");
            makePayment(PaymentType.Cash);
            this.Close();
        }
    }
}
