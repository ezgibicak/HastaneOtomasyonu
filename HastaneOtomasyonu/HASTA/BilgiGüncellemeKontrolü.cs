using HastaneOtomasyonu.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu.HASTA
{
    public partial class BilgiGüncellemeKontrolü : Form
    {
        public BilgiGüncellemeKontrolü()
        {
            InitializeComponent();
        }
        string Sifre;
        string Ad;
        string Soyad;
        string kullaniciadi;
        int Cepno;
        int Tc;
        DateTime dogumtarihi;
        int id;
        decimal Kilo;
        decimal Boy;
        public  BilgiGüncellemeKontrolü(string ad,string soyad,int tc,int id,string sifre,string kullaniciadi,int cepno,DateTime dt,
            decimal boy,decimal kilo)
        {
            this.Sifre = sifre;
            this.Ad = ad;
            this.Soyad = soyad;
            this.Tc = tc;
            this.Cepno = cepno;
            this.kullaniciadi = kullaniciadi;
            this.Kilo = kilo;
            this.Boy = boy;
            this.id = id;
            this.dogumtarihi = dt;
            InitializeComponent();
        }
        int sayac;

        private void btnSifreKontrol_Click(object sender, EventArgs e)
        {
            
            if (sayac < 3)
            {

                if (txtSifreKontrol.Text != Sifre)
                {
                    MessageBox.Show("Yanlış Şifre Girdiniz.");
                    sayac++;
                }
                else
                {
                    HastaBL bl = new HastaBL();
                    bl.HastaBilgileriGüncelle(Ad, Soyad, Tc, id, Cepno, dogumtarihi,Kilo,Boy);
                    if (txtYeniSifre.Text == "")
                    {
                        bl.HastaKullanıcıBilgileriGüncelle(id, kullaniciadi, Sifre);


                    }
                    else
                    {
                        bl.HastaKullanıcıBilgileriGüncelle(id, kullaniciadi, txtYeniSifre.Text);
                    }

                    MessageBox.Show("Başarılı Giriş.Güncelleme işleminiz başarılı.");
                    
                }
            }
            else
            {
                MessageBox.Show("İşlem hakkınız bitti.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (sayac < 3)
            {

                if (txtSifreKontrol2.Text!=Sifre)
                {
                    MessageBox.Show("Yanlış Şifre Girdiniz.");
                    sayac++;
                }
                else
                {
                    HastaBL bl = new HastaBL();
                    
                    bl.HastaKullanıcıBilgileriGüncelle(id, kullaniciadi, txtYeniSifre.Text);

                    MessageBox.Show("Başarılı Giriş.Güncelleme işleminiz başarılı.");
                    
                }
            }
            else
            {
                MessageBox.Show("İşlem hakkınız bitti.");
            }
        }
    }
}
