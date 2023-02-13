using HastaneOtomasyonu.Entity;
using HastaneOtomasyonu.HASTA.Kontroller;
using HastaneOtomasyonu.PERSONEL;
using HastaneOtomasyonu.PERSONEL.Kontroller;
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
    public partial class frmPersonel : Form
    {
        public frmPersonel()
        {
            InitializeComponent();
        }
        private static KullaniciPersonel AktifKullanici;
        public frmPersonel (KullaniciPersonel kullanıcı)
        {
            AktifKullanici = kullanıcı;
                
        }
        private static frmPersonel FormNesnesi;
        public static frmPersonel FormNesnesiGetir()
        {
            if (FormNesnesi == null)
            {
                FormNesnesi = new frmPersonel();
            }
            return FormNesnesi;
        }

        private void frmPersonelEkrani_Load(object sender, EventArgs e)
        {
            // StatusLabelAktifKullanici.Text = AktifKullanici.KullaniciAdi;
            
             StripStatusLabelGirisSaati.Text = DateTime.Now.ToString();


        }

        private void gÖSTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucPersonelBilgileriGetir uc = new ucPersonelBilgileriGetir();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);

        }

        private void fATURABİLGİSİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucHastaFatura uc = new ucHastaFatura();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void yENİKAYITFATURAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucYeniFatura uc = new ucYeniFatura();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void odaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucOda uc = new ucOda();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        

        private void hastaKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucHastaKayıt uc = new ucHastaKayıt();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void hastaSonuçlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucSonuclarTumu uc = new ucSonuclarTumu();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void hastaBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucHastaBilgileriTümü uc = new ucHastaBilgileriTümü();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void hastaÇıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucCikisBilgileri uc = new ucCikisBilgileri();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void randevuAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucRandevuAlPersonelGirişi uc = new ucRandevuAlPersonelGirişi();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void randevuBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucRandevuTümü uc = new ucRandevuTümü();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void gÜNCELLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucPersonelBilgileriGüncelle uc = new ucPersonelBilgileriGüncelle();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }
    }
}
