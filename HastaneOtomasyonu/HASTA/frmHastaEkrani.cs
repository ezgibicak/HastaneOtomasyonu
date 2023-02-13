using HastaneOtomasyonu.Entity.Domain;
using HastaneOtomasyonu.HASTA;
using HastaneOtomasyonu.HASTA.Kontroller;
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
    public partial class frmHastaEkrani : Form
    {
        public frmHastaEkrani()
        {
            InitializeComponent();
        }
        string adi;
        string sifre;
        private static frmHastaEkrani panel;
        public static frmHastaEkrani EkranıGetir()
        {
            if (panel == null)
            {
                panel = new frmHastaEkrani();
            }
            return panel;

        }

        public frmHastaEkrani(string kullanici,string Sifre)
        {
            this.adi = kullanici;
            this.sifre = Sifre;
            InitializeComponent();

        }
        string hastaadi;
        string soyadi;

        public frmHastaEkrani(string kullanici, string Sifre,string hastaadi,string soyadi)
        {
            this.adi = kullanici;
            this.sifre = Sifre;
            this.hastaadi = hastaadi;
            this.soyadi=soyadi;
            InitializeComponent();

        }


        private void frmHastaEkrani_Load(object sender, EventArgs e)
        {
            StripStatusLabel3Saat.Text = DateTime.Now.ToString();
            StatusLabelHastaAktif.Text = adi;
        }

        private void gÖSTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucbilgilerigetir ucbilgiler = new ucbilgilerigetir();
            panel1.Controls.Clear();
            panel1.Controls.Add(ucbilgiler);
        }

        private void gÜNCELLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucbilgilerigüncelle ucgüncelle = new ucbilgilerigüncelle();
            panel1.Controls.Clear();
            panel1.Controls.Add(ucgüncelle);
        }

        private void çALIŞANPERSONELLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucCalisanPersoneller uc = new ucCalisanPersoneller();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void randevuBilgilerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucRandevuBilgileri uc = new ucRandevuBilgileri(adi,sifre);
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void randevuAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucRandevuAl uc = new ucRandevuAl(adi,sifre);
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void sİGORTABİLGİLERİMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucSigortaBilgileri uc = new ucSigortaBilgileri(adi,sifre,hastaadi,soyadi);
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void sONUÇLARIMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucSonuclar uc = new ucSonuclar(adi, sifre);
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }
    }
}
