namespace Universite_Arsiv_Uygulamasi
{
    partial class EvrakKayit
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
            this.label1 = new System.Windows.Forms.Label();
            this.evrakTuru = new System.Windows.Forms.TextBox();
            this.evrakTanim = new System.Windows.Forms.TextBox();
            this.depoIdText = new System.Windows.Forms.TextBox();
            this.tarihBilgiEK = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.evrakKayitButon = new System.Windows.Forms.Button();
            this.arsivKonumText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(304, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Evrak Kaydı";
            // 
            // evrakTuru
            // 
            this.evrakTuru.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.evrakTuru.Location = new System.Drawing.Point(238, 76);
            this.evrakTuru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.evrakTuru.Name = "evrakTuru";
            this.evrakTuru.Size = new System.Drawing.Size(219, 23);
            this.evrakTuru.TabIndex = 2;
            // 
            // evrakTanim
            // 
            this.evrakTanim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.evrakTanim.Location = new System.Drawing.Point(238, 174);
            this.evrakTanim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.evrakTanim.Name = "evrakTanim";
            this.evrakTanim.Size = new System.Drawing.Size(219, 23);
            this.evrakTanim.TabIndex = 3;
            // 
            // depoIdText
            // 
            this.depoIdText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.depoIdText.Location = new System.Drawing.Point(238, 219);
            this.depoIdText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.depoIdText.Name = "depoIdText";
            this.depoIdText.Size = new System.Drawing.Size(219, 23);
            this.depoIdText.TabIndex = 4;
            // 
            // tarihBilgiEK
            // 
            this.tarihBilgiEK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tarihBilgiEK.Location = new System.Drawing.Point(238, 126);
            this.tarihBilgiEK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tarihBilgiEK.Name = "tarihBilgiEK";
            this.tarihBilgiEK.Size = new System.Drawing.Size(219, 23);
            this.tarihBilgiEK.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Evrak Türü:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tarih Bilgisi:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Evrak Tanım:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Depolama Alanı ID:";
            // 
            // evrakKayitButon
            // 
            this.evrakKayitButon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.evrakKayitButon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.evrakKayitButon.Location = new System.Drawing.Point(258, 301);
            this.evrakKayitButon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.evrakKayitButon.Name = "evrakKayitButon";
            this.evrakKayitButon.Size = new System.Drawing.Size(182, 22);
            this.evrakKayitButon.TabIndex = 14;
            this.evrakKayitButon.Text = "Kaydet";
            this.evrakKayitButon.UseVisualStyleBackColor = false;
            // 
            // arsivKonumText
            // 
            this.arsivKonumText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arsivKonumText.Location = new System.Drawing.Point(238, 259);
            this.arsivKonumText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.arsivKonumText.Name = "arsivKonumText";
            this.arsivKonumText.Size = new System.Drawing.Size(219, 23);
            this.arsivKonumText.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Arşiv Raf Konumu:";
            // 
            // EvrakKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 388);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.arsivKonumText);
            this.Controls.Add(this.evrakKayitButon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tarihBilgiEK);
            this.Controls.Add(this.depoIdText);
            this.Controls.Add(this.evrakTanim);
            this.Controls.Add(this.evrakTuru);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EvrakKayit";
            this.Text = "Evrak Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox evrakTuru;
        private TextBox evrakTanim;
        private TextBox depoIdText;
        private DateTimePicker tarihBilgiEK;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button evrakKayitButon;
        private TextBox arsivKonumText;
        private Label label8;
    }
}