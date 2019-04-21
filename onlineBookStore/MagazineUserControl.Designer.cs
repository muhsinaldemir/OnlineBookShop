namespace OnlineBookStore
{
    partial class MagazineUserControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblStock = new System.Windows.Forms.Label();
            this.btnMagazineAddToCart = new System.Windows.Forms.Button();
            this.lblMagazineName = new System.Windows.Forms.Label();
            this.lblMagazineIssue = new System.Windows.Forms.Label();
            this.lblMagazinePrice = new System.Windows.Forms.Label();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_author = new System.Windows.Forms.Label();
            this.lbl_book_name = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(82, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 160);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 130);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbl_stock);
            this.panel2.Controls.Add(this.lbl_price);
            this.panel2.Controls.Add(this.lbl_author);
            this.panel2.Controls.Add(this.lbl_book_name);
            this.panel2.Controls.Add(this.nudQuantity);
            this.panel2.Controls.Add(this.lblStock);
            this.panel2.Controls.Add(this.btnMagazineAddToCart);
            this.panel2.Controls.Add(this.lblMagazineName);
            this.panel2.Controls.Add(this.lblMagazineIssue);
            this.panel2.Controls.Add(this.lblMagazinePrice);
            this.panel2.Location = new System.Drawing.Point(24, 104);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 277);
            this.panel2.TabIndex = 8;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudQuantity.Location = new System.Drawing.Point(174, 206);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(58, 45);
            this.nudQuantity.TabIndex = 8;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(106, 157);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(77, 29);
            this.lblStock.TabIndex = 6;
            this.lblStock.Text = "Stock";
            // 
            // btnMagazineAddToCart
            // 
            this.btnMagazineAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMagazineAddToCart.Location = new System.Drawing.Point(24, 205);
            this.btnMagazineAddToCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMagazineAddToCart.Name = "btnMagazineAddToCart";
            this.btnMagazineAddToCart.Size = new System.Drawing.Size(144, 46);
            this.btnMagazineAddToCart.TabIndex = 5;
            this.btnMagazineAddToCart.Text = "Add To Cart";
            this.btnMagazineAddToCart.UseVisualStyleBackColor = true;
            this.btnMagazineAddToCart.Click += new System.EventHandler(this.btnMagazineAddToCart_Click);
            // 
            // lblMagazineName
            // 
            this.lblMagazineName.AutoSize = true;
            this.lblMagazineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMagazineName.Location = new System.Drawing.Point(104, 77);
            this.lblMagazineName.Name = "lblMagazineName";
            this.lblMagazineName.Size = new System.Drawing.Size(162, 25);
            this.lblMagazineName.TabIndex = 1;
            this.lblMagazineName.Text = "MagazineName";
            // 
            // lblMagazineIssue
            // 
            this.lblMagazineIssue.AutoSize = true;
            this.lblMagazineIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagazineIssue.Location = new System.Drawing.Point(106, 102);
            this.lblMagazineIssue.Name = "lblMagazineIssue";
            this.lblMagazineIssue.Size = new System.Drawing.Size(73, 29);
            this.lblMagazineIssue.TabIndex = 2;
            this.lblMagazineIssue.Text = "Issue";
            // 
            // lblMagazinePrice
            // 
            this.lblMagazinePrice.AutoSize = true;
            this.lblMagazinePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagazinePrice.Location = new System.Drawing.Point(106, 128);
            this.lblMagazinePrice.Name = "lblMagazinePrice";
            this.lblMagazinePrice.Size = new System.Drawing.Size(71, 29);
            this.lblMagazinePrice.TabIndex = 3;
            this.lblMagazinePrice.Text = "Price";
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Location = new System.Drawing.Point(37, 169);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(59, 17);
            this.lbl_stock.TabIndex = 15;
            this.lbl_stock.Text = "STOCK:";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(41, 139);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(52, 17);
            this.lbl_price.TabIndex = 14;
            this.lbl_price.Text = "PRİCE:";
            // 
            // lbl_author
            // 
            this.lbl_author.AutoSize = true;
            this.lbl_author.Location = new System.Drawing.Point(29, 109);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(71, 17);
            this.lbl_author.TabIndex = 13;
            this.lbl_author.Text = "AUTHOR:";
            // 
            // lbl_book_name
            // 
            this.lbl_book_name.AutoSize = true;
            this.lbl_book_name.Location = new System.Drawing.Point(3, 82);
            this.lbl_book_name.Name = "lbl_book_name";
            this.lbl_book_name.Size = new System.Drawing.Size(95, 17);
            this.lbl_book_name.TabIndex = 12;
            this.lbl_book_name.Text = "BOOK NAME:";
            // 
            // MagazineUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MagazineUserControl";
            this.Size = new System.Drawing.Size(337, 400);
            this.Load += new System.EventHandler(this.MagazineUserControl_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMagazineAddToCart;
        private System.Windows.Forms.Label lblMagazineName;
        private System.Windows.Forms.Label lblMagazineIssue;
        private System.Windows.Forms.Label lblMagazinePrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_author;
        private System.Windows.Forms.Label lbl_book_name;
    }
}
