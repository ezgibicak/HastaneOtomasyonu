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
    public partial class uckisiselbilgilerhasta : UserControl
    {
        public uckisiselbilgilerhasta()
        {
            InitializeComponent();
        }
        string kullanici;
        string sifre;
        public uckisiselbilgilerhasta(string Kullanici, string sifre)
        {
            this.kullanici = Kullanici;
            this.sifre = sifre;
            InitializeComponent();
        }


        private void uckisiselbilgilerhasta_Load(object sender, EventArgs e)
        {
            //PersonelBL pbl = new PersonelBL();
            //cmbPersonelId.DataSource = pbl.PersonelGetir();
            //cmbPersonelId.DisplayMember = "PersonelAdi";
            //cmbPersonelId.ValueMember = "PersonelID";
        }

        private void button2_Click(object sender, EventArgs e)
        {

          
            try
            {
                
                if (txtSifre.Text == "")
                {
                    MessageBox.Show("Şifre Boş Kalamaz.");
                }
                if (txtKullaniciAdi.Text == "")
                {
                    MessageBox.Show("Kullanıcı Adı Boş Kalamaz.");
                }
                else
                {

                    HastaBL bl = new HastaBL();
                    KullaniciBL kbl = new KullaniciBL();

                    int id = Convert.ToInt32(txtHastaID.Text);
                    bool durum = kbl.AynıKayıt(txtKullaniciAdi.Text, txtSifre.Text, id);
                    if (durum == true)
                    {
                        bl.HastaKayıt(id, txtKullaniciAdi.Text, txtSifre.Text);
                       // bl.HastaKayıtBilgileriGetir(id, txtAdi.Text, txtSoyad.Text, tc, dt, cepno);
                        MessageBox.Show("Kullanıcı Bilgileriniz Kaydoldu.");
                        if (txtAdi.Text != null && txtSoyad.Text != null && txtTC.Text != null && txtHastaID.Text != null && txtKullaniciAdi.Text != null && txtSifre.Text != null)
                        {
                            frmHastaEkrani frm = new frmHastaEkrani(txtKullaniciAdi.Text, txtSifre.Text, txtAdi.Text, txtSoyad.Text);
                            MessageBox.Show("Kaydınız Başarıyla Oluşturuldu.");
                            this.Hide();
                            frm.Show();
                        }
                        else
                            MessageBox.Show("Lütfen Boş Bırakmayınız.");
                    }

                    else
                    {
                        MessageBox.Show("Bu kullanıcı kayıtlı.Lütfen başka kullanıcı adı veya şifre girin.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Bir hata oluştu.Boş Kalan yerleri  doğru bir şekilde doldurunuz.");


            }

           
        }
        int tc;
        int cepno;
        DateTime dt;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                HastaBL bl = new HastaBL();
                tc = Convert.ToInt32(txtTC.Text);
                cepno = Convert.ToInt32(txtCepNo.Text);
                int id = Convert.ToInt32(txtHastaID.Text);
                dt = Convert.ToDateTime(txtDogumTarihi.Text);


                bl.HastaKayıtBilgileriGetir(id, txtAdi.Text, txtSoyad.Text, tc, dt, cepno);

                if (txtAdi.Text == null && txtSoyad.Text == null && txtTC.Text == null && txtHastaID.Text == null)
                {
                    MessageBox.Show("Lütfen Boş Kalan Yerleri Doldurunuz.");
                }
                else
                {

                    MessageBox.Show("Kişisel Bilgileriniz Kaydoldu.");



                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Bir hata oluştu.Boş Kalan yerleri  doğru bir şekilde doldurunuz.");
                txtHastaID.Text = "";
                txtKullaniciAdi.Text = "";
                txtSifre.Text = "";

            }
        }
    }
}

