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
    public partial class ucHastaKayıt : UserControl
    {
        public ucHastaKayıt()
        {
            InitializeComponent();
        }
        int sayac;
        int sayac2;
        int sayac3;
        private void ucHastaKayıt_Load(object sender, EventArgs e)
        {
            PersonelBL pbl = new PersonelBL();
            comboBox1.DataSource = pbl.PersonelGetir();
            comboBox1.DisplayMember = "PersonelAdi";
            comboBox1.ValueMember = "PersonelID";
            txtTarih.Text = DateTime.Now.ToString();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "d/M/yyyy";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                HastaneBL bl = new HastaneBL();
                HastaBL hbl = new HastaBL();
                PersonelBL pbl = new PersonelBL();
                DateTime dt = dateTimePicker1.Value;
                int sirano = Convert.ToInt32(txtSiraNo.Text);
                int cepno = Convert.ToInt32(txtCepNo.Text);
                int tc = Convert.ToInt32(txtTc.Text);
                int id = Convert.ToInt32(txtID.Text);
                int siraid = Convert.ToInt32(txtSıraID.Text);
                DateTime tarih = Convert.ToDateTime(txtTarih.Text);
                int sonuc1=(int)hbl.HastaKayıtBilgileriGetir(id, txtAd.Text, txtSoyad.Text,tc,dt,cepno);
                int sonuc2=bl.SiraYazdir(sirano, ((int)cmbBölüm.SelectedIndex) + 1);
                int sonuc3=bl.HastaIlkKayıt(id, siraid, tarih, txtSaglıkSorunu.Text);
                int sonuc4 = pbl.PersonelHasta(id, (int)comboBox1.SelectedValue);
                if (sonuc1>0 && sonuc2>0 && sonuc3 > 0 && sonuc4>0)
                {
                    MessageBox.Show("İşlem Başarıyla Gerçekleştirildi.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA!");
                MessageBox.Show(ex+"");
            }
           

        }

        private void cmbBölüm_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbBölüm.SelectedItem.ToString() == "Dahiliye")
            {
                sayac++;
                txtSiraNo.Text = sayac + "";

            }
            if (cmbBölüm.SelectedItem.ToString() == "Kulak Burun Boğaz")
            {
                sayac2++;
                txtSiraNo.Text = sayac2 + "";


            }
            if (cmbBölüm.SelectedItem.ToString() == "Göz Hastalıkları")
            {
                sayac3++;
                txtSiraNo.Text = sayac3 + "";


            }

        }
    }
}
