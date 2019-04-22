namespace OnlineBookStore
{
    partial class PaymentForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCreditCard = new System.Windows.Forms.TabPage();
            this.lblPaymentAmountValue = new System.Windows.Forms.Label();
            this.lblPaymentAmount = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.lblSecurityCode = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.txtNameOnCard = new System.Windows.Forms.TextBox();
            this.lblNameOnCard = new System.Windows.Forms.Label();
            this.mtxtCardNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.tabPageCash = new System.Windows.Forms.TabPage();
            this.lblPaymentAmountCashValue = new System.Windows.Forms.Label();
            this.lblPaymentAmountCash = new System.Windows.Forms.Label();
            this.btnPaymentCash = new System.Windows.Forms.Button();
            this.panelCreditCard = new System.Windows.Forms.Panel();
            this.panelCash = new System.Windows.Forms.Panel();
            this.pBPayment = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPageCreditCard.SuspendLayout();
            this.tabPageCash.SuspendLayout();
            this.panelCreditCard.SuspendLayout();
            this.panelCash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCreditCard);
            this.tabControl1.Controls.Add(this.tabPageCash);
            this.tabControl1.Location = new System.Drawing.Point(-1, 3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(340, 503);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageCreditCard
            // 
            this.tabPageCreditCard.Controls.Add(this.panelCreditCard);
            this.tabPageCreditCard.Controls.Add(this.btnPay);
            this.tabPageCreditCard.Location = new System.Drawing.Point(4, 25);
            this.tabPageCreditCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageCreditCard.Name = "tabPageCreditCard";
            this.tabPageCreditCard.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageCreditCard.Size = new System.Drawing.Size(332, 474);
            this.tabPageCreditCard.TabIndex = 0;
            this.tabPageCreditCard.Text = "Credit Card";
            this.tabPageCreditCard.UseVisualStyleBackColor = true;
            // 
            // lblPaymentAmountValue
            // 
            this.lblPaymentAmountValue.AutoSize = true;
            this.lblPaymentAmountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPaymentAmountValue.Location = new System.Drawing.Point(183, 374);
            this.lblPaymentAmountValue.Name = "lblPaymentAmountValue";
            this.lblPaymentAmountValue.Size = new System.Drawing.Size(49, 20);
            this.lblPaymentAmountValue.TabIndex = 10;
            this.lblPaymentAmountValue.Text = "label";
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.AutoSize = true;
            this.lblPaymentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPaymentAmount.Location = new System.Drawing.Point(6, 374);
            this.lblPaymentAmount.Name = "lblPaymentAmount";
            this.lblPaymentAmount.Size = new System.Drawing.Size(150, 20);
            this.lblPaymentAmount.TabIndex = 9;
            this.lblPaymentAmount.Text = "Payment Amount";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(3, 416);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(329, 54);
            this.btnPay.TabIndex = 8;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(187, 329);
            this.maskedTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBox2.Mask = "000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(89, 22);
            this.maskedTextBox2.TabIndex = 7;
            // 
            // lblSecurityCode
            // 
            this.lblSecurityCode.AutoSize = true;
            this.lblSecurityCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecurityCode.Location = new System.Drawing.Point(179, 296);
            this.lblSecurityCode.Name = "lblSecurityCode";
            this.lblSecurityCode.Size = new System.Drawing.Size(127, 20);
            this.lblSecurityCode.TabIndex = 6;
            this.lblSecurityCode.Text = "Security Code";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(6, 327);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBox1.Mask = "00/00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(101, 22);
            this.maskedTextBox1.TabIndex = 5;
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExpiryDate.Location = new System.Drawing.Point(6, 296);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(107, 20);
            this.lblExpiryDate.TabIndex = 4;
            this.lblExpiryDate.Text = "Expiry Date";
            // 
            // txtNameOnCard
            // 
            this.txtNameOnCard.Location = new System.Drawing.Point(9, 249);
            this.txtNameOnCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameOnCard.Name = "txtNameOnCard";
            this.txtNameOnCard.Size = new System.Drawing.Size(312, 22);
            this.txtNameOnCard.TabIndex = 3;
            // 
            // lblNameOnCard
            // 
            this.lblNameOnCard.AutoSize = true;
            this.lblNameOnCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNameOnCard.Location = new System.Drawing.Point(6, 213);
            this.lblNameOnCard.Name = "lblNameOnCard";
            this.lblNameOnCard.Size = new System.Drawing.Size(133, 20);
            this.lblNameOnCard.TabIndex = 2;
            this.lblNameOnCard.Text = "Name On Card";
            // 
            // mtxtCardNumber
            // 
            this.mtxtCardNumber.Location = new System.Drawing.Point(9, 169);
            this.mtxtCardNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxtCardNumber.Mask = "0000-0000-0000-0000";
            this.mtxtCardNumber.Name = "mtxtCardNumber";
            this.mtxtCardNumber.Size = new System.Drawing.Size(311, 22);
            this.mtxtCardNumber.TabIndex = 1;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCardNumber.Location = new System.Drawing.Point(6, 135);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(120, 20);
            this.lblCardNumber.TabIndex = 0;
            this.lblCardNumber.Text = "Card Number";
            // 
            // tabPageCash
            // 
            this.tabPageCash.Controls.Add(this.panelCash);
            this.tabPageCash.Location = new System.Drawing.Point(4, 25);
            this.tabPageCash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageCash.Name = "tabPageCash";
            this.tabPageCash.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageCash.Size = new System.Drawing.Size(332, 474);
            this.tabPageCash.TabIndex = 1;
            this.tabPageCash.Text = "Cash";
            this.tabPageCash.UseVisualStyleBackColor = true;
            // 
            // lblPaymentAmountCashValue
            // 
            this.lblPaymentAmountCashValue.AutoSize = true;
            this.lblPaymentAmountCashValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPaymentAmountCashValue.Location = new System.Drawing.Point(178, 42);
            this.lblPaymentAmountCashValue.Name = "lblPaymentAmountCashValue";
            this.lblPaymentAmountCashValue.Size = new System.Drawing.Size(49, 20);
            this.lblPaymentAmountCashValue.TabIndex = 13;
            this.lblPaymentAmountCashValue.Text = "label";
            // 
            // lblPaymentAmountCash
            // 
            this.lblPaymentAmountCash.AutoSize = true;
            this.lblPaymentAmountCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPaymentAmountCash.Location = new System.Drawing.Point(22, 42);
            this.lblPaymentAmountCash.Name = "lblPaymentAmountCash";
            this.lblPaymentAmountCash.Size = new System.Drawing.Size(150, 20);
            this.lblPaymentAmountCash.TabIndex = 12;
            this.lblPaymentAmountCash.Text = "Payment Amount";
            // 
            // btnPaymentCash
            // 
            this.btnPaymentCash.Location = new System.Drawing.Point(-1, 108);
            this.btnPaymentCash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPaymentCash.Name = "btnPaymentCash";
            this.btnPaymentCash.Size = new System.Drawing.Size(320, 54);
            this.btnPaymentCash.TabIndex = 11;
            this.btnPaymentCash.Text = "Pay";
            this.btnPaymentCash.UseVisualStyleBackColor = true;
            this.btnPaymentCash.Click += new System.EventHandler(this.btnPaymentCash_Click);
            // 
            // panelCreditCard
            // 
            this.panelCreditCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCreditCard.Controls.Add(this.pBPayment);
            this.panelCreditCard.Controls.Add(this.lblPaymentAmountValue);
            this.panelCreditCard.Controls.Add(this.lblPaymentAmount);
            this.panelCreditCard.Controls.Add(this.maskedTextBox2);
            this.panelCreditCard.Controls.Add(this.lblSecurityCode);
            this.panelCreditCard.Controls.Add(this.maskedTextBox1);
            this.panelCreditCard.Controls.Add(this.lblExpiryDate);
            this.panelCreditCard.Controls.Add(this.txtNameOnCard);
            this.panelCreditCard.Controls.Add(this.lblNameOnCard);
            this.panelCreditCard.Controls.Add(this.mtxtCardNumber);
            this.panelCreditCard.Controls.Add(this.lblCardNumber);
            this.panelCreditCard.Location = new System.Drawing.Point(3, 0);
            this.panelCreditCard.Name = "panelCreditCard";
            this.panelCreditCard.Size = new System.Drawing.Size(329, 411);
            this.panelCreditCard.TabIndex = 11;
            // 
            // panelCash
            // 
            this.panelCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCash.Controls.Add(this.lblPaymentAmountCashValue);
            this.panelCash.Controls.Add(this.lblPaymentAmountCash);
            this.panelCash.Controls.Add(this.btnPaymentCash);
            this.panelCash.Location = new System.Drawing.Point(6, 27);
            this.panelCash.Name = "panelCash";
            this.panelCash.Size = new System.Drawing.Size(320, 166);
            this.panelCash.TabIndex = 14;
            // 
            // pBPayment
            // 
            this.pBPayment.Image = ((System.Drawing.Image)(resources.GetObject("pBPayment.Image")));
            this.pBPayment.Location = new System.Drawing.Point(3, 23);
            this.pBPayment.Name = "pBPayment";
            this.pBPayment.Size = new System.Drawing.Size(314, 98);
            this.pBPayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBPayment.TabIndex = 11;
            this.pBPayment.TabStop = false;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 510);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageCreditCard.ResumeLayout(false);
            this.tabPageCash.ResumeLayout(false);
            this.panelCreditCard.ResumeLayout(false);
            this.panelCreditCard.PerformLayout();
            this.panelCash.ResumeLayout(false);
            this.panelCash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBPayment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCreditCard;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label lblSecurityCode;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.TextBox txtNameOnCard;
        private System.Windows.Forms.Label lblNameOnCard;
        private System.Windows.Forms.MaskedTextBox mtxtCardNumber;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.TabPage tabPageCash;
        private System.Windows.Forms.Label lblPaymentAmountValue;
        private System.Windows.Forms.Label lblPaymentAmount;
        private System.Windows.Forms.Label lblPaymentAmountCashValue;
        private System.Windows.Forms.Label lblPaymentAmountCash;
        private System.Windows.Forms.Button btnPaymentCash;
        private System.Windows.Forms.Panel panelCreditCard;
        private System.Windows.Forms.Panel panelCash;
        private System.Windows.Forms.PictureBox pBPayment;
    }
}