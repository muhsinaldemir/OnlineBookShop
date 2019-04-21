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
            this.btnMusicCDsAddToCart = new System.Windows.Forms.Button();
            this.lblMusicCDPrice = new System.Windows.Forms.Label();
            this.lblMusicCDSinger = new System.Windows.Forms.Label();
            this.lblMusicCDName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblStock = new System.Windows.Forms.Label();
            this.lbl_musicCDs_stock = new System.Windows.Forms.Label();
            this.lbl_musicCDs_price = new System.Windows.Forms.Label();
            this.lbl_musicCDs_singer = new System.Windows.Forms.Label();
            this.lbl_musicCDs_name = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMusicCDsAddToCart
            // 
            this.btnMusicCDsAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusicCDsAddToCart.Location = new System.Drawing.Point(6, 211);
            this.btnMusicCDsAddToCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMusicCDsAddToCart.Name = "btnMusicCDsAddToCart";
            this.btnMusicCDsAddToCart.Size = new System.Drawing.Size(151, 46);
            this.btnMusicCDsAddToCart.TabIndex = 10;
            this.btnMusicCDsAddToCart.Text = "Add To Cart";
            this.btnMusicCDsAddToCart.UseVisualStyleBackColor = true;
            this.btnMusicCDsAddToCart.Click += new System.EventHandler(this.btnMusicCDsAddToCart_Click);
            // 
            // lblMusicCDPrice
            // 
            this.lblMusicCDPrice.AutoSize = true;
            this.lblMusicCDPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicCDPrice.Location = new System.Drawing.Point(135, 138);
            this.lblMusicCDPrice.Name = "lblMusicCDPrice";
            this.lblMusicCDPrice.Size = new System.Drawing.Size(71, 29);
            this.lblMusicCDPrice.TabIndex = 8;
            this.lblMusicCDPrice.Text = "Price";
            // 
            // lblMusicCDSinger
            // 
            this.lblMusicCDSinger.AutoSize = true;
            this.lblMusicCDSinger.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicCDSinger.Location = new System.Drawing.Point(135, 108);
            this.lblMusicCDSinger.Name = "lblMusicCDSinger";
            this.lblMusicCDSinger.Size = new System.Drawing.Size(86, 29);
            this.lblMusicCDSinger.TabIndex = 7;
            this.lblMusicCDSinger.Text = "Singer";
            // 
            // lblMusicCDName
            // 
            this.lblMusicCDName.AutoSize = true;
            this.lblMusicCDName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicCDName.Location = new System.Drawing.Point(135, 79);
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
            this.panel2.Location = new System.Drawing.Point(104, 28);
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
            this.panel3.Controls.Add(this.lbl_musicCDs_stock);
            this.panel3.Controls.Add(this.lbl_musicCDs_price);
            this.panel3.Controls.Add(this.lbl_musicCDs_singer);
            this.panel3.Controls.Add(this.lbl_musicCDs_name);
            this.panel3.Controls.Add(this.nudQuantity);
            this.panel3.Controls.Add(this.lblStock);
            this.panel3.Controls.Add(this.btnMusicCDsAddToCart);
            this.panel3.Controls.Add(this.lblMusicCDName);
            this.panel3.Controls.Add(this.lblMusicCDSinger);
            this.panel3.Controls.Add(this.lblMusicCDPrice);
            this.panel3.Location = new System.Drawing.Point(30, 110);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 294);
            this.panel3.TabIndex = 12;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudQuantity.Location = new System.Drawing.Point(169, 211);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(47, 45);
            this.nudQuantity.TabIndex = 12;
            this.nudQuantity.ValueChanged += new System.EventHandler(this.nudQuantity_ValueChanged);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(135, 167);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(77, 29);
            this.lblStock.TabIndex = 11;
            this.lblStock.Text = "Stock";
            // 
            // lbl_musicCDs_stock
            // 
            this.lbl_musicCDs_stock.AutoSize = true;
            this.lbl_musicCDs_stock.Location = new System.Drawing.Point(64, 174);
            this.lbl_musicCDs_stock.Name = "lbl_musicCDs_stock";
            this.lbl_musicCDs_stock.Size = new System.Drawing.Size(59, 17);
            this.lbl_musicCDs_stock.TabIndex = 19;
            this.lbl_musicCDs_stock.Text = "STOCK:";
            // 
            // lbl_musicCDs_price
            // 
            this.lbl_musicCDs_price.AutoSize = true;
            this.lbl_musicCDs_price.Location = new System.Drawing.Point(70, 149);
            this.lbl_musicCDs_price.Name = "lbl_musicCDs_price";
            this.lbl_musicCDs_price.Size = new System.Drawing.Size(52, 17);
            this.lbl_musicCDs_price.TabIndex = 18;
            this.lbl_musicCDs_price.Text = "PRICE:";
            // 
            // lbl_musicCDs_singer
            // 
            this.lbl_musicCDs_singer.AutoSize = true;
            this.lbl_musicCDs_singer.Location = new System.Drawing.Point(56, 119);
            this.lbl_musicCDs_singer.Name = "lbl_musicCDs_singer";
            this.lbl_musicCDs_singer.Size = new System.Drawing.Size(64, 17);
            this.lbl_musicCDs_singer.TabIndex = 17;
            this.lbl_musicCDs_singer.Text = "SINGER:";
            // 
            // lbl_musicCDs_name
            // 
            this.lbl_musicCDs_name.AutoSize = true;
            this.lbl_musicCDs_name.Location = new System.Drawing.Point(3, 90);
            this.lbl_musicCDs_name.Name = "lbl_musicCDs_name";
            this.lbl_musicCDs_name.Size = new System.Drawing.Size(117, 17);
            this.lbl_musicCDs_name.TabIndex = 16;
            this.lbl_musicCDs_name.Text = "MusicCDs NAME:";
            // 
            // MusicCDUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MusicCDUserControl";
            this.Size = new System.Drawing.Size(368, 418);
            this.Load += new System.EventHandler(this.MusicCDUserControl_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMusicCDsAddToCart;
        private System.Windows.Forms.Label lblMusicCDPrice;
        private System.Windows.Forms.Label lblMusicCDSinger;
        private System.Windows.Forms.Label lblMusicCDName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lbl_musicCDs_stock;
        private System.Windows.Forms.Label lbl_musicCDs_price;
        private System.Windows.Forms.Label lbl_musicCDs_singer;
        private System.Windows.Forms.Label lbl_musicCDs_name;
    }
}
