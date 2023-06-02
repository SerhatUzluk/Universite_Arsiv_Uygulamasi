namespace Universite_Arsiv_Uygulamasi
{
    partial class EmanetListesi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emanetId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eCreationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eClosedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evrakId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emanetAlanName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emanetAlanSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.emanetGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userId,
            this.emanetId,
            this.eCreationTime,
            this.eClosedTime,
            this.eDescription,
            this.evrakId,
            this.emanetAlanName,
            this.emanetAlanSurname,
            this.contactNumber});
            this.dataGridView1.Location = new System.Drawing.Point(14, 91);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1203, 392);
            this.dataGridView1.TabIndex = 0;
            // 
            // userId
            // 
            this.userId.DataPropertyName = "userId";
            this.userId.HeaderText = "Kullanıcı ID";
            this.userId.MinimumWidth = 6;
            this.userId.Name = "userId";
            this.userId.Width = 125;
            // 
            // emanetId
            // 
            this.emanetId.DataPropertyName = "emanetId";
            this.emanetId.HeaderText = "Emanet ID";
            this.emanetId.MinimumWidth = 6;
            this.emanetId.Name = "emanetId";
            this.emanetId.Width = 125;
            // 
            // eCreationTime
            // 
            this.eCreationTime.DataPropertyName = "eCreationTime";
            this.eCreationTime.HeaderText = "Oluşturulma Tarihi";
            this.eCreationTime.MinimumWidth = 6;
            this.eCreationTime.Name = "eCreationTime";
            this.eCreationTime.Width = 125;
            // 
            // eClosedTime
            // 
            this.eClosedTime.DataPropertyName = "eClosedTime";
            this.eClosedTime.HeaderText = "Teslim Tarihi";
            this.eClosedTime.MinimumWidth = 6;
            this.eClosedTime.Name = "eClosedTime";
            this.eClosedTime.Width = 125;
            // 
            // eDescription
            // 
            this.eDescription.DataPropertyName = "eDescription";
            this.eDescription.HeaderText = "Emanet Açıklaması";
            this.eDescription.MinimumWidth = 6;
            this.eDescription.Name = "eDescription";
            this.eDescription.Width = 125;
            // 
            // evrakId
            // 
            this.evrakId.DataPropertyName = "evrakId";
            this.evrakId.HeaderText = "Evrak ID";
            this.evrakId.MinimumWidth = 6;
            this.evrakId.Name = "evrakId";
            this.evrakId.Width = 125;
            // 
            // emanetAlanName
            // 
            this.emanetAlanName.DataPropertyName = "emanetAlanName";
            this.emanetAlanName.HeaderText = "Emanet Alanın Adı";
            this.emanetAlanName.MinimumWidth = 6;
            this.emanetAlanName.Name = "emanetAlanName";
            this.emanetAlanName.Width = 125;
            // 
            // emanetAlanSurname
            // 
            this.emanetAlanSurname.DataPropertyName = "emanetAlanSurname";
            this.emanetAlanSurname.HeaderText = "Emanet Alan Soyadı";
            this.emanetAlanSurname.MinimumWidth = 6;
            this.emanetAlanSurname.Name = "emanetAlanSurname";
            this.emanetAlanSurname.Width = 125;
            // 
            // contactNumber
            // 
            this.contactNumber.DataPropertyName = "contactNumber";
            this.contactNumber.HeaderText = "İletişim Numarası";
            this.contactNumber.MinimumWidth = 6;
            this.contactNumber.Name = "contactNumber";
            this.contactNumber.Width = 125;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(528, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Emanet Verilen Evraklar";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(605, 524);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(344, 525);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 27);
            this.textBox1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Location = new System.Drawing.Point(344, 589);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 27);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker2.Location = new System.Drawing.Point(605, 589);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(228, 27);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(865, 589);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "Filtrele";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // emanetGuncelle
            // 
            this.emanetGuncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emanetGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.emanetGuncelle.Location = new System.Drawing.Point(1069, 512);
            this.emanetGuncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emanetGuncelle.Name = "emanetGuncelle";
            this.emanetGuncelle.Size = new System.Drawing.Size(149, 31);
            this.emanetGuncelle.TabIndex = 7;
            this.emanetGuncelle.Text = "Emanetleri Güncelle";
            this.emanetGuncelle.UseVisualStyleBackColor = false;
            this.emanetGuncelle.Click += new System.EventHandler(this.emanetGuncelle_Click_1);
            // 
            // EmanetListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 815);
            this.Controls.Add(this.emanetGuncelle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EmanetListesi";
            this.Text = "Emanet Listesi";
            this.Load += new System.EventHandler(this.EmanetListesi_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button button2;
        private Button emanetGuncelle;
        private DataGridViewTextBoxColumn userId;
        private DataGridViewTextBoxColumn emanetId;
        private DataGridViewTextBoxColumn eCreationTime;
        private DataGridViewTextBoxColumn eClosedTime;
        private DataGridViewTextBoxColumn eDescription;
        private DataGridViewTextBoxColumn evrakId;
        private DataGridViewTextBoxColumn emanetAlanName;
        private DataGridViewTextBoxColumn emanetAlanSurname;
        private DataGridViewTextBoxColumn contactNumber;
    }
}