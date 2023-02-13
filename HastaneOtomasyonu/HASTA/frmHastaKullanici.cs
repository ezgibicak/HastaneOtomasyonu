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
using HastaneOtomasyonu.Entity.Domain;
using HastaneOtomasyonu.HASTA;

namespace HastaneOtomasyonu
{
    public partial class frmHastaKullanici : Form
    {
        public frmHastaKullanici()
        {
            InitializeComponent();
        }
        int sayac;
        private void btnPersonelKullaniciGiris_Click(object sender, EventArgs e)
        {
            KullaniciBL kbl = new KullaniciBL();
            KullaniciHasta hasta = kbl.HastaKullaniciGiris(txtHastaKullaniciAdi.Text, txtHastalKullaniciSifre.Text);
            if (hasta == null)
            {
                MessageBox.Show("Giriş Başarısız.Kayıt Bulunamadı.");
                sayac++;
                if (sayac == 3)
                {
                    MessageBox.Show("Hakkınız Bitmiştir.");
                    btnHastaKullaniciGiris.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Giriş Başarılı");
               // frmHastaEkrani frm = frmHastaEkrani.EkranıGetir();
                frmHastaEkrani frm = new frmHastaEkrani(txtHastaKullaniciAdi.Text,txtHastalKullaniciSifre.Text);
                frm.Show();
                this.Hide();
            }
           
        }

        private void btnHastaKayıt_Click(object sender, EventArgs e)
        {
            
            frmHastaKayıt frm = new frmHastaKayıt();
            frm.Show();
            this.Hide();
        }
    }
}
