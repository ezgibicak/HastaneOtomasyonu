﻿namespace HastaneOtomasyonu.HASTA
{
    partial class BilgiGüncellemeKontrolü
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
            this.btnSifreKontrol = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifreKontrol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSifreKontrol2 = new System.Windows.Forms.TextBox();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSifreGüncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ŞİFRE:";
            // 
            // btnSifreKontrol
            // 
            this.btnSifreKontrol.Location = new System.Drawing.Point(85, 106);
            this.btnSifreKontrol.Name = "btnSifreKontrol";
            this.btnSifreKontrol.Size = new System.Drawing.Size(133, 33);
            this.btnSifreKontrol.TabIndex = 1;
            this.btnSifreKontrol.Text = "GÜNCELLE";
            this.btnSifreKontrol.UseVisualStyleBackColor = true;
            this.btnSifreKontrol.Click += new System.EventHandler(this.btnSifreKontrol_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bilgilerinizi Güncellemek için Şifrenizi girin.";
            // 
            // txtSifreKontrol
            // 
            this.txtSifreKontrol.Location = new System.Drawing.Point(118, 66);
            this.txtSifreKontrol.Name = "txtSifreKontrol";
            this.txtSifreKontrol.PasswordChar = '*';
            this.txtSifreKontrol.Size = new System.Drawing.Size(100, 20);
            this.txtSifreKontrol.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şifre Güncellemesi";
            // 
            // txtSifreKontrol2
            // 
            this.txtSifreKontrol2.Location = new System.Drawing.Point(118, 191);
            this.txtSifreKontrol2.Name = "txtSifreKontrol2";
            this.txtSifreKontrol2.PasswordChar = '*';
            this.txtSifreKontrol2.Size = new System.Drawing.Size(100, 20);
            this.txtSifreKontrol2.TabIndex = 5;
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(118, 231);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.PasswordChar = '*';
            this.txtYeniSifre.Size = new System.Drawing.Size(100, 20);
            this.txtYeniSifre.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Eski Şifre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Yeni Şifre";
            // 
            // btnSifreGüncelle
            // 
            this.btnSifreGüncelle.Location = new System.Drawing.Point(95, 273);
            this.btnSifreGüncelle.Name = "btnSifreGüncelle";
            this.btnSifreGüncelle.Size = new System.Drawing.Size(135, 36);
            this.btnSifreGüncelle.TabIndex = 9;
            this.btnSifreGüncelle.Text = "ŞİFRE GÜNCELLEME";
            this.btnSifreGüncelle.UseVisualStyleBackColor = true;
            this.btnSifreGüncelle.Click += new System.EventHandler(this.button1_Click);
            // 
            // BilgiGüncellemeKontrolü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 340);
            this.Controls.Add(this.btnSifreGüncelle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.txtSifreKontrol2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSifreKontrol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSifreKontrol);
            this.Controls.Add(this.label1);
            this.Name = "BilgiGüncellemeKontrolü";
            this.Text = "BilgiGüncellemeKontrolü";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSifreKontrol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSifreKontrol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSifreKontrol2;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSifreGüncelle;
    }
}