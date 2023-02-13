
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneOtomasyonu.BL;
using HastaneOtomasyonu.Entity.Domain;

namespace HastaneOtomasyonu
{
    public partial class frmPersonelKayıt : Form
    {
        public frmPersonelKayıt()
        {
            InitializeComponent();
        }
        
    
        int id;
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                PersonelBL psbl = new PersonelBL();
                KullaniciBL kbl = new KullaniciBL();
                int tc = Convert.ToInt32(txtTC.Text);
                int aktif = Convert.ToInt32(txtAktif.Text);
                id = Convert.ToInt32(txtID.Text);
                int cep = Convert.ToInt32(txtCepNo.Text);
                DateTime isebaslamatarihi = Convert.ToDateTime(txtİseBaslama.Text);
                DateTime dogumtarihi = Convert.ToDateTime(txtDogumTarihi.Text);
                
                PersonelBL bl = new PersonelBL();
               
                bool durum = kbl.AynıKayıt(txtKullaniciAdi.Text, txtSifre.Text);
                if (durum == true)
                {
                    psbl.PersonelKayit(id, txtAdi.Text, txtSoyad.Text, tc, cep, dogumtarihi, isebaslamatarihi);
                    int sonuc = (int)bl.personelkullanıcıkayıt(id, txtKullaniciAdi.Text, txtSifre.Text, aktif);
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Kaydınız Başarıyla Yapıldı.");
                        // frmPersonel frm = new frmPersonel();
                        //frmPersonel frm = frmPersonel.FormNesnesiGetir();
                      
                        frmPersonelKullanıcı frm = new frmPersonelKullanıcı();
                        this.Hide();
                        frm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Bu kullanıcı adı ve şifre geçerli değil.");
                    txtKullaniciAdi.Text = "";
                    txtSifre.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA!!!İşlem Başarılı Değil"+ex);

            }
            
        }
    }
}
