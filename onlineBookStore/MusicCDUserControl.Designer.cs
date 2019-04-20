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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMusicCDPrice = new System.Windows.Forms.Label();
            this.lbMusicCDSinger = new System.Windows.Forms.Label();
            this.lblMusicCDName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBookAddToCart
            // 
            this.btnBookAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookAddToCart.Location = new System.Drawing.Point(46, 378);
            this.btnBookAddToCart.Name = "btnBookAddToCart";
            this.btnBookAddToCart.Size = new System.Drawing.Size(209, 58);
            this.btnBookAddToCart.TabIndex = 10;
            this.btnBookAddToCart.Text = "Add To Cart";
            this.btnBookAddToCart.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(34, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 200);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 163);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblMusicCDPrice
            // 
            this.lblMusicCDPrice.AutoSize = true;
            this.lblMusicCDPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicCDPrice.Location = new System.Drawing.Point(57, 328);
            this.lblMusicCDPrice.Name = "lblMusicCDPrice";
            this.lblMusicCDPrice.Size = new System.Drawing.Size(83, 36);
            this.lblMusicCDPrice.TabIndex = 8;
            this.lblMusicCDPrice.Text = "Price";
            // 
            // lbMusicCDSinger
            // 
            this.lbMusicCDSinger.AutoSize = true;
            this.lbMusicCDSinger.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMusicCDSinger.Location = new System.Drawing.Point(53, 284);
            this.lbMusicCDSinger.Name = "lbMusicCDSinger";
            this.lbMusicCDSinger.Size = new System.Drawing.Size(102, 36);
            this.lbMusicCDSinger.TabIndex = 7;
            this.lbMusicCDSinger.Text = "Singer";
            // 
            // lblMusicCDName
            // 
            this.lblMusicCDName.AutoSize = true;
            this.lblMusicCDName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicCDName.Location = new System.Drawing.Point(50, 241);
            this.lblMusicCDName.Name = "lblMusicCDName";
            this.lblMusicCDName.Size = new System.Drawing.Size(96, 36);
            this.lblMusicCDName.TabIndex = 6;
            this.lblMusicCDName.Text = "Name";
            // 
            // MusicCDUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBookAddToCart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMusicCDPrice);
            this.Controls.Add(this.lbMusicCDSinger);
            this.Controls.Add(this.lblMusicCDName);
            this.Name = "MusicCDUserControl";
            this.Size = new System.Drawing.Size(308, 480);
            this.Load += new System.EventHandler(this.MusicCDUserControl_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBookAddToCart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMusicCDPrice;
        private System.Windows.Forms.Label lbMusicCDSinger;
        private System.Windows.Forms.Label lblMusicCDName;
    }
}
