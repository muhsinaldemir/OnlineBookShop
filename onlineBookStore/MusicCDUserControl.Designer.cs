namespace OnlineBookStore
{
    partial class MusicCDUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBookAddToCart = new System.Windows.Forms.Button();
            this.lblMusicCDPrice = new System.Windows.Forms.Label();
            this.lblMusicCDSinger = new System.Windows.Forms.Label();
            this.lblMusicCDName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblStock = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBookAddToCart
            // 
            this.btnBookAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookAddToCart.Location = new System.Drawing.Point(13, 232);
            this.btnBookAddToCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBookAddToCart.Name = "btnBookAddToCart";
            this.btnBookAddToCart.Size = new System.Drawing.Size(151, 46);
            this.btnBookAddToCart.TabIndex = 10;
            this.btnBookAddToCart.Text = "Add To Cart";
            this.btnBookAddToCart.UseVisualStyleBackColor = true;
            this.btnBookAddToCart.Click += new System.EventHandler(this.btnMusicCDsAddToCart_Click);
            // 
            // lblMusicCDPrice
            // 
            this.lblMusicCDPrice.AutoSize = true;
            this.lblMusicCDPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicCDPrice.Location = new System.Drawing.Point(35, 150);
            this.lblMusicCDPrice.Name = "lblMusicCDPrice";
            this.lblMusicCDPrice.Size = new System.Drawing.Size(71, 29);
            this.lblMusicCDPrice.TabIndex = 8;
            this.lblMusicCDPrice.Text = "Price";
            // 
            // lblMusicCDSinger
            // 
            this.lblMusicCDSinger.AutoSize = true;
            this.lblMusicCDSinger.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicCDSinger.Location = new System.Drawing.Point(31, 114);
            this.lblMusicCDSinger.Name = "lblMusicCDSinger";
            this.lblMusicCDSinger.Size = new System.Drawing.Size(86, 29);
            this.lblMusicCDSinger.TabIndex = 7;
            this.lblMusicCDSinger.Text = "Singer";
            // 
            // lblMusicCDName
            // 
            this.lblMusicCDName.AutoSize = true;
            this.lblMusicCDName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicCDName.Location = new System.Drawing.Point(28, 80);
            this.lblMusicCDName.Name = "lblMusicCDName";
            this.lblMusicCDName.Size = new System.Drawing.Size(81, 29);
            this.lblMusicCDName.TabIndex = 6;
            this.lblMusicCDName.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(55, 19);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 160);
            this.panel2.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(9, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 130);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.nudQuantity);
            this.panel3.Controls.Add(this.lblStock);
            this.panel3.Controls.Add(this.btnBookAddToCart);
            this.panel3.Controls.Add(this.lblMusicCDName);
            this.panel3.Controls.Add(this.lblMusicCDSinger);
            this.panel3.Controls.Add(this.lblMusicCDPrice);
            this.panel3.Location = new System.Drawing.Point(30, 110);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(222, 294);
            this.panel3.TabIndex = 12;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(36, 185);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(77, 29);
            this.lblStock.TabIndex = 11;
            this.lblStock.Text = "Stock";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudQuantity.Location = new System.Drawing.Point(170, 232);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(47, 45);
            this.nudQuantity.TabIndex = 12;
            this.nudQuantity.ValueChanged += new System.EventHandler(this.nudQuantity_ValueChanged);
            // 
            // MusicCDUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MusicCDUserControl";
            this.Size = new System.Drawing.Size(292, 426);
            this.Load += new System.EventHandler(this.MusicCDUserControl_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBookAddToCart;
        private System.Windows.Forms.Label lblMusicCDPrice;
        private System.Windows.Forms.Label lblMusicCDSinger;
        private System.Windows.Forms.Label lblMusicCDName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.NumericUpDown nudQuantity;
    }
}
