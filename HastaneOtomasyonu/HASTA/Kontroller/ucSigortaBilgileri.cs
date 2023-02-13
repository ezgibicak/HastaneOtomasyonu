using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneOtomasyonu.BL;
using HastaneOtomasyonu.Entity.Dto;

namespace HastaneOtomasyonu.HASTA.Kontroller
{
    public partial class ucSigortaBilgileri : UserControl
    {
        public ucSigortaBilgileri()
        {
            InitializeComponent();
        }
        string kullanici;
        string sifre;
        string ad;
        string soyad;
        public ucSigortaBilgileri(string Kullanici, string Sifre)
        {
            this.kullanici = Kullanici;
            this.sifre = Sifre;
            InitializeComponent();
        }
        public ucSigortaBilgileri(string Kullanici,string Sifre,string Ad,string Soyad)
        {
            this.kullanici = Kullanici;
            this.sifre = Sifre;
            this.ad = Ad;
            this.soyad = Soyad;
            InitializeComponent();
        }

        private void ucSigortaBilgileri_Load(object sender, EventArgs e)
        {
            try
            {
                HastaBL bl = new HastaBL();

                lblAd.Text = bl.SigortaBilgileriGetir(kullanici, sifre).HastaAdi;
                lblSoyad.Text = bl.SigortaBilgileriGetir(kullanici, sifre).HastaSoyadi;
                lblTc.Text = bl.SigortaBilgileriGetir(kullanici, sifre).Tc.ToString();
                lblSigortaTürü.Text = bl.SigortaBilgileriGetir(kullanici, sifre).SigortaAdi;
                lblSigortaNo.Text = bl.SigortaBilgileriGetir(kullanici, sifre).SigortaNo.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("HATA!!!");
            }
            
         

        }
    }
}
