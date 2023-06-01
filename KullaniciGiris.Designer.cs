namespace Universite_Arsiv_Uygulamasi
{
    partial class KullaniciGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciGiris));
            this.kullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.girisYapBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.kullaniciAdLbl = new System.Windows.Forms.Label();
            this.sifreLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kullaniciAdiTextBox
            // 
            this.kullaniciAdiTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kullaniciAdiTextBox.Location = new System.Drawing.Point(273, 265);
            this.kullaniciAdiTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kullaniciAdiTextBox.Name = "kullaniciAdiTextBox";
            this.kullaniciAdiTextBox.Size = new System.Drawing.Size(199, 23);
            this.kullaniciAdiTextBox.TabIndex = 2;
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sifreTextBox.Location = new System.Drawing.Point(273, 318);
            this.sifreTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.PasswordChar = '*';
            this.sifreTextBox.Size = new System.Drawing.Size(199, 23);
            this.sifreTextBox.TabIndex = 3;
            // 
            // girisYapBtn
            // 
            this.girisYapBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.girisYapBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.girisYapBtn.Location = new System.Drawing.Point(291, 381);
            this.girisYapBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.girisYapBtn.Name = "girisYapBtn";
            this.girisYapBtn.Size = new System.Drawing.Size(172, 28);
            this.girisYapBtn.TabIndex = 5;
            this.girisYapBtn.Text = "Giriş Yap";
            this.girisYapBtn.UseVisualStyleBackColor = false;
            this.girisYapBtn.Click += new System.EventHandler(this.girisYapBtn_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(291, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kullanıcı Girişi";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // kullaniciAdLbl
            // 
            this.kullaniciAdLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kullaniciAdLbl.AutoSize = true;
            this.kullaniciAdLbl.Location = new System.Drawing.Point(184, 273);
            this.kullaniciAdLbl.Name = "kullaniciAdLbl";
            this.kullaniciAdLbl.Size = new System.Drawing.Size(76, 15);
            this.kullaniciAdLbl.TabIndex = 14;
            this.kullaniciAdLbl.Text = "Kullanıcı Adı:";
            // 
            // sifreLbl
            // 
            this.sifreLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sifreLbl.AutoSize = true;
            this.sifreLbl.Location = new System.Drawing.Point(227, 326);
            this.sifreLbl.Name = "sifreLbl";
            this.sifreLbl.Size = new System.Drawing.Size(33, 15);
            this.sifreLbl.TabIndex = 15;
            this.sifreLbl.Text = "Şifre:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(273, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // KullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 489);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sifreLbl);
            this.Controls.Add(this.kullaniciAdLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.girisYapBtn);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.kullaniciAdiTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "KullaniciGiris";
            this.Text = "Giriş Yap";
            this.Load += new System.EventHandler(this.KullaniciGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox kullaniciAdiTextBox;
        private TextBox sifreTextBox;
        private Button girisYapBtn;
        private Label label5;
        private Label kullaniciAdLbl;
        private Label sifreLbl;
        private PictureBox pictureBox1;
    }
}