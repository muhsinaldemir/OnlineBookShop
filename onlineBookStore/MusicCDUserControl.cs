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
    public partial class MusicCDUserControl : UserControl
    {
        public string musicCDName { get; set; }
        public string musicCDAuthor { get; set; }
        public double musicCDPrice { get; set; }

        public MusicCDUserControl()
        {
            InitializeComponent();
        }

        private void MusicCDUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
