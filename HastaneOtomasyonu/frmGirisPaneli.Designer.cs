namespace HastaneOtomasyonu
{
    partial class frmGirisPaneli
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
            this.btnPersonelGiris = new System.Windows.Forms.Button();
            this.btnHastaGiris = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPersonelGiris
            // 
            this.btnPersonelGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPersonelGiris.Location = new System.Drawing.Point(70, 260);
            this.btnPersonelGiris.Name = "btnPersonelGiris";
            this.btnPersonelGiris.Size = new System.Drawing.Size(123, 59);
            this.btnPersonelGiris.TabIndex = 0;
            this.btnPersonelGiris.Text = "PERSONEL GİRİŞ";
            this.btnPersonelGiris.UseVisualStyleBackColor = false;
            this.btnPersonelGiris.Click += new System.EventHandler(this.btnPersonelGiris_Click);
            // 
            // btnHastaGiris
            // 
            this.btnHastaGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnHastaGiris.Location = new System.Drawing.Point(251, 260);
            this.btnHastaGiris.Name = "btnHastaGiris";
            this.btnHastaGiris.Size = new System.Drawing.Size(122, 59);
            this.btnHastaGiris.TabIndex = 1;
            this.btnHastaGiris.Text = "HASTA GİRİŞ";
            this.btnHastaGiris.UseVisualStyleBackColor = false;
            this.btnHastaGiris.Click += new System.EventHandler(this.btnHastaGiris_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(42, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 213);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmGirisPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(464, 331);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHastaGiris);
            this.Controls.Add(this.btnPersonelGiris);
            this.Name = "frmGirisPaneli";
            this.Text = "GİRİŞ PANELİ";
            this.Load += new System.EventHandler(this.frmGirisPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersonelGiris;
        private System.Windows.Forms.Button btnHastaGiris;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

