namespace HastaneOtomasyonu.PERSONEL
{
    partial class HastaOdaKayıt
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
            this.txtHastaId = new System.Windows.Forms.TextBox();
            this.mntCikisTarihi = new System.Windows.Forms.MonthCalendar();
            this.mntGirisTarihi = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtOdaNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtHastaId
            // 
            this.txtHastaId.Location = new System.Drawing.Point(79, 40);
            this.txtHastaId.Name = "txtHastaId";
            this.txtHastaId.Size = new System.Drawing.Size(121, 20);
            this.txtHastaId.TabIndex = 0;
            // 
            // mntCikisTarihi
            // 
            this.mntCikisTarihi.Location = new System.Drawing.Point(378, 255);
            this.mntCikisTarihi.Name = "mntCikisTarihi";
            this.mntCikisTarihi.TabIndex = 4;
            this.mntCikisTarihi.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mntCikisTarihi_DateChanged);
            // 
            // mntGirisTarihi
            // 
            this.mntGirisTarihi.Location = new System.Drawing.Point(378, 40);
            this.mntGirisTarihi.Name = "mntGirisTarihi";
            this.mntGirisTarihi.TabIndex = 5;
            this.mntGirisTarihi.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mntGirisTarihi_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "HASTA ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ODA NO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "GİRİŞ TARİHİ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ÇIKIŞ TARİHİ:";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(72, 364);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(128, 53);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtOdaNo
            // 
            this.txtOdaNo.Location = new System.Drawing.Point(79, 255);
            this.txtOdaNo.Name = "txtOdaNo";
            this.txtOdaNo.Size = new System.Drawing.Size(121, 20);
            this.txtOdaNo.TabIndex = 11;
            // 
            // HastaOdaKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.txtOdaNo);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mntGirisTarihi);
            this.Controls.Add(this.mntCikisTarihi);
            this.Controls.Add(this.txtHastaId);
            this.Name = "HastaOdaKayıt";
            this.Text = "Hasta Oda Kayıt";
            this.Load += new System.EventHandler(this.HastaOdaKayıt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHastaId;
        private System.Windows.Forms.MonthCalendar mntCikisTarihi;
        private System.Windows.Forms.MonthCalendar mntGirisTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtOdaNo;
    }
}