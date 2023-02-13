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
    public partial class ucbilgilerigetir : UserControl
    {
        public ucbilgilerigetir()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (txtHastaID.Text == null)
            {
                MessageBox.Show("Lütfen ID Giriniz!!!");
            }
            else
            {
                try
                {

                    HastaBL bl = new HastaBL();
                    int hastaid = Convert.ToInt32(txtHastaID.Text);
                    lblAd.Text = bl.HastaBilgileriGöster(hastaid).Adi;
                    lblSoyad.Text = bl.HastaBilgileriGöster(hastaid).Soyadi;
                    lblKullaniciAdi.Text = bl.HastaBilgileriGöster(hastaid).KullaniciAdi;
                    lblSifre.Text = bl.HastaBilgileriGöster(hastaid).Sifre;
                    lblDogumTarihi.Text = bl.HastaBilgileriGöster(hastaid).Dogumtarihi.ToString();
                    lblKilo.Text= bl.HastaBilgileriGöster(hastaid).Kilo.ToString();
                    lblBoy.Text = bl.HastaBilgileriGöster(hastaid).Boy.ToString();
                    lblTc.Text = bl.HastaBilgileriGöster(hastaid).TCno.ToString();

                    //dataGridView1.DataSource = bl.HastaBilgileriGöster(hastaid);
                }
                catch
                {
                    MessageBox.Show(txtHastaID.Text + " ID NUMARALI KAYIT BULUNAMADI");
                    lblAd.Text = "";
                    lblBoy.Text = "";
                    lblDogumTarihi.Text = "";
                    lblKilo.Text = "";
                    lblKullaniciAdi.Text = "";
                    lblSoyad.Text = "";
                    lblTc.Text = "";
                    txtHastaID.Text = "";
                    lblSifre.Text = "";
                }
            }
        }
    }
}
