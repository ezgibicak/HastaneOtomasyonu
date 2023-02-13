using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneOtomasyonu.BL;
using HastaneOtomasyonu.Entity;


namespace HastaneOtomasyonu
{
    public partial class frmPersonelKullanıcı : Form
    {
        public frmPersonelKullanıcı()
        {
            InitializeComponent();
        }

        private void btnPersonelKullaniciGiris_Click(object sender, EventArgs e)
        {
            KullaniciBL bl = new KullaniciBL();
            KullaniciPersonel kp = bl.PersonelKullaniciGiris(txtPersonelKullaniciAdi.Text, txtPersonelKullaniciSifre.Text);
            if (kp == null)
            {
                MessageBox.Show("Giriş başarısız.");
            }
            else
            {
                MessageBox.Show("Giriş Başarılı.");
               // frmPersonel frm = new frmPersonel();
                frmPersonel frm = frmPersonel.FormNesnesiGetir();
                this.Hide();
                frm.ShowDialog();
               

            }
        }

        private void btnKayitPersonel_Click(object sender, EventArgs e)
        {
            frmPersonelKayıt frm = new frmPersonelKayıt();
            frm.ShowDialog();
            this.Hide();
        }
    }
}
