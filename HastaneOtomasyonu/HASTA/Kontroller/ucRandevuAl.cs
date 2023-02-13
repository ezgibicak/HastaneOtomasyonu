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

namespace HastaneOtomasyonu.HASTA.Kontroller
{
    public partial class ucRandevuAl : UserControl
    {
        public ucRandevuAl()
        {
            InitializeComponent();
        }

        string kullaniciadi;
        string Sifre;
        public ucRandevuAl(string kullanici,string sifre)
        {
            this.kullaniciadi = kullanici;
            this.Sifre = sifre;
            InitializeComponent();
        }
        HastaBL bl = new HastaBL();
        int id;
        PersonelBL pbl = new PersonelBL();
        private void ucRandevuAl_Load(object sender, EventArgs e)
        {
          

            cmbPersonel.DataSource = pbl.PersonelGetir();
            cmbPersonel.DisplayMember = "PersonelAdi";
            cmbPersonel.ValueMember ="PersonelID";
        }
        DateTime tarih;
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            string Yil = e.Start.Year.ToString();
            string Ay = e.Start.Month.ToString();
            string Gun = e.Start.Day.ToString();
            tarih = Convert.ToDateTime(Gun + "/" + Ay + "/" + Yil);
           //// tarih=Convert.ToDateTime(btnSaat11.Text).Hour;
           // MessageBox.Show(tarih+"");
        }
        KullaniciBL kbl = new KullaniciBL();
        string saat1;
        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            saat1 = button1.Text;
            DateTime bugününtarihi = new DateTime();
            bugününtarihi = DateTime.Now;
            int result = DateTime.Compare(tarih, bugününtarihi);
            if (result < 0)
            {
                MessageBox.Show("Randevu Tarihi Geçmiştir.");
            }
            else
            {

                bool durum = bl.RandevuAynıKayıt(tarih, saat1, (int)cmbPersonel.SelectedValue);
                if (durum == true)
                {
                    
                    kbl = new KullaniciBL();
                    id = kbl.HastaKullaniciGiris(kullaniciadi, Sifre).HastaID;
                    bl.RandevuAl((int)cmbPersonel.SelectedValue, ((int)cmbBölüm.SelectedIndex) + 1, txtAciklama.Text, tarih, id, saat1);
                    MessageBox.Show("Randevu Alma İşleminiz Gerçekleştirildi.");
                }

                else
                {
                    MessageBox.Show("Aynı Tarih ve Saate Başka Randevu Kayıtlıdır.");
                    //btn.BackColor = Color.Gray;
                    //btn.Text = "DOLU";
                }
            }

        }

        private void btnSaat11_Click(object sender, EventArgs e)
        {
            saat1 = btnSaat11.Text;
            DateTime bugününtarihi = new DateTime();
            bugününtarihi = DateTime.Now;
            int result = DateTime.Compare(tarih, bugününtarihi);
            if (result < 0)
            {
                MessageBox.Show("Randevu Tarihi Geçmiştir.");
            }
            else
            {

                bool durum = bl.RandevuAynıKayıt(tarih, saat1, (int)cmbPersonel.SelectedValue);
                if (durum == true)
                {
                    
                    kbl = new KullaniciBL();
                    id = kbl.HastaKullaniciGiris(kullaniciadi, Sifre).HastaID;
                    bl.RandevuAl((int)cmbPersonel.SelectedValue, ((int)cmbBölüm.SelectedIndex) + 1, txtAciklama.Text, tarih, id, saat1);
                    MessageBox.Show("Randevu Alma İşleminiz Gerçekleştirildi.");
                }

                else
                {
                    MessageBox.Show("Aynı Tarih ve Saate Başka Randevu Kayıtlıdır.");
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            saat1 = btn11bucuk.Text;
            DateTime bugününtarihi = new DateTime();
            bugününtarihi = DateTime.Now;
            int result = DateTime.Compare(tarih, bugününtarihi);
            if (result < 0)
            {
                MessageBox.Show("Randevu Tarihi Geçmiştir.");
            }
            else
            {

                bool durum = bl.RandevuAynıKayıt(tarih, saat1, (int)cmbPersonel.SelectedValue);
                if (durum == true)
                {

                    kbl = new KullaniciBL();
                    id = kbl.HastaKullaniciGiris(kullaniciadi, Sifre).HastaID;
                    bl.RandevuAl((int)cmbPersonel.SelectedValue, ((int)cmbBölüm.SelectedIndex) + 1, txtAciklama.Text, tarih, id, saat1);
                    MessageBox.Show("Randevu Alma İşleminiz Gerçekleştirildi.");
                }

                else
                {
                    MessageBox.Show("Aynı Tarih ve Saate Başka Randevu Kayıtlıdır.");
                }
            }

        }

        private void btn12_Click(object sender, EventArgs e)
        {

            saat1 = btn12.Text;
            DateTime bugününtarihi = new DateTime();
            bugününtarihi = DateTime.Now;
            int result = DateTime.Compare(tarih, bugününtarihi);
            if (result < 0)
            {
                MessageBox.Show("Randevu Tarihi Geçmiştir.");
            }
            else
            {

                bool durum = bl.RandevuAynıKayıt(tarih, saat1, (int)cmbPersonel.SelectedValue);
                if (durum == true)
                {

                    kbl = new KullaniciBL();
                    id = kbl.HastaKullaniciGiris(kullaniciadi, Sifre).HastaID;
                    bl.RandevuAl((int)cmbPersonel.SelectedValue, ((int)cmbBölüm.SelectedIndex) + 1, txtAciklama.Text, tarih, id, saat1);
                    MessageBox.Show("Randevu Alma İşleminiz Gerçekleştirildi.");
                }

                else
                {
                    MessageBox.Show("Aynı Tarih ve Saate Başka Randevu Kayıtlıdır.");
                }
            }

        }

        private void btn13bucuk_Click(object sender, EventArgs e)
        {

            saat1 = btn13bucuk.Text;
            DateTime bugününtarihi = new DateTime();
            bugününtarihi = DateTime.Now;
            int result = DateTime.Compare(tarih, bugününtarihi);
            if (result < 0)
            {
                MessageBox.Show("Randevu Tarihi Geçmiştir.");
            }
            else
            {

                bool durum = bl.RandevuAynıKayıt(tarih, saat1, (int)cmbPersonel.SelectedValue);
                if (durum == true)
                {

                    kbl = new KullaniciBL();
                    id = kbl.HastaKullaniciGiris(kullaniciadi, Sifre).HastaID;
                    bl.RandevuAl((int)cmbPersonel.SelectedValue, ((int)cmbBölüm.SelectedIndex) + 1, txtAciklama.Text, tarih, id, saat1);
                    MessageBox.Show("Randevu Alma İşleminiz Gerçekleştirildi.");
                }

                else
                {
                    MessageBox.Show("Aynı Tarih ve Saate Başka Randevu Kayıtlıdır.");
                }
            }

        }

        private void btn14_Click(object sender, EventArgs e)
        {
            saat1 = btn14.Text;
            DateTime bugününtarihi = new DateTime();
            bugününtarihi = DateTime.Now;
            int result = DateTime.Compare(tarih, bugününtarihi);
            if (result < 0)
            {
                MessageBox.Show("Randevu Tarihi Geçmiştir.");
            }
            else
            {

                bool durum = bl.RandevuAynıKayıt(tarih, saat1, (int)cmbPersonel.SelectedValue);
                if (durum == true)
                {

                    kbl = new KullaniciBL();
                    id = kbl.HastaKullaniciGiris(kullaniciadi, Sifre).HastaID;
                    bl.RandevuAl((int)cmbPersonel.SelectedValue, ((int)cmbBölüm.SelectedIndex) + 1, txtAciklama.Text, tarih, id, saat1);
                    MessageBox.Show("Randevu Alma İşleminiz Gerçekleştirildi.");
                }

                else
                {
                    MessageBox.Show("Aynı Tarih ve Saate Başka Randevu Kayıtlıdır.");
                }
            }
        }

        private void btn14bucuk_Click(object sender, EventArgs e)
        {
            saat1 = btn14bucuk.Text;
            DateTime bugününtarihi = new DateTime();
            bugününtarihi = DateTime.Now;
            int result = DateTime.Compare(tarih, bugününtarihi);
            if (result < 0)
            {
                MessageBox.Show("Randevu Tarihi Geçmiştir.");
            }
            else
            {

                bool durum = bl.RandevuAynıKayıt(tarih, saat1, (int)cmbPersonel.SelectedValue);
                if (durum == true)
                {

                    kbl = new KullaniciBL();
                    id = kbl.HastaKullaniciGiris(kullaniciadi, Sifre).HastaID;
                    bl.RandevuAl((int)cmbPersonel.SelectedValue, ((int)cmbBölüm.SelectedIndex) + 1, txtAciklama.Text, tarih, id, saat1);
                    MessageBox.Show("Randevu Alma İşleminiz Gerçekleştirildi.");
                }

                else
                {
                    MessageBox.Show("Aynı Tarih ve Saate Başka Randevu Kayıtlıdır.");
                }
            }
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            saat1 = btn15.Text;
            DateTime bugününtarihi = new DateTime();
            bugününtarihi = DateTime.Now;
            int result = DateTime.Compare(tarih, bugününtarihi);
            if (result < 0)
            {
                MessageBox.Show("Randevu Tarihi Geçmiştir.");
            }
            else
            {

                bool durum = bl.RandevuAynıKayıt(tarih, saat1, (int)cmbPersonel.SelectedValue);
                if (durum == true)
                {

                    kbl = new KullaniciBL();
                    id = kbl.HastaKullaniciGiris(kullaniciadi, Sifre).HastaID;
                    bl.RandevuAl((int)cmbPersonel.SelectedValue, ((int)cmbBölüm.SelectedIndex) + 1, txtAciklama.Text, tarih, id, saat1);
                    MessageBox.Show("Randevu Alma İşleminiz Gerçekleştirildi.");
                }

                else
                {
                    MessageBox.Show("Aynı Tarih ve Saate Başka Randevu Kayıtlıdır.");
                }
            }
        }
    }
}
