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
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBookAddToCart
            // 
            this.btnBookAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookAddToCart.Location = new System.Drawing.Point(20, 235);
            this.btnBookAddToCart.Name = "btnBookAddToCart";
            this.btnBookAddToCart.Size = new System.Drawing.Size(209, 58);
            this.btnBookAddToCart.TabIndex = 10;
            this.btnBookAddToCart.Text = "Add To Cart";
            this.btnBookAddToCart.UseVisualStyleBackColor = true;
            // 
            // lblMusicCDPrice
            // 
            this.lblMusicCDPrice.AutoSize = true;
            this.lblMusicCDPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicCDPrice.Location = new System.Drawing.Point(39, 187);
            this.lblMusicCDPrice.Name = "lblMusicCDPrice";
            this.lblMusicCDPrice.Size = new System.Drawing.Size(83, 36);
            this.lblMusicCDPrice.TabIndex = 8;
            this.lblMusicCDPrice.Text = "Price";
            // 
            // lblMusicCDSinger
            // 
            this.lblMusicCDSinger.AutoSize = true;
            this.lblMusicCDSinger.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicCDSinger.Location = new System.Drawing.Point(35, 143);
            this.lblMusicCDSinger.Name = "lblMusicCDSinger";
            this.lblMusicCDSinger.Size = new System.Drawing.Size(102, 36);
            this.lblMusicCDSinger.TabIndex = 7;
            this.lblMusicCDSinger.Text = "Singer";
            // 
            // lblMusicCDName
            // 
            this.lblMusicCDName.AutoSize = true;
            this.lblMusicCDName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicCDName.Location = new System.Drawing.Point(32, 100);
            this.lblMusicCDName.Name = "lblMusicCDName";
            this.lblMusicCDName.Size = new System.Drawing.Size(92, 36);
            this.lblMusicCDName.TabIndex = 6;
            this.lblMusicCDName.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(62, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 200);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnBookAddToCart);
            this.panel3.Controls.Add(this.lblMusicCDName);
            this.panel3.Controls.Add(this.lblMusicCDSinger);
            this.panel3.Controls.Add(this.lblMusicCDPrice);
            this.panel3.Location = new System.Drawing.Point(34, 137);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 304);
            this.panel3.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(10, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 163);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // MusicCDUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "MusicCDUserControl";
            this.Size = new System.Drawing.Size(328, 477);
            this.Load += new System.EventHandler(this.MusicCDUserControl_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
    }
}
