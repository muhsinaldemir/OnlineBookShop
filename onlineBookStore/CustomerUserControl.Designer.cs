namespace OnlineBookStore
{
    partial class CustomerUserControl
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.lblSurnameValue = new System.Windows.Forms.Label();
            this.lblTotalAmountSpentValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(36, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 24);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSurname.Location = new System.Drawing.Point(185, 34);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(100, 24);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalAmount.Location = new System.Drawing.Point(346, 34);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(128, 24);
            this.lblTotalAmount.TabIndex = 2;
            this.lblTotalAmount.Text = "TotalAmount";
            // 
            // lblNameValue
            // 
            this.lblNameValue.AutoSize = true;
            this.lblNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNameValue.Location = new System.Drawing.Point(22, 81);
            this.lblNameValue.Name = "lblNameValue";
            this.lblNameValue.Size = new System.Drawing.Size(110, 24);
            this.lblNameValue.TabIndex = 3;
            this.lblNameValue.Text = "NameValue";
            // 
            // lblSurnameValue
            // 
            this.lblSurnameValue.AutoSize = true;
            this.lblSurnameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSurnameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSurnameValue.Location = new System.Drawing.Point(173, 81);
            this.lblSurnameValue.Name = "lblSurnameValue";
            this.lblSurnameValue.Size = new System.Drawing.Size(138, 26);
            this.lblSurnameValue.TabIndex = 4;
            this.lblSurnameValue.Text = "SurnameValue";
            // 
            // lblTotalAmountSpentValue
            // 
            this.lblTotalAmountSpentValue.AutoSize = true;
            this.lblTotalAmountSpentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalAmountSpentValue.Location = new System.Drawing.Point(374, 81);
            this.lblTotalAmountSpentValue.Name = "lblTotalAmountSpentValue";
            this.lblTotalAmountSpentValue.Size = new System.Drawing.Size(60, 24);
            this.lblTotalAmountSpentValue.TabIndex = 5;
            this.lblTotalAmountSpentValue.Text = "label1";
            // 
            // CustomerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblTotalAmountSpentValue);
            this.Controls.Add(this.lblSurnameValue);
            this.Controls.Add(this.lblNameValue);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Name = "CustomerUserControl";
            this.Size = new System.Drawing.Size(508, 148);
            this.Load += new System.EventHandler(this.CustomerUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.Label lblSurnameValue;
        private System.Windows.Forms.Label lblTotalAmountSpentValue;
    }
}
