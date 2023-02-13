namespace HastaneOtomasyonu.HASTA.Kontroller
{
    partial class ucRandevuAl
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
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.cmbBölüm = new System.Windows.Forms.ComboBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSaat11 = new System.Windows.Forms.Button();
            this.btn13bucuk = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn14bucuk = new System.Windows.Forms.Button();
            this.btn11bucuk = new System.Windows.Forms.Button();
            this.btn14 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(83, 33);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(162, 21);
            this.cmbPersonel.TabIndex = 0;
            // 
            // cmbBölüm
            // 
            this.cmbBölüm.FormattingEnabled = true;
            this.cmbBölüm.Items.AddRange(new object[] {
            "Dahiliye",
            "Kulak Burun Boğaz",
            "Göz Hastalıkları"});
            this.cmbBölüm.Location = new System.Drawing.Point(83, 89);
            this.cmbBölüm.Name = "cmbBölüm";
            this.cmbBölüm.Size = new System.Drawing.Size(162, 21);
            this.cmbBölüm.TabIndex = 1;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(360, 25);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(139, 144);
            this.txtAciklama.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Personel Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bölüm Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tarih:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Açıklama:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(66, 144);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(66, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "10.30";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSaat11
            // 
            this.btnSaat11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSaat11.Location = new System.Drawing.Point(173, 317);
            this.btnSaat11.Name = "btnSaat11";
            this.btnSaat11.Size = new System.Drawing.Size(90, 40);
            this.btnSaat11.TabIndex = 13;
            this.btnSaat11.Text = "11.00";
            this.btnSaat11.UseVisualStyleBackColor = false;
            this.btnSaat11.Click += new System.EventHandler(this.btnSaat11_Click);
            // 
            // btn13bucuk
            // 
            this.btn13bucuk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn13bucuk.Location = new System.Drawing.Point(66, 363);
            this.btn13bucuk.Name = "btn13bucuk";
            this.btn13bucuk.Size = new System.Drawing.Size(90, 40);
            this.btn13bucuk.TabIndex = 15;
            this.btn13bucuk.Text = "13:30";
            this.btn13bucuk.UseVisualStyleBackColor = false;
            this.btn13bucuk.Click += new System.EventHandler(this.btn13bucuk_Click);
            // 
            // btn12
            // 
            this.btn12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn12.Location = new System.Drawing.Point(383, 317);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(90, 40);
            this.btn12.TabIndex = 16;
            this.btn12.Text = "12:00";
            this.btn12.UseVisualStyleBackColor = false;
            this.btn12.Click += new System.EventHandler(this.btn12_Click);
            // 
            // btn14bucuk
            // 
            this.btn14bucuk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn14bucuk.Location = new System.Drawing.Point(284, 363);
            this.btn14bucuk.Name = "btn14bucuk";
            this.btn14bucuk.Size = new System.Drawing.Size(90, 40);
            this.btn14bucuk.TabIndex = 17;
            this.btn14bucuk.Text = "14:30";
            this.btn14bucuk.UseVisualStyleBackColor = false;
            this.btn14bucuk.Click += new System.EventHandler(this.btn14bucuk_Click);
            // 
            // btn11bucuk
            // 
            this.btn11bucuk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn11bucuk.Location = new System.Drawing.Point(284, 318);
            this.btn11bucuk.Name = "btn11bucuk";
            this.btn11bucuk.Size = new System.Drawing.Size(90, 40);
            this.btn11bucuk.TabIndex = 18;
            this.btn11bucuk.Text = "11:30";
            this.btn11bucuk.UseVisualStyleBackColor = false;
            this.btn11bucuk.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn14
            // 
            this.btn14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn14.Location = new System.Drawing.Point(173, 363);
            this.btn14.Name = "btn14";
            this.btn14.Size = new System.Drawing.Size(90, 40);
            this.btn14.TabIndex = 19;
            this.btn14.Text = "14:00";
            this.btn14.UseVisualStyleBackColor = false;
            this.btn14.Click += new System.EventHandler(this.btn14_Click);
            // 
            // btn15
            // 
            this.btn15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn15.Location = new System.Drawing.Point(383, 363);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(90, 40);
            this.btn15.TabIndex = 20;
            this.btn15.Text = "15:00";
            this.btn15.UseVisualStyleBackColor = false;
            this.btn15.Click += new System.EventHandler(this.btn15_Click);
            // 
            // ucRandevuAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn15);
            this.Controls.Add(this.btn14);
            this.Controls.Add(this.btn11bucuk);
            this.Controls.Add(this.btn14bucuk);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn13bucuk);
            this.Controls.Add(this.btnSaat11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.cmbBölüm);
            this.Controls.Add(this.cmbPersonel);
            this.Name = "ucRandevuAl";
            this.Size = new System.Drawing.Size(539, 484);
            this.Load += new System.EventHandler(this.ucRandevuAl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPersonel;
        private System.Windows.Forms.ComboBox cmbBölüm;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSaat11;
        private System.Windows.Forms.Button btn13bucuk;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn14bucuk;
        private System.Windows.Forms.Button btn11bucuk;
        private System.Windows.Forms.Button btn14;
        private System.Windows.Forms.Button btn15;
    }
}
