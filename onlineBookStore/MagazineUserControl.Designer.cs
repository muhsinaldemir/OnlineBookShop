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
            this.btnBookAddToCart = new System.Windows.Forms.Button();
            this.lblMagazineName = new System.Windows.Forms.Label();
            this.lblMagazineIssue = new System.Windows.Forms.Label();
            this.lblMagazinePrice = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(55, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 200);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 163);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnBookAddToCart);
            this.panel2.Controls.Add(this.lblMagazineName);
            this.panel2.Controls.Add(this.lblMagazineIssue);
            this.panel2.Controls.Add(this.lblMagazinePrice);
            this.panel2.Location = new System.Drawing.Point(27, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 304);
            this.panel2.TabIndex = 8;
            // 
            // btnBookAddToCart
            // 
            this.btnBookAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookAddToCart.Location = new System.Drawing.Point(22, 227);
            this.btnBookAddToCart.Name = "btnBookAddToCart";
            this.btnBookAddToCart.Size = new System.Drawing.Size(209, 58);
            this.btnBookAddToCart.TabIndex = 5;
            this.btnBookAddToCart.Text = "Add To Cart";
            this.btnBookAddToCart.UseVisualStyleBackColor = true;
            // 
            // lblMagazineName
            // 
            this.lblMagazineName.AutoSize = true;
            this.lblMagazineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagazineName.Location = new System.Drawing.Point(26, 90);
            this.lblMagazineName.Name = "lblMagazineName";
            this.lblMagazineName.Size = new System.Drawing.Size(233, 36);
            this.lblMagazineName.TabIndex = 1;
            this.lblMagazineName.Text = "MagazineName";
            // 
            // lblMagazineIssue
            // 
            this.lblMagazineIssue.AutoSize = true;
            this.lblMagazineIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagazineIssue.Location = new System.Drawing.Point(30, 133);
            this.lblMagazineIssue.Name = "lblMagazineIssue";
            this.lblMagazineIssue.Size = new System.Drawing.Size(86, 36);
            this.lblMagazineIssue.TabIndex = 2;
            this.lblMagazineIssue.Text = "Issue";
            // 
            // lblMagazinePrice
            // 
            this.lblMagazinePrice.AutoSize = true;
            this.lblMagazinePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagazinePrice.Location = new System.Drawing.Point(33, 177);
            this.lblMagazinePrice.Name = "lblMagazinePrice";
            this.lblMagazinePrice.Size = new System.Drawing.Size(83, 36);
            this.lblMagazinePrice.TabIndex = 3;
            this.lblMagazinePrice.Text = "Price";
            // 
            // MagazineUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "MagazineUserControl";
            this.Size = new System.Drawing.Size(319, 455);
            this.Load += new System.EventHandler(this.MagazineUserControl_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBookAddToCart;
        private System.Windows.Forms.Label lblMagazineName;
        private System.Windows.Forms.Label lblMagazineIssue;
        private System.Windows.Forms.Label lblMagazinePrice;
    }
}
