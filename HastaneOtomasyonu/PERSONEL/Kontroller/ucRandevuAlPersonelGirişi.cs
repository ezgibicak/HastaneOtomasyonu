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

namespace HastaneOtomasyonu.PERSONEL.Kontroller
{
    public partial class ucRandevuAlPersonelGirişi : UserControl
    {
        public ucRandevuAlPersonelGirişi()
        {
            InitializeComponent();
        }

        private void ucRandevuAlPersonelGirişi_Load(object sender, EventArgs e)
        {
            PersonelBL pbl = new PersonelBL();
            cmbPersonel.DataSource = pbl.PersonelGetir();
            cmbPersonel.DisplayMember = "PersonelAdi";
            cmbPersonel.ValueMember = "PersonelID";
        }
        DateTime tarih;
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            string Yil = e.Start.Year.ToString();
            string Ay = e.Start.Month.ToString();
            string Gun = e.Start.Day.ToString();
            tarih = Convert.ToDateTime(Gun + "/" + Ay + "/" + Yil);
        }

        string saat1;
        HastaBL bl = new HastaBL();

        private void button1_Click(object sender, EventArgs e)
        {

            saat1 = button1.Text;
            int id = Convert.ToInt32(txtID.Text);
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


                    bl.RandevuAl((int)cmbPersonel.SelectedValue, ((int)cmbBölüm.SelectedIndex) + 1, txtAciklama.Text, tarih, id, saat1);
                    MessageBox.Show("Randevu Alma İşleminiz Gerçekleştirildi.");
                }

                else
                {
                    MessageBox.Show("Aynı Tarih ve Saate Başka Randevu Kayıtlıdır.");

                }
            }
        }

        private void btnSaat11_Click(object sender, EventArgs e)
        {
            saat1 = btnSaat11.Text;
            int id = Convert.ToInt32(txtID.Text);
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


                    bl.RandevuAl((int)cmbPersonel.SelectedValue, ((int)cmbBölüm.SelectedIndex) + 1, txtAciklama.Text, tarih, id, saat1);
                    MessageBox.Show("Randevu Alma İşleminiz Gerçekleştirildi.");
                }

                else
                {
                    MessageBox.Show("Aynı Tarih ve Saate Başka Randevu Kayıtlıdır.");
                }
            }
        }

        private void btn11bucuk_Click(object sender, EventArgs e)
        {
            saat1 = btn11bucuk.Text;
            int id = Convert.ToInt32(txtID.Text);
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
            int id = Convert.ToInt32(txtID.Text);
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


                    bl.RandevuAl((int)cmbPersonel.SelectedValue, ((int)cmbBölüm.SelectedIndex) + 1, txtAciklama.Text, tarih, id, saat1);
                    MessageBox.Show("Randevu Alma İşleminiz Gerçekleştirildi.");
                }

                else
                {
                    MessageBox.Show("Aynı Tarih ve Saate Başka Randevu Kayıtlıdır.");
                }
            }

        }





        private void btn13bucuk_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
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


                    bl.RandevuAl((int)cmbPersonel.SelectedValue, ((int)cmbBölüm.SelectedIndex) + 1, txtAciklama.Text, tarih, id, saat1);
                    MessageBox.Show("Randevu Alma İşleminiz Gerçekleştirildi.");
                }

                else
                {
                    MessageBox.Show("Aynı Tarih ve Saate Başka Randevu Kayıtlıdır.");
                }
            }


        }

        private void btn14_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
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


                    bl.RandevuAl((int)cmbPersonel.SelectedValue, ((int)cmbBölüm.SelectedIndex) + 1, txtAciklama.Text, tarih, id, saat1);
                    MessageBox.Show("Randevu Alma İşleminiz Gerçekleştirildi.");
                }

                else
                {
                    MessageBox.Show("Aynı Tarih ve Saate Başka Randevu Kayıtlıdır.");
                }
            }
        }

        private void btn14bucuk_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
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

                    bl.RandevuAl((int)cmbPersonel.SelectedValue, ((int)cmbBölüm.SelectedIndex) + 1, txtAciklama.Text, tarih, id, saat1);
                    MessageBox.Show("Randevu Alma İşleminiz Gerçekleştirildi.");
                }

                else
                {
                    MessageBox.Show("Aynı Tarih ve Saate Başka Randevu Kayıtlıdır.");
                }
            }
        }

        private void btn15_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
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