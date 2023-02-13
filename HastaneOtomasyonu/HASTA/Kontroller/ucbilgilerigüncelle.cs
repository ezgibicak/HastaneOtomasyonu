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
    public partial class ucbilgilerigüncelle : UserControl
    {
        public ucbilgilerigüncelle()
        {
            InitializeComponent();
        }
        int id;
        public ucbilgilerigüncelle(int hastaid)
        {
            id = hastaid;
            InitializeComponent();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
           
            if (txtHastaID.Text == "")
            {
                MessageBox.Show("Lütfen ID Giriniz!!!");
            }
            else
            {
                try
                {

                    HastaBL bl = new HastaBL();
                    int hastaid = Convert.ToInt32(txtHastaID.Text);
                    txtAd.Text = bl.HastaBilgileriGöster(hastaid).Adi;
                    txtSoyad.Text = bl.HastaBilgileriGöster(hastaid).Soyadi;
                    txtKullaniciAdi.Text = bl.HastaBilgileriGöster(hastaid).KullaniciAdi;
                    txtSifre.Text = bl.HastaBilgileriGöster(hastaid).Sifre;
                    txtDogumTarihi.Text = bl.HastaBilgileriGöster(hastaid).Dogumtarihi.ToString();
                    txtKilo.Text = bl.HastaBilgileriGöster(hastaid).Kilo.ToString();
                    txtBoy.Text = bl.HastaBilgileriGöster(hastaid).Boy.ToString();
                    txtTc.Text = bl.HastaBilgileriGöster(hastaid).TCno.ToString();
                    txtCepNo.Text = bl.HastaBilgileriGöster(hastaid).CepNo.ToString();
                    //dataGridView1.DataSource = bl.HastaBilgileriGöster(hastaid);
                }
                catch
                {
                    MessageBox.Show(txtHastaID.Text + " ID NUMARALI KAYIT BULUNAMADI");
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tx = (TextBox)item;
                    tx.Clear();

                }
            }
        }

        private void btnGüncelle_Click_1(object sender, EventArgs e)
        {
            try
            {
                int tc = Convert.ToInt32(txtTc.Text);
                int id = Convert.ToInt32(txtHastaID.Text);
                int cepno = Convert.ToInt32(txtCepNo.Text);
                decimal kilo = Convert.ToDecimal(txtKilo.Text);
                decimal boy = Convert.ToDecimal(txtBoy.Text);
                DateTime dt = Convert.ToDateTime(txtDogumTarihi.Text);
                BilgiGüncellemeKontrolü frm = new BilgiGüncellemeKontrolü(txtAd.Text, txtSoyad.Text, tc, id, txtSifre.Text, txtKullaniciAdi.Text, cepno, dt, boy, kilo);
                frm.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lütfen boş bırakmayarak doğru bilgiler giriniz.");
            }
        }

        private void ucbilgilerigüncelle_Load(object sender, EventArgs e)
        {
            txtSifre.Visible = false;
            label10.Visible = false;
        }
    }
}
