namespace OnlineBookStore
{
    partial class MyAccountUserControl
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
            this.lblTotalPriceValue = new System.Windows.Forms.Label();
            this.lblUnitPriceValue = new System.Windows.Forms.Label();
            this.lblTotalPRice = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbCancelOrder = new System.Windows.Forms.PictureBox();
            this.pbShoppingCart = new System.Windows.Forms.PictureBox();
            this.lblMyAccountQuantity = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShoppingCart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalPriceValue
            // 
            this.lblTotalPriceValue.AutoSize = true;
            this.lblTotalPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPriceValue.Location = new System.Drawing.Point(755, 81);
            this.lblTotalPriceValue.Name = "lblTotalPriceValue";
            this.lblTotalPriceValue.Size = new System.Drawing.Size(95, 36);
            this.lblTotalPriceValue.TabIndex = 23;
            this.lblTotalPriceValue.Text = "label2";
            // 
            // lblUnitPriceValue
            // 
            this.lblUnitPriceValue.AutoSize = true;
            this.lblUnitPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnitPriceValue.Location = new System.Drawing.Point(591, 81);
            this.lblUnitPriceValue.Name = "lblUnitPriceValue";
            this.lblUnitPriceValue.Size = new System.Drawing.Size(95, 36);
            this.lblUnitPriceValue.TabIndex = 22;
            this.lblUnitPriceValue.Text = "label1";
            // 
            // lblTotalPRice
            // 
            this.lblTotalPRice.AutoSize = true;
            this.lblTotalPRice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPRice.Location = new System.Drawing.Point(738, 23);
            this.lblTotalPRice.Name = "lblTotalPRice";
            this.lblTotalPRice.Size = new System.Drawing.Size(157, 36);
            this.lblTotalPRice.TabIndex = 20;
            this.lblTotalPRice.Text = "Total Price";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnitPrice.Location = new System.Drawing.Point(579, 23);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(145, 36);
            this.lblUnitPrice.TabIndex = 19;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuantity.Location = new System.Drawing.Point(418, 23);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(125, 36);
            this.lblQuantity.TabIndex = 18;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(200, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(96, 36);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbShoppingCart);
            this.panel1.Location = new System.Drawing.Point(23, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 153);
            this.panel1.TabIndex = 16;
            // 
            // pbCancelOrder
            // 
            this.pbCancelOrder.Image = global::OnlineBookStore.Properties.Resources.removeblack;
            this.pbCancelOrder.Location = new System.Drawing.Point(951, 139);
            this.pbCancelOrder.Name = "pbCancelOrder";
            this.pbCancelOrder.Size = new System.Drawing.Size(65, 50);
            this.pbCancelOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCancelOrder.TabIndex = 24;
            this.pbCancelOrder.TabStop = false;
            this.pbCancelOrder.Click += new System.EventHandler(this.pbCancelOrder_Click);
            // 
            // pbShoppingCart
            // 
            this.pbShoppingCart.Location = new System.Drawing.Point(10, 19);
            this.pbShoppingCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbShoppingCart.Name = "pbShoppingCart";
            this.pbShoppingCart.Size = new System.Drawing.Size(125, 110);
            this.pbShoppingCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShoppingCart.TabIndex = 0;
            this.pbShoppingCart.TabStop = false;
            // 
            // lblMyAccountQuantity
            // 
            this.lblMyAccountQuantity.AutoSize = true;
            this.lblMyAccountQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyAccountQuantity.Location = new System.Drawing.Point(442, 81);
            this.lblMyAccountQuantity.Name = "lblMyAccountQuantity";
            this.lblMyAccountQuantity.Size = new System.Drawing.Size(95, 36);
            this.lblMyAccountQuantity.TabIndex = 25;
            this.lblMyAccountQuantity.Text = "label1";
            // 
            // MyAccountUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblMyAccountQuantity);
            this.Controls.Add(this.pbCancelOrder);
            this.Controls.Add(this.lblTotalPriceValue);
            this.Controls.Add(this.lblUnitPriceValue);
            this.Controls.Add(this.lblTotalPRice);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panel1);
            this.Name = "MyAccountUserControl";
            this.Size = new System.Drawing.Size(1017, 206);
            this.Load += new System.EventHandler(this.MyAccountUserControl_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShoppingCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCancelOrder;
        private System.Windows.Forms.Label lblTotalPriceValue;
        private System.Windows.Forms.Label lblUnitPriceValue;
        private System.Windows.Forms.Label lblTotalPRice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbShoppingCart;
        private System.Windows.Forms.Label lblMyAccountQuantity;
    }
}
