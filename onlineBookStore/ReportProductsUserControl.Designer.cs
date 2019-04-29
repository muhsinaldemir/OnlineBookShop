namespace OnlineBookStore
{
    partial class ReportProductsUserControl
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
            this.lblMyAccountQuantity = new System.Windows.Forms.Label();
            this.lblUnitPriceValue = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbShoppingCart = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShoppingCart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMyAccountQuantity
            // 
            this.lblMyAccountQuantity.AutoSize = true;
            this.lblMyAccountQuantity.BackColor = System.Drawing.Color.White;
            this.lblMyAccountQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMyAccountQuantity.Location = new System.Drawing.Point(283, 60);
            this.lblMyAccountQuantity.Name = "lblMyAccountQuantity";
            this.lblMyAccountQuantity.Size = new System.Drawing.Size(60, 24);
            this.lblMyAccountQuantity.TabIndex = 33;
            this.lblMyAccountQuantity.Text = "label1";
            // 
            // lblUnitPriceValue
            // 
            this.lblUnitPriceValue.AutoSize = true;
            this.lblUnitPriceValue.BackColor = System.Drawing.Color.White;
            this.lblUnitPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnitPriceValue.Location = new System.Drawing.Point(393, 60);
            this.lblUnitPriceValue.Name = "lblUnitPriceValue";
            this.lblUnitPriceValue.Size = new System.Drawing.Size(60, 24);
            this.lblUnitPriceValue.TabIndex = 31;
            this.lblUnitPriceValue.Text = "label1";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.BackColor = System.Drawing.Color.White;
            this.lblUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnitPrice.Location = new System.Drawing.Point(376, 28);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(90, 24);
            this.lblUnitPrice.TabIndex = 29;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.White;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuantity.Location = new System.Drawing.Point(265, 28);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(99, 24);
            this.lblQuantity.TabIndex = 28;
            this.lblQuantity.Text = "Total Sold ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(127, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 24);
            this.lblName.TabIndex = 27;
            this.lblName.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbShoppingCart);
            this.panel1.Location = new System.Drawing.Point(14, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(107, 109);
            this.panel1.TabIndex = 26;
            // 
            // pbShoppingCart
            // 
            this.pbShoppingCart.Location = new System.Drawing.Point(9, 15);
            this.pbShoppingCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbShoppingCart.Name = "pbShoppingCart";
            this.pbShoppingCart.Size = new System.Drawing.Size(84, 74);
            this.pbShoppingCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShoppingCart.TabIndex = 0;
            this.pbShoppingCart.TabStop = false;
            // 
            // ReportProductsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblMyAccountQuantity);
            this.Controls.Add(this.lblUnitPriceValue);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panel1);
            this.Name = "ReportProductsUserControl";
            this.Size = new System.Drawing.Size(509, 136);
            this.Load += new System.EventHandler(this.ReportProductsUserControl_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbShoppingCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMyAccountQuantity;
        private System.Windows.Forms.Label lblUnitPriceValue;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbShoppingCart;
    }
}
