namespace Universite_Arsiv_Uygulamasi
{
    partial class EmanetKayit
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
            this.emanetNo = new System.Windows.Forms.TextBox();
            this.emanetEvrakId = new System.Windows.Forms.TextBox();
            this.emanetKayitButon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.emanetCreation = new System.Windows.Forms.DateTimePicker();
            this.emanetClosed = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.emanetAlanAd = new System.Windows.Forms.TextBox();
            this.emanetAlanSoyad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.emanetAlanTel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.emanetPersonelId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.emanetTanim = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emanetNo
            // 
            this.emanetNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emanetNo.Location = new System.Drawing.Point(139, 151);
            this.emanetNo.Name = "emanetNo";
            this.emanetNo.Size = new System.Drawing.Size(250, 27);
            this.emanetNo.TabIndex = 0;
            // 
            // emanetEvrakId
            // 
            this.emanetEvrakId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emanetEvrakId.Location = new System.Drawing.Point(139, 219);
            this.emanetEvrakId.Name = "emanetEvrakId";
            this.emanetEvrakId.Size = new System.Drawing.Size(250, 27);
            this.emanetEvrakId.TabIndex = 1;
            // 
            // emanetKayitButon
            // 
            this.emanetKayitButon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emanetKayitButon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.emanetKayitButon.Location = new System.Drawing.Point(143, 461);
            this.emanetKayitButon.Name = "emanetKayitButon";
            this.emanetKayitButon.Size = new System.Drawing.Size(250, 29);
            this.emanetKayitButon.TabIndex = 4;
            this.emanetKayitButon.Text = "Emanet Kaydı Oluştur";
            this.emanetKayitButon.UseVisualStyleBackColor = false;
            this.emanetKayitButon.Click += new System.EventHandler(this.emanetKayitButon_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Emanet No:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Evrak ID:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Oluşturma Tarihi:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Teslim Tarihi:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(169, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Emanet Kaydı Oluşturma";
            // 
            // emanetCreation
            // 
            this.emanetCreation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emanetCreation.Location = new System.Drawing.Point(139, 284);
            this.emanetCreation.Name = "emanetCreation";
            this.emanetCreation.Size = new System.Drawing.Size(250, 27);
            this.emanetCreation.TabIndex = 10;
            // 
            // emanetClosed
            // 
            this.emanetClosed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emanetClosed.Location = new System.Drawing.Point(139, 351);
            this.emanetClosed.Name = "emanetClosed";
            this.emanetClosed.Size = new System.Drawing.Size(250, 27);
            this.emanetClosed.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(506, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 28);
            this.label7.TabIndex = 15;
            this.label7.Text = "Emanet Alan Bilgileri";
            // 
            // emanetAlanAd
            // 
            this.emanetAlanAd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emanetAlanAd.Location = new System.Drawing.Point(526, 147);
            this.emanetAlanAd.Name = "emanetAlanAd";
            this.emanetAlanAd.Size = new System.Drawing.Size(175, 27);
            this.emanetAlanAd.TabIndex = 17;
            // 
            // emanetAlanSoyad
            // 
            this.emanetAlanSoyad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emanetAlanSoyad.Location = new System.Drawing.Point(526, 193);
            this.emanetAlanSoyad.Name = "emanetAlanSoyad";
            this.emanetAlanSoyad.Size = new System.Drawing.Size(175, 27);
            this.emanetAlanSoyad.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(486, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Ad:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(467, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Soyad:";
            // 
            // emanetAlanTel
            // 
            this.emanetAlanTel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emanetAlanTel.Location = new System.Drawing.Point(526, 253);
            this.emanetAlanTel.Name = "emanetAlanTel";
            this.emanetAlanTel.Size = new System.Drawing.Size(175, 27);
            this.emanetAlanTel.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(432, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Telefon No:";
            // 
            // emanetPersonelId
            // 
            this.emanetPersonelId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emanetPersonelId.Location = new System.Drawing.Point(139, 88);
            this.emanetPersonelId.Name = "emanetPersonelId";
            this.emanetPersonelId.Size = new System.Drawing.Size(250, 27);
            this.emanetPersonelId.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Kullanıcı ID:";
            // 
            // emanetTanim
            // 
            this.emanetTanim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emanetTanim.Location = new System.Drawing.Point(143, 404);
            this.emanetTanim.Name = "emanetTanim";
            this.emanetTanim.Size = new System.Drawing.Size(247, 27);
            this.emanetTanim.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 411);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "Emanet Tanım:";
            // 
            // EmanetKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 517);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.emanetTanim);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.emanetPersonelId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.emanetAlanTel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.emanetAlanSoyad);
            this.Controls.Add(this.emanetAlanAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.emanetClosed);
            this.Controls.Add(this.emanetCreation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emanetKayitButon);
            this.Controls.Add(this.emanetEvrakId);
            this.Controls.Add(this.emanetNo);
            this.Name = "EmanetKayit";
            this.Text = "Emanet Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox emanetNo;
        private TextBox emanetEvrakId;
        private Button emanetKayitButon;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker emanetCreation;
        private DateTimePicker emanetClosed;
        private Label label7;
        private TextBox emanetAlanAd;
        private TextBox emanetAlanSoyad;
        private Label label9;
        private Label label10;
        private TextBox emanetAlanTel;
        private Label label11;
        private TextBox emanetPersonelId;
        private Label label12;
        private TextBox emanetTanim;
        private Label label13;
    }
}