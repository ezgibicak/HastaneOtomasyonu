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

namespace HastaneOtomasyonu.PERSONEL.Kontroller
{
    public partial class frmHastaBilgileriGüncelle : Form
    {
        public frmHastaBilgileriGüncelle()
        {
            InitializeComponent();
        }
        int hastaid;
        string ad;
        string soyad;
        int tc;

        public frmHastaBilgileriGüncelle(int id,string Ad,string Soyad,int Tc)
        {
            hastaid = id;
            ad = Ad;
            soyad = Soyad;
            tc = Tc;
            InitializeComponent();
        }

        private void frmHastaBilgileriGüncelle_Load(object sender, EventArgs e)
        {
            HastaneBL bl = new HastaneBL();
            comboBox1.DataSource = bl.KanGrubu();
            comboBox1.DisplayMember = "KanGrubuAdi";
            comboBox1.ValueMember = "KanGrubuID";
            txtHastaID.Text = hastaid + "";
            txtAd.Text = ad;
            txtTc.Text = tc + "";
            txtSoyad.Text = soyad + "";
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

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int tc = Convert.ToInt32(txtTc.Text);
                int id = Convert.ToInt32(txtHastaID.Text);
                int cepno = Convert.ToInt32(txtCepNo.Text);
                decimal kilo = Convert.ToDecimal(txtKilo.Text);
                decimal boy = Convert.ToDecimal(txtBoy.Text);
                DateTime dt = Convert.ToDateTime(txtDogumTarihi.Text);
                HastaBL bl = new HastaBL();
                int sonuc=(int)bl.HastaBilgileriGüncelle(txtAd.Text, txtSoyad.Text, tc, id, cepno, dt, kilo, boy, (int)(comboBox1.SelectedValue));
                if (sonuc > 0)
                {
                    MessageBox.Show("Başarıyla Güncellendi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen boş bırakmayarak doğru bilgiler giriniz.");
            }
        }
    }
}
