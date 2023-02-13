namespace HastaneOtomasyonu
{
    partial class frmHastaKullanici
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHastaKullaniciGiris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHastalKullaniciSifre = new System.Windows.Forms.TextBox();
            this.txtHastaKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHastaKayıt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnHastaKullaniciGiris);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHastalKullaniciSifre);
            this.groupBox1.Controls.Add(this.txtHastaKullaniciAdi);
            this.groupBox1.Location = new System.Drawing.Point(67, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 217);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SİSTEM GİRİŞ BİLGİLERİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // btnHastaKullaniciGiris
            // 
            this.btnHastaKullaniciGiris.Location = new System.Drawing.Point(114, 143);
            this.btnHastaKullaniciGiris.Name = "btnHastaKullaniciGiris";
            this.btnHastaKullaniciGiris.Size = new System.Drawing.Size(100, 37);
            this.btnHastaKullaniciGiris.TabIndex = 4;
            this.btnHastaKullaniciGiris.Text = "GİRİŞ YAP";
            this.btnHastaKullaniciGiris.UseVisualStyleBackColor = true;
            this.btnHastaKullaniciGiris.Click += new System.EventHandler(this.btnPersonelKullaniciGiris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // txtHastalKullaniciSifre
            // 
            this.txtHastalKullaniciSifre.Location = new System.Drawing.Point(114, 90);
            this.txtHastalKullaniciSifre.Name = "txtHastalKullaniciSifre";
            this.txtHastalKullaniciSifre.PasswordChar = '*';
            this.txtHastalKullaniciSifre.Size = new System.Drawing.Size(100, 20);
            this.txtHastalKullaniciSifre.TabIndex = 3;
            this.txtHastalKullaniciSifre.Text = "1111";
            // 
            // txtHastaKullaniciAdi
            // 
            this.txtHastaKullaniciAdi.Location = new System.Drawing.Point(114, 45);
            this.txtHastaKullaniciAdi.Name = "txtHastaKullaniciAdi";
            this.txtHastaKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.txtHastaKullaniciAdi.TabIndex = 2;
            this.txtHastaKullaniciAdi.Text = "Ahmet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "İLK KEZ GİRİŞ YAPACAK İSENİZ KAYIT OL BUTONUNA TIKLAYINIZ!";
            // 
            // btnHastaKayıt
            // 
            this.btnHastaKayıt.Location = new System.Drawing.Point(181, 298);
            this.btnHastaKayıt.Name = "btnHastaKayıt";
            this.btnHastaKayıt.Size = new System.Drawing.Size(100, 37);
            this.btnHastaKayıt.TabIndex = 8;
            this.btnHastaKayıt.Text = "KAYIT OL";
            this.btnHastaKayıt.UseVisualStyleBackColor = true;
            this.btnHastaKayıt.Click += new System.EventHandler(this.btnHastaKayıt_Click);
            // 
            // frmHastaKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(471, 372);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHastaKayıt);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHastaKullanici";
            this.Text = "HASTA KULLANICI GİRİŞ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHastaKullaniciGiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHastalKullaniciSifre;
        private System.Windows.Forms.TextBox txtHastaKullaniciAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHastaKayıt;
    }
}