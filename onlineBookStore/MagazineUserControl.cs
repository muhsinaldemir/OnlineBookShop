﻿using System;
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
    public partial class MagazineUserControl : UserControl
    {
        public MagazineUserControl()
        {
            InitializeComponent();
        }

        public string magazineID { get; set; }
        public string magazineName { get; set; }
        public string magazineIssue { get; set; }
        public double magazinePrice { get; set; }

        private void MagazineUserControl_Load(object sender, EventArgs e)
        {
            lblMagazineName.Text = magazineName;
            lblMagazineIssue.Text = magazineIssue;
            lblMagazinePrice.Text = magazinePrice.ToString();
        }
    }
}