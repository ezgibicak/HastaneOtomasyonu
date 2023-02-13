namespace HastaneOtomasyonu
{
    partial class frmPersonelKullanıcı
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtPersonelKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtPersonelKullaniciSifre = new System.Windows.Forms.TextBox();
            this.btnPersonelKullaniciGiris = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKayitPersonel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // txtPersonelKullaniciAdi
            // 
            this.txtPersonelKullaniciAdi.Location = new System.Drawing.Point(98, 23);
            this.txtPersonelKullaniciAdi.Name = "txtPersonelKullaniciAdi";
            this.txtPersonelKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.txtPersonelKullaniciAdi.TabIndex = 2;
            this.txtPersonelKullaniciAdi.Text = "Ezgi";
            // 
            // txtPersonelKullaniciSifre
            // 
            this.txtPersonelKullaniciSifre.Location = new System.Drawing.Point(98, 68);
            this.txtPersonelKullaniciSifre.Name = "txtPersonelKullaniciSifre";
            this.txtPersonelKullaniciSifre.PasswordChar = '*';
            this.txtPersonelKullaniciSifre.Size = new System.Drawing.Size(100, 20);
            this.txtPersonelKullaniciSifre.TabIndex = 3;
            this.txtPersonelKullaniciSifre.Text = "0623";
            // 
            // btnPersonelKullaniciGiris
            // 
            this.btnPersonelKullaniciGiris.Location = new System.Drawing.Point(98, 121);
            this.btnPersonelKullaniciGiris.Name = "btnPersonelKullaniciGiris";
            this.btnPersonelKullaniciGiris.Size = new System.Drawing.Size(100, 37);
            this.btnPersonelKullaniciGiris.TabIndex = 4;
            this.btnPersonelKullaniciGiris.Text = "GİRİŞ YAP";
            this.btnPersonelKullaniciGiris.UseVisualStyleBackColor = true;
            this.btnPersonelKullaniciGiris.Click += new System.EventHandler(this.btnPersonelKullaniciGiris_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPersonelKullaniciGiris);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPersonelKullaniciSifre);
            this.groupBox1.Controls.Add(this.txtPersonelKullaniciAdi);
            this.groupBox1.Location = new System.Drawing.Point(95, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 183);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SİSTEM GİRİŞ BİLGİLERİ";
            // 
            // btnKayitPersonel
            // 
            this.btnKayitPersonel.Location = new System.Drawing.Point(193, 281);
            this.btnKayitPersonel.Name = "btnKayitPersonel";
            this.btnKayitPersonel.Size = new System.Drawing.Size(100, 37);
            this.btnKayitPersonel.TabIndex = 6;
            this.btnKayitPersonel.Text = "KAYIT OL";
            this.btnKayitPersonel.UseVisualStyleBackColor = true;
            this.btnKayitPersonel.Click += new System.EventHandler(this.btnKayitPersonel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "İLK KEZ GİRİŞ YAPACAK İSENİZ KAYIT OL BUTONUNA TIKLAYINIZ!";
            // 
            // frmPersonelKullanıcı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(470, 341);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKayitPersonel);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPersonelKullanıcı";
            this.Text = "PERSONEL KULLANICI GİRİŞ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPersonelKullaniciAdi;
        private System.Windows.Forms.TextBox txtPersonelKullaniciSifre;
        private System.Windows.Forms.Button btnPersonelKullaniciGiris;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKayitPersonel;
        private System.Windows.Forms.Label label3;
    }
}