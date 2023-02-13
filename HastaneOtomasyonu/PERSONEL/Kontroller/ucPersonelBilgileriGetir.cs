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
    public partial class ucPersonelBilgileriGetir : UserControl
    {
        public ucPersonelBilgileriGetir()
        {
            InitializeComponent();
        }

        private void btnPersonelBilgileriGetir_Click(object sender, EventArgs e)
        {
            
            PersonelBL bl = new PersonelBL();
            int perid = Convert.ToInt32(txtPersonelID.Text);
            lblAd.Text = bl.PersonelBilgileriGetir(perid).PersonelAdi;
            lblSoyad.Text = bl.PersonelBilgileriGetir(perid).PersonelSoyadi;
            lblDogumTarihi.Text = bl.PersonelBilgileriGetir(perid).DogumTarihi.ToString();
            lblTc.Text = bl.PersonelBilgileriGetir(perid).TcNo.ToString();
            lblİseBaslamaTarihi.Text = bl.PersonelBilgileriGetir(perid).İseBaslamaTarihi.ToString();
            lblCepTelefonu.Text = bl.PersonelBilgileriGetir(perid).CepTelefonu.ToString();
            lblAdres.Text = bl.PersonelBilgileriGetir(perid).Adres.ToString();
            lblMeslek.Text = bl.PersonelBilgileriGetir(perid).Meslek.ToString();
            lblCinsiyet.Text = bl.PersonelBilgileriGetir(perid).Cinsiyet.ToString();

           
            pictureBox1.ImageLocation = Application.StartupPath + bl.PersonelBilgileriGetir(perid).FotografYolu;

            if (bl.PersonelBilgileriGetir(perid).FotografYolu =="")
            {
                pictureBox1.ImageLocation = Application.StartupPath + "\\pers.png";

            }

        }

        private void ucPersonelBilgileriGetir_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation= Application.StartupPath + "\\pers.png";
        }
    }
}
