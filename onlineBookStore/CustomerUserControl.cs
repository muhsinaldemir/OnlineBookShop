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
    public partial class CustomerUserControl : UserControl
    {

        public string id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public double totalpayment { get; set; }
        public CustomerUserControl()
        {
            InitializeComponent();
        }

        private void CustomerUserControl_Load(object sender, EventArgs e)
        {
            lblNameValue.Text = name;
            lblSurnameValue.Text = surname;
            lblTotalAmountSpentValue.Text = totalpayment.ToString();
        }
    }
}
