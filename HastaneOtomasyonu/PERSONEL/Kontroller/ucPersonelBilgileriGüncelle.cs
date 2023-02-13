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
using HastaneOtomasyonu.Utilities;
using System.IO;

namespace HastaneOtomasyonu.PERSONEL
{
    public partial class ucPersonelBilgileriGüncelle : UserControl
    {
        public ucPersonelBilgileriGüncelle()
        {
            InitializeComponent();
        }

        private void btnPersonelBilgileriGetir_Click(object sender, EventArgs e)
        {
            try
            {
                PersonelBL bl = new PersonelBL();

                int perid = Convert.ToInt32(txtPersonelID.Text);
                txtAd.Text = bl.PersonelBilgileriGetir(perid).PersonelAdi;
                txtSoyad.Text = bl.PersonelBilgileriGetir(perid).PersonelSoyadi;
                txtDogumTarihi.Text = bl.PersonelBilgileriGetir(perid).DogumTarihi.ToString();
                txtTc.Text = bl.PersonelBilgileriGetir(perid).TcNo.ToString();
                txtTarih.Text = bl.PersonelBilgileriGetir(perid).İseBaslamaTarihi.ToString();
                txtCepNo.Text = bl.PersonelBilgileriGetir(perid).CepTelefonu.ToString();
                if (cmbCinsiyet.SelectedValue == null || cmbAdres.SelectedValue == null || cmbAdres.SelectedValue == null)
                {
                    cmbCinsiyet.SelectedValue = "";
                    cmbMeslek.SelectedValue = "";
                    cmbAdres.SelectedValue = "";
                }
                else
                {
                    cmbCinsiyet.SelectedValue = bl.PersonelBilgileriGetir(perid).CinsiyetID;
                    cmbAdres.SelectedValue = bl.PersonelBilgileriGetir(perid).AdresID;
                    cmbMeslek.SelectedValue = bl.PersonelBilgileriGetir(perid).MeslekID;
                }
                pictureBox1.ImageLocation = Application.StartupPath + bl.PersonelBilgileriGetir(perid).FotografYolu;



                if (bl.PersonelBilgileriGetir(perid).FotografYolu == "")
                {
                    pictureBox1.ImageLocation = Application.StartupPath + "\\pers.png";

                }

            }
            catch (Exception)
            {

                MessageBox.Show("İşlem Gerçekleştirilmedi.");
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
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }
                cmbMeslek.SelectedIndex = 0;
                cmbCinsiyet.SelectedIndex = 0;
                cmbAdres.SelectedIndex = 0;
             

            }
        }

        private void ucPersonelBilgileriGüncelle_Load(object sender, EventArgs e)
        {
            HastaneBL hbl = new HastaneBL();
            cmbAdres.DataSource = hbl.AdresBilgileri();
            cmbAdres.ValueMember = "AdresID";
            cmbAdres.DisplayMember = "Adresi";
            cmbCinsiyet.DataSource = hbl.CinsiyetBilgileri();
            cmbCinsiyet.ValueMember = "CinsiyetID";
            cmbCinsiyet.DisplayMember = "Cinsiyeti";
            cmbMeslek.DataSource = hbl.MeslekBilgileri();
            cmbMeslek.ValueMember = "MeslekID";
            cmbMeslek.DisplayMember = "Meslegi";
            cmbCinsiyet.SelectedValue = "ERKEK";

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            try
            {
                PersonelBL bl = new PersonelBL();
                int tc = Convert.ToInt32(txtTc.Text);
                int perid = Convert.ToInt32(txtPersonelID.Text);
                int cep = Convert.ToInt32(txtCepNo.Text);
                DateTime dt = Convert.ToDateTime(txtDogumTarihi.Text);
                DateTime tarih = Convert.ToDateTime(txtTarih.Text);
                int adresid = Convert.ToInt32(cmbAdres.SelectedValue);
                int meslekid = Convert.ToInt32(cmbMeslek.SelectedValue);
                int cinid = Convert.ToInt32(cmbCinsiyet.SelectedValue);
                if (FotografYolu == null)
                {
                    pictureBox1.ImageLocation = Application.StartupPath + "\\pers.png";
                    FotografYolu = pictureBox1.ImageLocation;
                    int sonuc = (int)bl.PersonelBilgileriGüncelle(txtAd.Text, txtSoyad.Text, tc, perid, cep, dt, tarih,
                   adresid, meslekid, cinid, FotografYolu);
                    if (sonuc > 0)
                    {
                        MessageBox.Show("İşlem Başarılı!");
                    }
                }
                else
                {
                    int sonuc = (int)bl.PersonelBilgileriGüncelle(txtAd.Text, txtSoyad.Text, tc, perid, cep, dt, tarih,
                    adresid, meslekid, cinid, FotografYolu, foto);
                    if (sonuc > 0)
                    {
                        MessageBox.Show("İşlem Başarılı!");
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex+"");
            }
            

        }

        string FotografYolu;
        byte[] foto = new byte[1];
        private void btnYükle_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {

                string kaynak = openFileDialog1.FileName;
                string uzanti = Path.GetExtension(kaynak);
                
                RastgeleIsimUret r = new RastgeleIsimUret();
                string isim = r.IsimGetir();
                string hedef = Application.StartupPath + "\\images\\personelresimleri\\" + isim + uzanti;

                FotografYolu = "\\images\\personelresimleri\\" + isim + uzanti;

                File.Copy(kaynak, hedef);

                pictureBox1.ImageLocation = hedef;

                //----------------------------------------------

                System.Drawing.Image img = Image.FromFile(hedef);

                foto = Donusum.imageToByteArray(img);


            }
            else
            {
                MessageBox.Show("işlem İptal Edildi.");


            }


        }
    }
}
