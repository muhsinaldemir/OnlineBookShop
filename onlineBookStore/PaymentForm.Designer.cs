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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCreditCard = new System.Windows.Forms.TabPage();
            this.tabPageCash = new System.Windows.Forms.TabPage();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.mtxtCardNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblNameOnCard = new System.Windows.Forms.Label();
            this.txtNameOnCard = new System.Windows.Forms.TextBox();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblSecurityCode = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblPaymentAmount = new System.Windows.Forms.Label();
            this.lblPaymentAmountValue = new System.Windows.Forms.Label();
            this.lblPaymentAmountCashValue = new System.Windows.Forms.Label();
            this.lblPaymentAmountCash = new System.Windows.Forms.Label();
            this.btnPaymentCash = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageCreditCard.SuspendLayout();
            this.tabPageCash.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCreditCard);
            this.tabControl1.Controls.Add(this.tabPageCash);
            this.tabControl1.Location = new System.Drawing.Point(-1, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(445, 525);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageCreditCard
            // 
            this.tabPageCreditCard.Controls.Add(this.lblPaymentAmountValue);
            this.tabPageCreditCard.Controls.Add(this.lblPaymentAmount);
            this.tabPageCreditCard.Controls.Add(this.btnPay);
            this.tabPageCreditCard.Controls.Add(this.maskedTextBox2);
            this.tabPageCreditCard.Controls.Add(this.lblSecurityCode);
            this.tabPageCreditCard.Controls.Add(this.maskedTextBox1);
            this.tabPageCreditCard.Controls.Add(this.lblExpiryDate);
            this.tabPageCreditCard.Controls.Add(this.txtNameOnCard);
            this.tabPageCreditCard.Controls.Add(this.lblNameOnCard);
            this.tabPageCreditCard.Controls.Add(this.mtxtCardNumber);
            this.tabPageCreditCard.Controls.Add(this.lblCardNumber);
            this.tabPageCreditCard.Location = new System.Drawing.Point(4, 29);
            this.tabPageCreditCard.Name = "tabPageCreditCard";
            this.tabPageCreditCard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCreditCard.Size = new System.Drawing.Size(437, 492);
            this.tabPageCreditCard.TabIndex = 0;
            this.tabPageCreditCard.Text = "Credit Card";
            this.tabPageCreditCard.UseVisualStyleBackColor = true;
            // 
            // tabPageCash
            // 
            this.tabPageCash.Controls.Add(this.lblPaymentAmountCashValue);
            this.tabPageCash.Controls.Add(this.lblPaymentAmountCash);
            this.tabPageCash.Controls.Add(this.btnPaymentCash);
            this.tabPageCash.Location = new System.Drawing.Point(4, 29);
            this.tabPageCash.Name = "tabPageCash";
            this.tabPageCash.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCash.Size = new System.Drawing.Size(437, 492);
            this.tabPageCash.TabIndex = 1;
            this.tabPageCash.Text = "Cash";
            this.tabPageCash.UseVisualStyleBackColor = true;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(26, 57);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(103, 20);
            this.lblCardNumber.TabIndex = 0;
            this.lblCardNumber.Text = "Card Number";
            // 
            // mtxtCardNumber
            // 
            this.mtxtCardNumber.Location = new System.Drawing.Point(30, 98);
            this.mtxtCardNumber.Mask = "0000-0000-0000-0000";
            this.mtxtCardNumber.Name = "mtxtCardNumber";
            this.mtxtCardNumber.Size = new System.Drawing.Size(349, 26);
            this.mtxtCardNumber.TabIndex = 1;
            // 
            // lblNameOnCard
            // 
            this.lblNameOnCard.AutoSize = true;
            this.lblNameOnCard.Location = new System.Drawing.Point(26, 155);
            this.lblNameOnCard.Name = "lblNameOnCard";
            this.lblNameOnCard.Size = new System.Drawing.Size(114, 20);
            this.lblNameOnCard.TabIndex = 2;
            this.lblNameOnCard.Text = "Name On Card";
            // 
            // txtNameOnCard
            // 
            this.txtNameOnCard.Location = new System.Drawing.Point(30, 197);
            this.txtNameOnCard.Name = "txtNameOnCard";
            this.txtNameOnCard.Size = new System.Drawing.Size(351, 26);
            this.txtNameOnCard.TabIndex = 3;
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Location = new System.Drawing.Point(26, 259);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(90, 20);
            this.lblExpiryDate.TabIndex = 4;
            this.lblExpiryDate.Text = "Expiry Date";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(27, 295);
            this.maskedTextBox1.Mask = "00/00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(113, 26);
            this.maskedTextBox1.TabIndex = 5;
            // 
            // lblSecurityCode
            // 
            this.lblSecurityCode.AutoSize = true;
            this.lblSecurityCode.Location = new System.Drawing.Point(221, 259);
            this.lblSecurityCode.Name = "lblSecurityCode";
            this.lblSecurityCode.Size = new System.Drawing.Size(108, 20);
            this.lblSecurityCode.TabIndex = 6;
            this.lblSecurityCode.Text = "Security Code";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(231, 298);
            this.maskedTextBox2.Mask = "000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBox2.TabIndex = 7;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(27, 400);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(338, 68);
            this.btnPay.TabIndex = 8;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.AutoSize = true;
            this.lblPaymentAmount.Location = new System.Drawing.Point(26, 356);
            this.lblPaymentAmount.Name = "lblPaymentAmount";
            this.lblPaymentAmount.Size = new System.Drawing.Size(131, 20);
            this.lblPaymentAmount.TabIndex = 9;
            this.lblPaymentAmount.Text = "Payment Amount";
            // 
            // lblPaymentAmountValue
            // 
            this.lblPaymentAmountValue.AutoSize = true;
            this.lblPaymentAmountValue.Location = new System.Drawing.Point(183, 356);
            this.lblPaymentAmountValue.Name = "lblPaymentAmountValue";
            this.lblPaymentAmountValue.Size = new System.Drawing.Size(42, 20);
            this.lblPaymentAmountValue.TabIndex = 10;
            this.lblPaymentAmountValue.Text = "label";
            // 
            // lblPaymentAmountCashValue
            // 
            this.lblPaymentAmountCashValue.AutoSize = true;
            this.lblPaymentAmountCashValue.Location = new System.Drawing.Point(190, 57);
            this.lblPaymentAmountCashValue.Name = "lblPaymentAmountCashValue";
            this.lblPaymentAmountCashValue.Size = new System.Drawing.Size(42, 20);
            this.lblPaymentAmountCashValue.TabIndex = 13;
            this.lblPaymentAmountCashValue.Text = "label";
            // 
            // lblPaymentAmountCash
            // 
            this.lblPaymentAmountCash.AutoSize = true;
            this.lblPaymentAmountCash.Location = new System.Drawing.Point(33, 57);
            this.lblPaymentAmountCash.Name = "lblPaymentAmountCash";
            this.lblPaymentAmountCash.Size = new System.Drawing.Size(131, 20);
            this.lblPaymentAmountCash.TabIndex = 12;
            this.lblPaymentAmountCash.Text = "Payment Amount";
            // 
            // btnPaymentCash
            // 
            this.btnPaymentCash.Location = new System.Drawing.Point(34, 101);
            this.btnPaymentCash.Name = "btnPaymentCash";
            this.btnPaymentCash.Size = new System.Drawing.Size(338, 68);
            this.btnPaymentCash.TabIndex = 11;
            this.btnPaymentCash.Text = "Pay";
            this.btnPaymentCash.UseVisualStyleBackColor = true;
            this.btnPaymentCash.Click += new System.EventHandler(this.btnPaymentCash_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 525);
            this.Controls.Add(this.tabControl1);
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageCreditCard.ResumeLayout(false);
            this.tabPageCreditCard.PerformLayout();
            this.tabPageCash.ResumeLayout(false);
            this.tabPageCash.PerformLayout();
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
    }
}