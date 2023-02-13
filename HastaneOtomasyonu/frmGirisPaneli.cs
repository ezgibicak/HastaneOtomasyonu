using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class frmGirisPaneli : Form
    {
        public frmGirisPaneli()
        {
            InitializeComponent();
        }

        private void btnPersonelGiris_Click(object sender, EventArgs e)
        {
            frmPersonelKullanıcı frm = new frmPersonelKullanıcı(); 
            frm.Show();
        }

        private void frmGirisPaneli_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Application.StartupPath + "\\hastane.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnHastaGiris_Click(object sender, EventArgs e)
        {
            frmHastaKullanici frm = new frmHastaKullanici();
            frm.Show();
            
        }
    }
}
